// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class DataflowEndpointDataExplorerAuthentication : IUtf8JsonSerializable, IJsonModel<DataflowEndpointDataExplorerAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointDataExplorerAuthentication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointDataExplorerAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointDataExplorerAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointDataExplorerAuthentication)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("method"u8);
            writer.WriteStringValue(Method.ToString());
            if (Optional.IsDefined(SystemAssignedManagedIdentitySettings))
            {
                writer.WritePropertyName("systemAssignedManagedIdentitySettings"u8);
                writer.WriteObjectValue(SystemAssignedManagedIdentitySettings, options);
            }
            if (Optional.IsDefined(UserAssignedManagedIdentitySettings))
            {
                writer.WritePropertyName("userAssignedManagedIdentitySettings"u8);
                writer.WriteObjectValue(UserAssignedManagedIdentitySettings, options);
            }
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

        DataflowEndpointDataExplorerAuthentication IJsonModel<DataflowEndpointDataExplorerAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointDataExplorerAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointDataExplorerAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointDataExplorerAuthentication(document.RootElement, options);
        }

        internal static DataflowEndpointDataExplorerAuthentication DeserializeDataflowEndpointDataExplorerAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataExplorerAuthMethod method = default;
            DataflowEndpointAuthenticationSystemAssignedManagedIdentity systemAssignedManagedIdentitySettings = default;
            DataflowEndpointAuthenticationUserAssignedManagedIdentity userAssignedManagedIdentitySettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    method = new DataExplorerAuthMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemAssignedManagedIdentitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemAssignedManagedIdentitySettings = DataflowEndpointAuthenticationSystemAssignedManagedIdentity.DeserializeDataflowEndpointAuthenticationSystemAssignedManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentitySettings = DataflowEndpointAuthenticationUserAssignedManagedIdentity.DeserializeDataflowEndpointAuthenticationUserAssignedManagedIdentity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointDataExplorerAuthentication(method, systemAssignedManagedIdentitySettings, userAssignedManagedIdentitySettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointDataExplorerAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointDataExplorerAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointDataExplorerAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointDataExplorerAuthentication IPersistableModel<DataflowEndpointDataExplorerAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointDataExplorerAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataflowEndpointDataExplorerAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointDataExplorerAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointDataExplorerAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
