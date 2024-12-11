// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class MediaStreamingStopped
    {
        internal static MediaStreamingStopped DeserializeMediaStreamingStopped(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MediaStreamingUpdate mediaStreamingUpdate = default;
            string operationContext = default;
            ResultInformation resultInformation = default;
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaStreamingUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingUpdate = MediaStreamingUpdate.DeserializeMediaStreamingUpdate(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
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
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
            }
            return new MediaStreamingStopped(
                mediaStreamingUpdate,
                operationContext,
                resultInformation,
                callConnectionId,
                serverCallId,
                correlationId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MediaStreamingStopped FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMediaStreamingStopped(document.RootElement);
        }
    }
}
