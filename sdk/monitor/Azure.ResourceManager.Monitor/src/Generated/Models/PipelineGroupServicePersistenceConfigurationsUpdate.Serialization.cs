// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class PipelineGroupServicePersistenceConfigurationsUpdate : IUtf8JsonSerializable, IJsonModel<PipelineGroupServicePersistenceConfigurationsUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineGroupServicePersistenceConfigurationsUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PipelineGroupServicePersistenceConfigurationsUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurationsUpdate)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PersistentVolumeName))
            {
                writer.WritePropertyName("persistentVolumeName"u8);
                writer.WriteStringValue(PersistentVolumeName);
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

        PipelineGroupServicePersistenceConfigurationsUpdate IJsonModel<PipelineGroupServicePersistenceConfigurationsUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurationsUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineGroupServicePersistenceConfigurationsUpdate(document.RootElement, options);
        }

        internal static PipelineGroupServicePersistenceConfigurationsUpdate DeserializePipelineGroupServicePersistenceConfigurationsUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string persistentVolumeName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("persistentVolumeName"u8))
                {
                    persistentVolumeName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PipelineGroupServicePersistenceConfigurationsUpdate(persistentVolumeName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurationsUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineGroupServicePersistenceConfigurationsUpdate IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePipelineGroupServicePersistenceConfigurationsUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupServicePersistenceConfigurationsUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineGroupServicePersistenceConfigurationsUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
