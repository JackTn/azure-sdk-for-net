// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A Class representing a ReportResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ReportResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetReportResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetReportResource method.
    /// </summary>
    public partial class ReportResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReportResource"/> instance. </summary>
        /// <param name="reportName"> The reportName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string reportName)
        {
            var resourceId = $"/providers/Microsoft.AppComplianceAutomation/reports/{reportName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reportResourceReportClientDiagnostics;
        private readonly ReportRestOperations _reportResourceReportRestClient;
        private readonly ReportResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ReportResource"/> class for mocking. </summary>
        protected ReportResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ReportResource(ArmClient client, ReportResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ReportResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReportResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reportResourceReportClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string reportResourceReportApiVersion);
            _reportResourceReportRestClient = new ReportRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reportResourceReportApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppComplianceAutomation/reports";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ReportResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SnapshotResources in the ReportResource. </summary>
        /// <returns> An object representing collection of SnapshotResources and their operations over a SnapshotResource. </returns>
        public virtual SnapshotResourceCollection GetSnapshotResources()
        {
            return GetCachedClient(client => new SnapshotResourceCollection(client, Id));
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SnapshotResource>> GetSnapshotResourceAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            return await GetSnapshotResources().GetAsync(snapshotName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SnapshotResource> GetSnapshotResource(string snapshotName, CancellationToken cancellationToken = default)
        {
            return GetSnapshotResources().Get(snapshotName, cancellationToken);
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReportResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Get");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReportResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Get");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Delete");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.DeleteAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation(_reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateDeleteRequest(Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Delete");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.Delete(Id.Name, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation(_reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateDeleteRequest(Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an exiting AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<ReportResource>> UpdateAsync(WaitUntil waitUntil, ReportResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Update");
            scope.Start();
            try
            {
                var response = await _reportResourceReportRestClient.UpdateAsync(Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<ReportResource>(new ReportResourceOperationSource(Client), _reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateUpdateRequest(Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an exiting AppComplianceAutomation report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<ReportResource> Update(WaitUntil waitUntil, ReportResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _reportResourceReportClientDiagnostics.CreateScope("ReportResource.Update");
            scope.Start();
            try
            {
                var response = _reportResourceReportRestClient.Update(Id.Name, patch, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<ReportResource>(new ReportResourceOperationSource(Client), _reportResourceReportClientDiagnostics, Pipeline, _reportResourceReportRestClient.CreateUpdateRequest(Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
