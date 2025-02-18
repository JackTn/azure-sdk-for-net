// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations.Models
{
    internal partial class DataflowEndpointAuthenticationAccessToken : IUtf8JsonSerializable, IJsonModel<DataflowEndpointAuthenticationAccessToken>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointAuthenticationAccessToken>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointAuthenticationAccessToken>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointAuthenticationAccessToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointAuthenticationAccessToken)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("secretRef"u8);
            writer.WriteStringValue(SecretRef);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataflowEndpointAuthenticationAccessToken IJsonModel<DataflowEndpointAuthenticationAccessToken>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointAuthenticationAccessToken>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointAuthenticationAccessToken)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointAuthenticationAccessToken(document.RootElement, options);
        }

        internal static DataflowEndpointAuthenticationAccessToken DeserializeDataflowEndpointAuthenticationAccessToken(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string secretRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretRef"u8))
                {
                    secretRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointAuthenticationAccessToken(secretRef, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointAuthenticationAccessToken>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointAuthenticationAccessToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointAuthenticationAccessToken)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointAuthenticationAccessToken IPersistableModel<DataflowEndpointAuthenticationAccessToken>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointAuthenticationAccessToken>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataflowEndpointAuthenticationAccessToken(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointAuthenticationAccessToken)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointAuthenticationAccessToken>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
