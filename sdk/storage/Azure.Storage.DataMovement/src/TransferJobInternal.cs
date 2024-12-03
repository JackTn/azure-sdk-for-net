﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Common;

namespace Azure.Storage.DataMovement
{
    internal class TransferJobInternal : IDisposable
    {
        internal delegate Task<JobPartInternal> CreateJobPartSingleAsync(
            TransferJobInternal job,
            int partNumber);

        internal delegate Task<JobPartInternal> CreateJobPartMultiAsync(
            TransferJobInternal job,
            int partNumber,
            StorageResourceItem sourceResource,
            StorageResourceItem destinationResource);

        /// <summary>
        /// DataTransfer communicate when the transfer has finished and the progress
        /// </summary>
        internal DataTransfer _dataTransfer { get; set; }

        private readonly CreateJobPartSingleAsync _createJobPartSingleAsync;

        private readonly CreateJobPartMultiAsync _createJobPartMultiAsync;

        /// <summary>
        /// Plan file writer for the respective job
        /// </summary>
        internal ITransferCheckpointer _checkpointer { get; set; }

        /// <summary>
        /// Internal progress tracker for tracking and reporting progress of the transfer
        /// </summary>
        internal TransferProgressTracker _progressTracker;

        /// <summary>
        /// Source resource
        /// </summary>
        internal StorageResourceItem _sourceResource;

        /// <summary>
        /// Destination Resource
        /// </summary>
        internal StorageResourceItem _destinationResource;

        /// <summary>
        /// Source resource
        /// </summary>
        internal StorageResourceContainer _sourceResourceContainer;

        /// <summary>
        /// Destination Resource
        /// </summary>
        internal StorageResourceContainer _destinationResourceContainer;

        /// <summary>
        /// The maximum size to use for each chunk when transferring data in chunks.
        ///
        /// This is the user specified value from options bag.
        /// </summary>
        internal long? _maximumTransferChunkSize { get; set; }

        /// <summary>
        /// The size of the first range request in bytes. Single Transfer sizes smaller than this
        /// limit will be Uploaded or Downloaded in a single request. Transfers larger than this
        /// limit will continue being downloaded or uploaded in chunks of size
        /// <see cref="_maximumTransferChunkSize"/>.
        ///
        /// This is the user specified value from options bag.
        /// </summary>
        internal long? _initialTransferSize { get; set; }

        /// <summary>
        /// Defines whether the transfer will be only a single transfer, or
        /// a container transfer
        /// </summary>
        internal bool _isSingleResource;

        /// <summary>
        /// The error handling options
        /// </summary>
        internal DataTransferErrorMode _errorMode;

        /// <summary>
        /// Determines how files are created or if they should be overwritten if they already exists
        /// </summary>
        internal StorageResourceCreationPreference _creationPreference;

        /// <summary>
        /// Considering if there's more than one job part, the transfer status will need to be set to
        /// completed all job parts have been set to completed.
        /// </summary>
        public event SyncAsyncEventHandler<TransferStatusEventArgs> JobPartStatusEvents;
        public SyncAsyncEventHandler<TransferStatusEventArgs> GetJobPartStatus() => JobPartStatusEvents;

        /// <summary>
        /// If the transfer status of the job changes then the event will get added to this handler.
        /// </summary>
        public SyncAsyncEventHandler<TransferStatusEventArgs> TransferStatusEventHandler { get; internal set; }

        /// <summary>
        /// If the transfer has any failed events that occur the event will get added to this handler.
        /// </summary>
        public SyncAsyncEventHandler<TransferItemFailedEventArgs> TransferFailedEventHandler { get; internal set; }

        /// <summary>
        /// Number of single transfers skipped during Transfer due to no overwrite allowed as specified in
        /// <see cref="StorageResourceCreationPreference.SkipIfExists"/>
        /// </summary>
        public SyncAsyncEventHandler<TransferItemSkippedEventArgs> TransferSkippedEventHandler { get; internal set; }

