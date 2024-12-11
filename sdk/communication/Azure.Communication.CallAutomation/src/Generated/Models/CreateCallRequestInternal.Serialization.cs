// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class CreateCallRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SourceCallerIdNumber))
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                writer.WriteObjectValue(SourceCallerIdNumber);
            }
            if (Optional.IsDefined(SourceDisplayName))
            {
                writer.WritePropertyName("sourceDisplayName"u8);
                writer.WriteStringValue(SourceDisplayName);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsDefined(CallIntelligenceOptions))
            {
                writer.WritePropertyName("callIntelligenceOptions"u8);
                writer.WriteObjectValue(CallIntelligenceOptions);
            }
            if (Optional.IsDefined(TranscriptionConfiguration))
            {
                writer.WritePropertyName("transcriptionConfiguration"u8);
                writer.WriteObjectValue(TranscriptionConfiguration);
            }
            if (Optional.IsDefined(MediaStreamingConfiguration))
            {
                writer.WritePropertyName("mediaStreamingConfiguration"u8);
                writer.WriteObjectValue(MediaStreamingConfiguration);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
