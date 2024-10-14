// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class MeshRevisionProfileProperties : IUtf8JsonSerializable, IJsonModel<MeshRevisionProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MeshRevisionProfileProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MeshRevisionProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MeshRevisionProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MeshRevisionProfileProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(MeshRevisions))
            {
                writer.WritePropertyName("meshRevisions"u8);
                writer.WriteStartArray();
                foreach (var item in MeshRevisions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        MeshRevisionProfileProperties IJsonModel<MeshRevisionProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MeshRevisionProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MeshRevisionProfileProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMeshRevisionProfileProperties(document.RootElement, options);
        }

        internal static MeshRevisionProfileProperties DeserializeMeshRevisionProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MeshRevision> meshRevisions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meshRevisions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MeshRevision> array = new List<MeshRevision>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MeshRevision.DeserializeMeshRevision(item, options));
                    }
                    meshRevisions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MeshRevisionProfileProperties(meshRevisions ?? new ChangeTrackingList<MeshRevision>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MeshRevisions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  meshRevisions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MeshRevisions))
                {
                    if (MeshRevisions.Any())
                    {
                        builder.Append("  meshRevisions: ");
                        builder.AppendLine("[");
                        foreach (var item in MeshRevisions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  meshRevisions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MeshRevisionProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MeshRevisionProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MeshRevisionProfileProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MeshRevisionProfileProperties IPersistableModel<MeshRevisionProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MeshRevisionProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMeshRevisionProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MeshRevisionProfileProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MeshRevisionProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
