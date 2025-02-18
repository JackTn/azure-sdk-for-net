// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class GalleryInVmAccessControlProfileVersionData : IUtf8JsonSerializable, IJsonModel<GalleryInVmAccessControlProfileVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryInVmAccessControlProfileVersionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GalleryInVmAccessControlProfileVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryInVmAccessControlProfileVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryInVmAccessControlProfileVersionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TargetLocations))
            {
                writer.WritePropertyName("targetLocations"u8);
                writer.WriteStartArray();
                foreach (var item in TargetLocations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExcludeFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest"u8);
                writer.WriteBooleanValue(ExcludeFromLatest.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationStatus))
            {
                writer.WritePropertyName("replicationStatus"u8);
                writer.WriteObjectValue(ReplicationStatus, options);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(DefaultAccess))
            {
                writer.WritePropertyName("defaultAccess"u8);
                writer.WriteStringValue(DefaultAccess.Value.ToString());
            }
            if (Optional.IsDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteObjectValue(Rules, options);
            }
            writer.WriteEndObject();
        }

        GalleryInVmAccessControlProfileVersionData IJsonModel<GalleryInVmAccessControlProfileVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryInVmAccessControlProfileVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryInVmAccessControlProfileVersionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryInVmAccessControlProfileVersionData(document.RootElement, options);
        }

        internal static GalleryInVmAccessControlProfileVersionData DeserializeGalleryInVmAccessControlProfileVersionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IList<TargetRegion> targetLocations = default;
            bool? excludeFromLatest = default;
            DateTimeOffset? publishedDate = default;
            GalleryProvisioningState? provisioningState = default;
            ReplicationStatus replicationStatus = default;
            GalleryInVmAccessControlRulesMode? mode = default;
            ComputeGalleryEndpointAccess? defaultAccess = default;
            GalleryInVmAccessControlRules rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TargetRegion> array = new List<TargetRegion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TargetRegion.DeserializeTargetRegion(item, options));
                            }
                            targetLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("excludeFromLatest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            excludeFromLatest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publishedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new GalleryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationStatus = ReplicationStatus.DeserializeReplicationStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mode = new GalleryInVmAccessControlRulesMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAccess = new ComputeGalleryEndpointAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rules = GalleryInVmAccessControlRules.DeserializeGalleryInVmAccessControlRules(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GalleryInVmAccessControlProfileVersionData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                targetLocations ?? new ChangeTrackingList<TargetRegion>(),
                excludeFromLatest,
                publishedDate,
                provisioningState,
                replicationStatus,
                mode,
                defaultAccess,
                rules,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryInVmAccessControlProfileVersionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryInVmAccessControlProfileVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryInVmAccessControlProfileVersionData)} does not support writing '{options.Format}' format.");
            }
        }

        GalleryInVmAccessControlProfileVersionData IPersistableModel<GalleryInVmAccessControlProfileVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryInVmAccessControlProfileVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryInVmAccessControlProfileVersionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryInVmAccessControlProfileVersionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryInVmAccessControlProfileVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