        /// <summary>
        /// If a single transfer within the resource container gets transferred successfully the event
        /// will get added to this handler
        /// </summary>
        public SyncAsyncEventHandler<TransferItemCompletedEventArgs> TransferItemCompletedEventHandler { get; internal set; }

        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary>
        /// Array pools for reading from streams to upload
        /// </summary>
        public ArrayPool<byte> UploadArrayPool => _arrayPool;
        internal ArrayPool<byte> _arrayPool;

        public List<JobPartInternal> _jobParts;
        internal bool _enumerationComplete;
        private int _pendingJobParts;
        private bool _jobPartPaused;

        public CancellationToken _cancellationToken { get; internal set; }

        /// <summary>
        /// Constructor for mocking
        /// </summary>
        internal protected TransferJobInternal()
        {
        }

        private TransferJobInternal(
            DataTransfer dataTransfer,
            CreateJobPartSingleAsync createJobPartSingleAsync,
            CreateJobPartMultiAsync createJobPartMultiAsync,
            ITransferCheckpointer checkPointer,
            DataTransferErrorMode errorHandling,
            long? initialTransferSize,
            long? maximumTransferChunkSize,
            StorageResourceCreationPreference creationPreference,
            ArrayPool<byte> arrayPool,
            SyncAsyncEventHandler<TransferStatusEventArgs> statusEventHandler,
            SyncAsyncEventHandler<TransferItemFailedEventArgs> failedEventHandler,
            SyncAsyncEventHandler<TransferItemSkippedEventArgs> skippedEventHandler,
            SyncAsyncEventHandler<TransferItemCompletedEventArgs> singleTransferEventHandler,
            ClientDiagnostics clientDiagnostics)
        {
            Argument.AssertNotNull(clientDiagnostics, nameof(clientDiagnostics));

            _dataTransfer = dataTransfer ?? throw Errors.ArgumentNull(nameof(dataTransfer));
            _dataTransfer.TransferStatus.SetTransferStateChange(DataTransferState.Queued);
            _createJobPartSingleAsync = createJobPartSingleAsync;
            _createJobPartMultiAsync = createJobPartMultiAsync;
            _checkpointer = checkPointer;
            _arrayPool = arrayPool;
            _jobParts = new List<JobPartInternal>();
            _enumerationComplete = false;
            _pendingJobParts = 0;
            _cancellationToken = dataTransfer._state.CancellationTokenSource.Token;

            // These options come straight from user-provided options bags and are saved
            // as-is on the job. They may be adjusted with the defaults on job part
            // construction (regular or from checkpoint).
            _initialTransferSize = initialTransferSize;
            _maximumTransferChunkSize = maximumTransferChunkSize;
            _errorMode = errorHandling;
            _creationPreference = creationPreference;

            JobPartStatusEvents += JobPartEventAsync;
            TransferStatusEventHandler = statusEventHandler;
            TransferFailedEventHandler = failedEventHandler;
            TransferSkippedEventHandler = skippedEventHandler;
            TransferItemCompletedEventHandler = singleTransferEventHandler;
            ClientDiagnostics = clientDiagnostics;
        }

        /// <summary>
        /// Create Storage Transfer Job.
        /// </summary>
        internal TransferJobInternal(
            DataTransfer dataTransfer,
            StorageResourceItem sourceResource,
            StorageResourceItem destinationResource,
            CreateJobPartSingleAsync createJobPartSingleAsync,
            CreateJobPartMultiAsync createJobPartMultiAsync,
            DataTransferOptions transferOptions,
            ITransferCheckpointer checkpointer,
            DataTransferErrorMode errorHandling,
            ArrayPool<byte> arrayPool,
            ClientDiagnostics clientDiagnostics)
            : this(dataTransfer,
                  createJobPartSingleAsync,
                  createJobPartMultiAsync,
                  checkpointer,
                  errorHandling,
                  transferOptions.InitialTransferSize,
                  transferOptions.MaximumTransferChunkSize,
                  transferOptions.CreationPreference,
                  arrayPool,
                  transferOptions.GetTransferStatus(),
                  transferOptions.GetFailed(),
                  transferOptions.GetSkipped(),
                  default,
                  clientDiagnostics)
        {
            _sourceResource = sourceResource;
            _destinationResource = destinationResource;
            _isSingleResource = true;
            _progressTracker = new TransferProgressTracker(transferOptions?.ProgressHandlerOptions);
        }

