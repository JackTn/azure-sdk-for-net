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

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class RaiBlockListResult : IUtf8JsonSerializable, IJsonModel<RaiBlockListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RaiBlockListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RaiBlockListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
========
namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal partial class ArchiveListResult : IUtf8JsonSerializable, IJsonModel<ArchiveListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArchiveListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArchiveListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
            var format = options.Format == "W" ? ((IPersistableModel<RaiBlockListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiBlockListResult)} does not support writing '{format}' format.");
========
            var format = options.Format == "W" ? ((IPersistableModel<ArchiveListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArchiveListResult)} does not support writing '{format}' format.");
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
            }

            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
========
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
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

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
        RaiBlockListResult IJsonModel<RaiBlockListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiBlockListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiBlockListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRaiBlockListResult(document.RootElement, options);
        }

        internal static RaiBlockListResult DeserializeRaiBlockListResult(JsonElement element, ModelReaderWriterOptions options = null)
========
        ArchiveListResult IJsonModel<ArchiveListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArchiveListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArchiveListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArchiveListResult(document.RootElement, options);
        }

        internal static ArchiveListResult DeserializeArchiveListResult(JsonElement element, ModelReaderWriterOptions options = null)
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
========
            IReadOnlyList<ContainerRegistryArchiveData> value = default;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
            string nextLink = default;
            IReadOnlyList<RaiBlocklistData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
                    List<RaiBlocklistData> array = new List<RaiBlocklistData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RaiBlocklistData.DeserializeRaiBlocklistData(item, options));
========
                    List<ContainerRegistryArchiveData> array = new List<ContainerRegistryArchiveData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryArchiveData.DeserializeContainerRegistryArchiveData(item, options));
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
            return new RaiBlockListResult(nextLink, value ?? new ChangeTrackingList<RaiBlocklistData>(), serializedAdditionalRawData);
========
            return new ArchiveListResult(value ?? new ChangeTrackingList<ContainerRegistryArchiveData>(), nextLink, serializedAdditionalRawData);
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NextLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nextLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NextLink))
                {
                    builder.Append("  nextLink: ");
                    if (NextLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NextLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NextLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Value))
                {
                    if (Value.Any())
                    {
                        builder.Append("  value: ");
                        builder.AppendLine("[");
                        foreach (var item in Value)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  value: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
        BinaryData IPersistableModel<RaiBlockListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiBlockListResult>)this).GetFormatFromOptions(options) : options.Format;
========
        BinaryData IPersistableModel<ArchiveListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArchiveListResult>)this).GetFormatFromOptions(options) : options.Format;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
                    throw new FormatException($"The model {nameof(RaiBlockListResult)} does not support writing '{options.Format}' format.");
            }
        }

        RaiBlockListResult IPersistableModel<RaiBlockListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiBlockListResult>)this).GetFormatFromOptions(options) : options.Format;
========
                    throw new FormatException($"The model {nameof(ArchiveListResult)} does not support writing '{options.Format}' format.");
            }
        }

        ArchiveListResult IPersistableModel<ArchiveListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArchiveListResult>)this).GetFormatFromOptions(options) : options.Format;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/RaiBlockListResult.Serialization.cs
                        return DeserializeRaiBlockListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RaiBlockListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RaiBlockListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
========
                        return DeserializeArchiveListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArchiveListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArchiveListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ArchiveListResult.Serialization.cs
    }
}
