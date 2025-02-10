// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Model factory for models. </summary>
    public static partial class CallAutomationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CallAutomation.TransferCallToParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.TransferCallToParticipantResult"/> instance for mocking. </returns>
        public static TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null)
        {
            return new TransferCallToParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.SendDtmfTonesResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.SendDtmfTonesResult"/> instance for mocking. </returns>
        public static SendDtmfTonesResult SendDtmfTonesResult(string operationContext = null)
        {
            return new SendDtmfTonesResult(operationContext);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.MuteParticipantResult"/> instance for mocking. </returns>
        public static MuteParticipantResult MuteParticipantResult(string operationContext = null)
        {
            return new MuteParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.UnmuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallAutomation.UnmuteParticipantResult"/> instance for mocking. </returns>
        public static UnmuteParticipantResult UnmuteParticipantResult(string operationContext = null)
        {
            return new UnmuteParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.RecordingResult"/>. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingStorageInfo"> Container for chunks. </param>
        /// <param name="errors"></param>
        /// <param name="recordingStartTime"></param>
        /// <param name="recordingDurationMs"></param>
        /// <param name="sessionEndReason"></param>
        /// <param name="recordingExpirationTime"></param>
        /// <returns> A new <see cref="CallAutomation.RecordingResult"/> instance for mocking. </returns>
        public static RecordingResult RecordingResult(string recordingId = null, RecordingStorageInfo recordingStorageInfo = null, IEnumerable<ErrorDetails> errors = null, DateTimeOffset? recordingStartTime = null, long? recordingDurationMs = null, CallSessionEndReason? sessionEndReason = null, DateTimeOffset? recordingExpirationTime = null)
        {
            errors ??= new List<ErrorDetails>();

            return new RecordingResult(
                recordingId,
                recordingStorageInfo,
                errors?.ToList(),
                recordingStartTime,
                recordingDurationMs,
                sessionEndReason,
                recordingExpirationTime);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.RecordingStorageInfo"/>. </summary>
        /// <param name="recordingChunks"> Collection of {Microsoft.Skype.Platform.ExecutionAgent.Azure.Communication.Service.ServerCalling.Content.Contracts.ALPHA4_2024_09_01_preview.Models.RecordingChunkStorageInfo}. </param>
        /// <returns> A new <see cref="CallAutomation.RecordingStorageInfo"/> instance for mocking. </returns>
        public static RecordingStorageInfo RecordingStorageInfo(IEnumerable<RecordingChunkStorageInfo> recordingChunks = null)
        {
            recordingChunks ??= new List<RecordingChunkStorageInfo>();

            return new RecordingStorageInfo(recordingChunks?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.RecordingChunkStorageInfo"/>. </summary>
        /// <param name="documentId"> Chunk document id. </param>
        /// <param name="index"> Chunks order in a multi chunk recording. </param>
        /// <param name="endReason"> Reason this chunk ended. </param>
        /// <param name="contentLocation"> Location of the chunk. </param>
        /// <param name="metadataLocation"> Location of chunk metadata. </param>
        /// <param name="deleteLocation"> Callback for deleting chunk. </param>
        /// <returns> A new <see cref="CallAutomation.RecordingChunkStorageInfo"/> instance for mocking. </returns>
        public static RecordingChunkStorageInfo RecordingChunkStorageInfo(string documentId = null, int? index = null, ChunkEndReason? endReason = null, string contentLocation = null, string metadataLocation = null, string deleteLocation = null)
        {
            return new RecordingChunkStorageInfo(
                documentId,
                index,
                endReason,
                contentLocation,
                metadataLocation,
                deleteLocation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.ErrorDetails"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="innerError"> Inner error details. </param>
        /// <returns> A new <see cref="CallAutomation.ErrorDetails"/> instance for mocking. </returns>
        public static ErrorDetails ErrorDetails(string code = null, string message = null, ErrorDetails innerError = null)
        {
            return new ErrorDetails(code, message, innerError);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.ResultInformation"/>. </summary>
        /// <param name="code"> Code of the current result. This can be helpful to Call Automation team to troubleshoot the issue if this result was unexpected. </param>
        /// <param name="subCode"> Subcode of the current result. This can be helpful to Call Automation team to troubleshoot the issue if this result was unexpected. </param>
        /// <param name="message"> Detail message that describes the current result. </param>
        /// <returns> A new <see cref="CallAutomation.ResultInformation"/> instance for mocking. </returns>
        public static ResultInformation ResultInformation(int? code = null, int? subCode = null, string message = null)
        {
            return new ResultInformation(code, subCode, message);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.DtmfResult"/>. </summary>
        /// <param name="tones"></param>
        /// <returns> A new <see cref="CallAutomation.DtmfResult"/> instance for mocking. </returns>
        public static DtmfResult DtmfResult(IEnumerable<DtmfTone> tones = null)
        {
            tones ??= new List<DtmfTone>();

            return new DtmfResult(tones?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.ChoiceResult"/>. </summary>
        /// <param name="label"> Label is the primary identifier for the choice detected. </param>
        /// <param name="recognizedPhrase">
        /// Phrases are set to the value if choice is selected via phrase detection.
        /// If Dtmf input is recognized, then Label will be the identifier for the choice detected and phrases will be set to null
        /// </param>
        /// <returns> A new <see cref="CallAutomation.ChoiceResult"/> instance for mocking. </returns>
        public static ChoiceResult ChoiceResult(string label = null, string recognizedPhrase = null)
        {
            return new ChoiceResult(label, recognizedPhrase);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.SpeechResult"/>. </summary>
        /// <param name="speech"> The recognized speech in string. </param>
        /// <returns> A new <see cref="CallAutomation.SpeechResult"/> instance for mocking. </returns>
        public static SpeechResult SpeechResult(string speech = null)
        {
            return new SpeechResult(speech);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.UserConsent"/>. </summary>
        /// <param name="recording"></param>
        /// <returns> A new <see cref="CallAutomation.UserConsent"/> instance for mocking. </returns>
        public static UserConsent UserConsent(int? recording = null)
        {
            return new UserConsent(recording);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.StartRecordingFailed"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. </param>
        /// <param name="recordingId"> The call recording id. </param>
        /// <returns> A new <see cref="CallAutomation.StartRecordingFailed"/> instance for mocking. </returns>
        public static StartRecordingFailed StartRecordingFailed(string callConnectionId = null, string correlationId = null, string recordingId = null)
        {
            return new StartRecordingFailed(callConnectionId, correlationId, recordingId);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionStarted"/>. </summary>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionStarted"/> instance for mocking. </returns>
        public static TranscriptionStarted TranscriptionStarted(TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new TranscriptionStarted(
                transcriptionUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionUpdate"/>. </summary>
        /// <param name="transcriptionStatus"></param>
        /// <param name="transcriptionStatusDetails"></param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionUpdate"/> instance for mocking. </returns>
        public static TranscriptionUpdate TranscriptionUpdate(TranscriptionStatus? transcriptionStatus = null, TranscriptionStatusDetails? transcriptionStatusDetails = null)
        {
            return new TranscriptionUpdate(transcriptionStatus, transcriptionStatusDetails);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionStopped"/>. </summary>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionStopped"/> instance for mocking. </returns>
        public static TranscriptionStopped TranscriptionStopped(TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new TranscriptionStopped(
                transcriptionUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionFailed"/>. </summary>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionFailed"/> instance for mocking. </returns>
        public static TranscriptionFailed TranscriptionFailed(TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new TranscriptionFailed(
                transcriptionUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.TranscriptionUpdated"/>. </summary>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.TranscriptionUpdated"/> instance for mocking. </returns>
        public static TranscriptionUpdated TranscriptionUpdated(TranscriptionUpdate transcriptionUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new TranscriptionUpdated(
                transcriptionUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MediaStreamingFailed"/>. </summary>
        /// <param name="mediaStreamingUpdate"> Defines the result for MediaStreamingUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.MediaStreamingFailed"/> instance for mocking. </returns>
        public static MediaStreamingFailed MediaStreamingFailed(MediaStreamingUpdate mediaStreamingUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new MediaStreamingFailed(
                mediaStreamingUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MediaStreamingUpdate"/>. </summary>
        /// <param name="contentType"></param>
        /// <param name="mediaStreamingStatus"></param>
        /// <param name="mediaStreamingStatusDetails"></param>
        /// <returns> A new <see cref="CallAutomation.MediaStreamingUpdate"/> instance for mocking. </returns>
        public static MediaStreamingUpdate MediaStreamingUpdate(string contentType = null, MediaStreamingStatus? mediaStreamingStatus = null, MediaStreamingStatusDetails? mediaStreamingStatusDetails = null)
        {
            return new MediaStreamingUpdate(contentType, mediaStreamingStatus, mediaStreamingStatusDetails);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MediaStreamingStarted"/>. </summary>
        /// <param name="mediaStreamingUpdate"> Defines the result for MediaStreamingUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.MediaStreamingStarted"/> instance for mocking. </returns>
        public static MediaStreamingStarted MediaStreamingStarted(MediaStreamingUpdate mediaStreamingUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new MediaStreamingStarted(
                mediaStreamingUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Initializes a new instance of <see cref="CallAutomation.MediaStreamingStopped"/>. </summary>
        /// <param name="mediaStreamingUpdate"> Defines the result for MediaStreamingUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <returns> A new <see cref="CallAutomation.MediaStreamingStopped"/> instance for mocking. </returns>
        public static MediaStreamingStopped MediaStreamingStopped(MediaStreamingUpdate mediaStreamingUpdate = null, string callConnectionId = null, string serverCallId = null, string correlationId = null, string operationContext = null, ResultInformation resultInformation = null)
        {
            return new MediaStreamingStopped(
                mediaStreamingUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }
    }
}
