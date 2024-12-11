// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Properties of a call connection. </summary>
    internal partial class CallConnectionPropertiesInternal
    {
        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        internal CallConnectionPropertiesInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="dataSubscriptionId"> SubscriptionId for transcription. </param>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </param>
        /// <param name="sourceDisplayName"> Display name of the call if dialing out to a pstn number. </param>
        /// <param name="source"> Source identity. </param>
        /// <param name="correlationId"> The correlation ID. </param>
        /// <param name="answeredBy"> Identity of the answering entity. Only populated when identity is provided in the request. </param>
        /// <param name="mediaStreamingSubscription"> The state of media streaming subscription for the call. </param>
        internal CallConnectionPropertiesInternal(string callConnectionId, string serverCallId, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string callbackUri, string dataSubscriptionId, PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationIdentifierModel source, string correlationId, CommunicationUserIdentifierModel answeredBy, MediaStreamingSubscriptionInternal mediaStreamingSubscription)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            Targets = targets;
            CallConnectionState = callConnectionState;
            CallbackUri = callbackUri;
            DataSubscriptionId = dataSubscriptionId;
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            Source = source;
            CorrelationId = correlationId;
            AnsweredBy = answeredBy;
            MediaStreamingSubscription = mediaStreamingSubscription;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> SubscriptionId for transcription. </summary>
        public string DataSubscriptionId { get; }
        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; }
        /// <summary> Display name of the call if dialing out to a pstn number. </summary>
        public string SourceDisplayName { get; }
        /// <summary> Source identity. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The correlation ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Identity of the answering entity. Only populated when identity is provided in the request. </summary>
        public CommunicationUserIdentifierModel AnsweredBy { get; }
        /// <summary> The state of media streaming subscription for the call. </summary>
        public MediaStreamingSubscriptionInternal MediaStreamingSubscription { get; }
    }
}