        /// <summary>
        /// Create Storage Transfer Job.
        /// </summary>
        internal TransferJobInternal(
            DataTransfer dataTransfer,
            StorageResourceContainer sourceResource,
            StorageResourceContainer destinationResource,
            CreateJobPartSingleAsync createJobPartSingleAsync,
            CreateJobPartMultiAsync createJobPartMultiAsync,
            DataTransferOptions transferOptions,
            ITransferCheckpointer checkpointer,
            DataTransferErrorMode errorHandling,
            ArrayPool<byte> arrayPool,
            ClientDiagnostics clientDiagnostics)
            : this(dataTransfer,
                  createJobPartSingleAsync,
                  createJobPartMultiAsync,
                  checkpointer,
                  errorHandling,
                  transferOptions.InitialTransferSize,
                  transferOptions.MaximumTransferChunkSize,
                  transferOptions.CreationPreference,
                  arrayPool,
                  transferOptions.GetTransferStatus(),
                  transferOptions.GetFailed(),
                  transferOptions.GetSkipped(),
                  transferOptions.GetCompleted(),
                  clientDiagnostics)
        {
            _sourceResourceContainer = sourceResource;
            _destinationResourceContainer = destinationResource;
            _isSingleResource = false;
            _progressTracker = new TransferProgressTracker(transferOptions?.ProgressHandlerOptions);
        }

        public void Dispose()
        {
            DisposeHandlers();
        }

        public void DisposeHandlers()
        {
            if (JobPartStatusEvents != default)
            {
                JobPartStatusEvents -= JobPartEventAsync;
            }
        }

