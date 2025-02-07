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
    public partial class VolumeClaimSpecSelector : IUtf8JsonSerializable, IJsonModel<VolumeClaimSpecSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VolumeClaimSpecSelector>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VolumeClaimSpecSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeClaimSpecSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeClaimSpecSelector)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(MatchExpressions))
            {
                writer.WritePropertyName("matchExpressions"u8);
                writer.WriteStartArray();
                foreach (var item in MatchExpressions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MatchLabels))
            {
                writer.WritePropertyName("matchLabels"u8);
                writer.WriteStartObject();
                foreach (var item in MatchLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        VolumeClaimSpecSelector IJsonModel<VolumeClaimSpecSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeClaimSpecSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeClaimSpecSelector)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVolumeClaimSpecSelector(document.RootElement, options);
        }

        internal static VolumeClaimSpecSelector DeserializeVolumeClaimSpecSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<VolumeClaimSpecSelectorMatchExpressions> matchExpressions = default;
            IDictionary<string, string> matchLabels = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchExpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VolumeClaimSpecSelectorMatchExpressions> array = new List<VolumeClaimSpecSelectorMatchExpressions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VolumeClaimSpecSelectorMatchExpressions.DeserializeVolumeClaimSpecSelectorMatchExpressions(item, options));
                    }
                    matchExpressions = array;
                    continue;
                }
                if (property.NameEquals("matchLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    matchLabels = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VolumeClaimSpecSelector(matchExpressions ?? new ChangeTrackingList<VolumeClaimSpecSelectorMatchExpressions>(), matchLabels ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VolumeClaimSpecSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeClaimSpecSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VolumeClaimSpecSelector)} does not support writing '{options.Format}' format.");
            }
        }

        VolumeClaimSpecSelector IPersistableModel<VolumeClaimSpecSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeClaimSpecSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVolumeClaimSpecSelector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VolumeClaimSpecSelector)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VolumeClaimSpecSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
