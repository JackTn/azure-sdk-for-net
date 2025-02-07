// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring.Models
{
    public partial class DeploymentJobState : IUtf8JsonSerializable, IJsonModel<DeploymentJobState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentJobState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentJobState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentJobState)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedDateTime, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedDateTime, "O");
            if (Optional.IsDefined(ExpirationDateTime))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpirationDateTime.Value, "O");
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
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

        DeploymentJobState IJsonModel<DeploymentJobState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentJobState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentJobState(document.RootElement, options);
        }

        internal static DeploymentJobState DeserializeDeploymentJobState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobId = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DateTimeOffset? expirationDateTime = default;
            JobStatus status = default;
            IReadOnlyList<TextAnalysisAuthoringWarning> warnings = default;
            IReadOnlyList<TextAnalysisAuthoringError> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalysisAuthoringWarning> array = new List<TextAnalysisAuthoringWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalysisAuthoringWarning.DeserializeTextAnalysisAuthoringWarning(item, options));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalysisAuthoringError> array = new List<TextAnalysisAuthoringError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalysisAuthoringError.DeserializeTextAnalysisAuthoringError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentJobState(
                jobId,
                createdDateTime,
                lastUpdatedDateTime,
                expirationDateTime,
                status,
                warnings ?? new ChangeTrackingList<TextAnalysisAuthoringWarning>(),
                errors ?? new ChangeTrackingList<TextAnalysisAuthoringError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeploymentJobState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentJobState)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentJobState IPersistableModel<DeploymentJobState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentJobState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentJobState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentJobState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeploymentJobState FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeploymentJobState(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