        /// <summary>
        /// Processes the job to job parts
        /// </summary>
        /// <returns>An IEnumerable that contains the job parts</returns>
        public virtual async IAsyncEnumerable<JobPartInternal> ProcessJobToJobPartAsync()
        {
            try
            {
                // only change state to 'InProgress' if it was 'Queued'
                // (this is to prevent 'Pausing' to be changed)
                if (_dataTransfer.TransferStatus.State == DataTransferState.Queued)
                {
                    await OnJobStateChangedAsync(DataTransferState.InProgress).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                yield break;
            }
            int partNumber = 0;

            if (_jobParts.Count == 0)
            {
                // Starting brand new job
                if (_isSingleResource)
                {
                    JobPartInternal part = default;
                    try
                    {
                        // Single resource transfer, we can skip to chunking the job.
                        part = await _createJobPartSingleAsync(this, partNumber).ConfigureAwait(false);
                        AppendJobPart(part);
                        await OnAllResourcesEnumeratedAsync().ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                        yield break;
                    }
                    yield return part;
                }
                else
                {
                    await foreach (JobPartInternal part in EnumerateAndCreateJobPartsAsync().ConfigureAwait(false))
                    {
                        yield return part;
                    }
                }
            }
            else
            {
                // Resuming old job with existing job parts
                foreach (JobPartInternal part in _jobParts)
                {
                    if (!part.JobPartStatus.HasCompletedSuccessfully)
                    {
                        part.JobPartStatus.SetTransferStateChange(DataTransferState.Queued);
                        yield return part;
                    }
                }

                bool isEnumerationComplete;
                try
                {
                    isEnumerationComplete = await _checkpointer.IsEnumerationCompleteAsync(_dataTransfer.Id, _cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                    yield break;
                }

                if (!isEnumerationComplete)
                {
                    await foreach (JobPartInternal jobPartInternal in EnumerateAndCreateJobPartsAsync().ConfigureAwait(false))
                    {
                        yield return jobPartInternal;
                    }
                }
            }

            try
            {
                // Call regardless of the outcome of enumeration so job can pause/finish
                await OnEnumerationCompleteAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await InvokeFailedArgAsync(ex).ConfigureAwait(false);
            }
        }

        private async IAsyncEnumerable<JobPartInternal> EnumerateAndCreateJobPartsAsync()
        {
            // Start the partNumber based on the last part number. If this is a new job,
            // the count will automatically be at 0 (the beginning).
            int partNumber = _jobParts.Count;
            HashSet<Uri> existingSources = GetJobPartSourceResourcePaths();
            // Call listing operation on the source container
            IAsyncEnumerator<StorageResource> enumerator;

            // Obtain enumerator and check for any point of failure before we attempt to list
            // and fail gracefully.
            try
            {
                enumerator = _sourceResourceContainer.GetStorageResourcesAsync(
                        destinationContainer: _destinationResourceContainer,
                        cancellationToken: _cancellationToken).GetAsyncEnumerator();
            }
            catch (Exception ex)
            {
                await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                yield break;
            }

            // List the container in this specific way because MoveNext needs to be separately wrapped
            // in a try/catch as we can't yield return inside a try/catch.
            bool enumerationCompleted = false;
            while (!enumerationCompleted)
            {
                try
                {
                    _cancellationToken.ThrowIfCancellationRequested();
                    if (!await enumerator.MoveNextAsync().ConfigureAwait(false))
                    {
                        await OnAllResourcesEnumeratedAsync().ConfigureAwait(false);
                        enumerationCompleted = true;
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                    yield break;
                }

                StorageResource current = enumerator.Current;

                if (current.IsContainer)
                {
                    // Create sub-container
                    string containerUriPath = _sourceResourceContainer.Uri.GetPath();
                    string subContainerPath = string.IsNullOrEmpty(containerUriPath)
                        ? current.Uri.GetPath()
                        : current.Uri.GetPath().Substring(containerUriPath.Length + 1);
                    StorageResourceContainer subContainer =
                        _destinationResourceContainer.GetChildStorageResourceContainer(subContainerPath);

                    try
                    {
                        await subContainer.CreateIfNotExistsAsync(_cancellationToken).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                        yield break;
                    }
                }
                else
                {
                    if (!existingSources.Contains(current.Uri))
                    {
                        string containerUriPath = _sourceResourceContainer.Uri.GetPath();
                        string sourceName = string.IsNullOrEmpty(containerUriPath)
                            ? current.Uri.GetPath()
                            : current.Uri.GetPath().Substring(containerUriPath.Length + 1);

                        JobPartInternal part;
                        try
                        {
                            StorageResourceItem sourceItem = (StorageResourceItem)current;
                            part = await _createJobPartMultiAsync(
                                this,
                                partNumber,
                                sourceItem,
                                _destinationResourceContainer.GetStorageResourceReference(sourceName, sourceItem.ResourceId))
                                .ConfigureAwait(false);
                            AppendJobPart(part);
                        }
                        catch (Exception ex)
                        {
                            await InvokeFailedArgAsync(ex).ConfigureAwait(false);
                            yield break;
                        }
                        yield return part;
                        partNumber++;
                    }
                }
            }
        }

        /// <summary>
        /// Triggers the cancellation for the Job Part.
        ///
        /// If the cancellation token was called to cancelled, change the status to Stopping.
        /// </summary>
        /// <returns>The task to wait until the cancellation has been triggered.</returns>
        public async Task TriggerJobCancellationAsync()
        {
            if (!_dataTransfer._state.CancellationTokenSource.IsCancellationRequested)
            {
                await OnJobStateChangedAsync(DataTransferState.Stopping).ConfigureAwait(false);
                _dataTransfer._state.TriggerCancellation();
            }
        }

        /// <summary>
        /// Invokes Failed Argument Event.
        /// </summary>
        /// <param name="ex">The exception which caused the failed argument event to be raised.</param>
        /// <returns></returns>
        public async virtual Task InvokeFailedArgAsync(Exception ex)
        {
            if (ex is not OperationCanceledException &&
                ex is not TaskCanceledException &&
                !ex.Message.Contains("The request was canceled."))
            {
                if (TransferFailedEventHandler != null)
                {
                    await TransferFailedEventHandler.RaiseAsync(
                        new TransferItemFailedEventArgs(
                            _dataTransfer.Id,
                            (StorageResource)_sourceResource ?? _sourceResourceContainer,
                            (StorageResource)_destinationResource ?? _destinationResourceContainer,
                            ex,
                            false,
                            _cancellationToken),
                        nameof(TransferJobInternal),
                        nameof(TransferFailedEventHandler),
                        ClientDiagnostics)
                        .ConfigureAwait(false);
                }
                _dataTransfer.TransferStatus.SetFailedItem();
            }

            try
            {
                await TriggerJobCancellationAsync().ConfigureAwait(false);

                // If we're failing from a Transfer Job point, it means we have aborted the job
                // at the listing phase. However it's possible that some job parts may be in flight
                // and we have to check if they're finished cleaning up yet.
                await CheckAndUpdateStatusAsync().ConfigureAwait(false);
            }
            catch (Exception cancellationException)
            {
                if (TransferFailedEventHandler != null)
                {
                    await TransferFailedEventHandler.RaiseAsync(
                        new TransferItemFailedEventArgs(
                            _dataTransfer.Id,
                            _sourceResource,
                            _destinationResource,
                            cancellationException,
                            false,
                            _cancellationToken),
                        nameof(TransferJobInternal),
                        nameof(TransferFailedEventHandler),
                        ClientDiagnostics)
                        .ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// In order to properly propagate the transfer status events of each job part up
        /// until all job parts have completed.
        /// </summary>
        public async Task JobPartEventAsync(TransferStatusEventArgs args)
        {
            DataTransferStatus jobPartStatus = args.TransferStatus;
            DataTransferState jobState = _dataTransfer._state.GetTransferStatus().State;

            // Keep track of paused, failed, and skipped which we will use to determine final job status
            // Since this is each Job Part coming in, the state of skipped or failed is mutually exclusive.
            if (jobPartStatus.State == DataTransferState.Paused)
            {
                _jobPartPaused = true;
            }
            else if (jobPartStatus.HasFailedItems)
            {
                if (_dataTransfer._state.SetFailedItemsState())
                {
                    await SetCheckpointerStatusAsync().ConfigureAwait(false);
                    await OnJobPartStatusChangedAsync().ConfigureAwait(false);
                }
            }
            else if (jobPartStatus.HasSkippedItems)
            {
                if (_dataTransfer._state.SetSkippedItemsState())
                {
                    await SetCheckpointerStatusAsync().ConfigureAwait(false);
                    await OnJobPartStatusChangedAsync().ConfigureAwait(false);
                }
            }

            // Cancel the entire job if one job part fails and StopOnFailure is set
            if (_errorMode == DataTransferErrorMode.StopOnAnyFailure &&
                jobPartStatus.HasFailedItems &&
                jobState != DataTransferState.Stopping &&
                jobState != DataTransferState.Completed)
            {
                await TriggerJobCancellationAsync().ConfigureAwait(false);
                jobState = _dataTransfer._state.GetTransferStatus().State;
            }

            if ((jobPartStatus.State == DataTransferState.Paused ||
                 jobPartStatus.State == DataTransferState.Completed)
                && (jobState == DataTransferState.Queued ||
                    jobState == DataTransferState.InProgress ||
                    jobState == DataTransferState.Pausing ||
                    jobState == DataTransferState.Stopping))
            {
                Interlocked.Decrement(ref _pendingJobParts);

                if (_enumerationComplete)
                {
                    await CheckAndUpdateStatusAsync().ConfigureAwait(false);
                }
            }
        }

        public async Task OnJobStateChangedAsync(DataTransferState state)
        {
            if (_dataTransfer._state.SetTransferState(state))
            {
                // If we are in a final state, dispose the JobPartEvent handlers
                if (state == DataTransferState.Completed ||
                    state == DataTransferState.Paused)
                {
                    DisposeHandlers();
                }

                await OnJobPartStatusChangedAsync().ConfigureAwait(false);
                await SetCheckpointerStatusAsync().ConfigureAwait(false);
            }
        }

        public async Task OnJobPartStatusChangedAsync()
        {
            if (TransferStatusEventHandler != null)
            {
                await TransferStatusEventHandler.RaiseAsync(
                    new TransferStatusEventArgs(
                        transferId: _dataTransfer.Id,
                        transferStatus: _dataTransfer.TransferStatus.DeepCopy(),
                        isRunningSynchronously: false,
                        cancellationToken: _cancellationToken),
                    nameof(TransferJobInternal),
                    nameof(TransferStatusEventHandler),
                    ClientDiagnostics).ConfigureAwait(false);
            }
        }

        internal async virtual Task SetCheckpointerStatusAsync()
        {
            await _checkpointer.SetJobStatusAsync(
                transferId: _dataTransfer.Id,
                status: _dataTransfer.TransferStatus).ConfigureAwait(false);
        }

        /// <summary>
        /// Called when enumeration is complete whether it finished successfully, failed, or was paused.
        /// All resources may or may not have been enumerated.
        /// </summary>
        protected async Task OnEnumerationCompleteAsync()
        {
            _enumerationComplete = true;

            // If there were no job parts enumerated and we haven't already aborted/completed the job.
            if (_jobParts.Count == 0 &&
                _dataTransfer.TransferStatus.State != DataTransferState.Paused &&
                _dataTransfer.TransferStatus.State != DataTransferState.Completed)
            {
                if (_dataTransfer.TransferStatus.State == DataTransferState.Pausing)
                {
                    // If we paused before we were able to list, set the status properly.
                    await OnJobStateChangedAsync(DataTransferState.Paused).ConfigureAwait(false);
                }
                else
                {
                    await OnJobStateChangedAsync(DataTransferState.Completed).ConfigureAwait(false);
                }
            }
            await CheckAndUpdateStatusAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Called when all resources have been enumerated successfully.
        /// </summary>
        protected async Task OnAllResourcesEnumeratedAsync()
        {
            await _checkpointer.SetEnumerationCompleteAsync(_dataTransfer.Id, _cancellationToken).ConfigureAwait(false);
        }

        internal async Task CheckAndUpdateStatusAsync()
        {
            // If we had a failure or pause during listing, we need to set the status correctly.
            // This is in the case that we weren't able to begin listing any job parts yet.
            if (_jobParts.Count == 0)
            {
                if (_dataTransfer.TransferStatus.State == DataTransferState.Pausing)
                {
                    await OnJobStateChangedAsync(DataTransferState.Paused).ConfigureAwait(false);
                }
                else if (_dataTransfer.TransferStatus.State == DataTransferState.Stopping)
                {
                    await OnJobStateChangedAsync(DataTransferState.Completed).ConfigureAwait(false);
                }
                return;
            }

            // If there are no more pending job parts, complete the job
            if (_pendingJobParts == 0)
            {
                if (_jobPartPaused)
                {
                    await OnJobStateChangedAsync(DataTransferState.Paused).ConfigureAwait(false);
                }
                else
                {
                    await OnJobStateChangedAsync(DataTransferState.Completed).ConfigureAwait(false);
                }
            }
        }

        public void AppendJobPart(JobPartInternal jobPart)
        {
            _jobParts.Add(jobPart);

            // Job parts can come from resuming a transfer and therefore may already be complete
            DataTransferStatus status = jobPart.JobPartStatus;
            if (status.State != DataTransferState.Completed)
            {
                Interlocked.Increment(ref _pendingJobParts);
            }
        }

        internal HashSet<Uri> GetJobPartSourceResourcePaths()
        {
            return new HashSet<Uri>(_jobParts.Select(x => x._sourceResource.Uri));
        }

        internal void IncrementJobParts()
        {
            _progressTracker.IncrementQueuedFiles();
        }
    }
}
