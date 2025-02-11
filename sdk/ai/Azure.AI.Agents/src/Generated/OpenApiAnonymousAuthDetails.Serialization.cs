// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents
{
    public partial class OpenApiAnonymousAuthDetails : IUtf8JsonSerializable, IJsonModel<OpenApiAnonymousAuthDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenApiAnonymousAuthDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenApiAnonymousAuthDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAnonymousAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiAnonymousAuthDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        OpenApiAnonymousAuthDetails IJsonModel<OpenApiAnonymousAuthDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAnonymousAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiAnonymousAuthDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenApiAnonymousAuthDetails(document.RootElement, options);
        }

        internal static OpenApiAnonymousAuthDetails DeserializeOpenApiAnonymousAuthDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenApiAuthType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new OpenApiAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenApiAnonymousAuthDetails(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenApiAnonymousAuthDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAnonymousAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OpenApiAnonymousAuthDetails)} does not support writing '{options.Format}' format.");
            }
        }

        OpenApiAnonymousAuthDetails IPersistableModel<OpenApiAnonymousAuthDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiAnonymousAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenApiAnonymousAuthDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenApiAnonymousAuthDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenApiAnonymousAuthDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new OpenApiAnonymousAuthDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOpenApiAnonymousAuthDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
