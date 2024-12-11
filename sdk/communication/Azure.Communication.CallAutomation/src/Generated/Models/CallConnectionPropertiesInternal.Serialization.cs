// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    internal partial class CallConnectionPropertiesInternal
    {
        internal static CallConnectionPropertiesInternal DeserializeCallConnectionPropertiesInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string callConnectionId = default;
            string serverCallId = default;
            IReadOnlyList<CommunicationIdentifierModel> targets = default;
            CallConnectionState? callConnectionState = default;
            string callbackUri = default;
            string dataSubscriptionId = default;
            PhoneNumberIdentifierModel sourceCallerIdNumber = default;
            string sourceDisplayName = default;
            CommunicationIdentifierModel source = default;
            string correlationId = default;
            CommunicationUserIdentifierModel answeredBy = default;
            MediaStreamingSubscriptionInternal mediaStreamingSubscription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("callConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSubscriptionId"u8))
                {
                    dataSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCallerIdNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCallerIdNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDisplayName"u8))
                {
                    sourceDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("answeredBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answeredBy = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("mediaStreamingSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingSubscription = MediaStreamingSubscriptionInternal.DeserializeMediaStreamingSubscriptionInternal(property.Value);
                    continue;
                }
            }
            return new CallConnectionPropertiesInternal(
                callConnectionId,
                serverCallId,
                targets ?? new ChangeTrackingList<CommunicationIdentifierModel>(),
                callConnectionState,
                callbackUri,
                dataSubscriptionId,
                sourceCallerIdNumber,
                sourceDisplayName,
                source,
                correlationId,
                answeredBy,
                mediaStreamingSubscription);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CallConnectionPropertiesInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCallConnectionPropertiesInternal(document.RootElement);
        }
    }
}
