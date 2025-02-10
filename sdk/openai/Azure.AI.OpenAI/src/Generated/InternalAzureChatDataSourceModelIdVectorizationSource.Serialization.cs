// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat
{
    internal partial class InternalAzureChatDataSourceModelIdVectorizationSource : IJsonModel<InternalAzureChatDataSourceModelIdVectorizationSource>
    {
        void IJsonModel<InternalAzureChatDataSourceModelIdVectorizationSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureChatDataSourceModelIdVectorizationSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (SerializedAdditionalRawData?.ContainsKey("model_id") != true)
            {
                writer.WritePropertyName("model_id"u8);
                writer.WriteStringValue(ModelId);
            }
        }

        InternalAzureChatDataSourceModelIdVectorizationSource IJsonModel<InternalAzureChatDataSourceModelIdVectorizationSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureChatDataSourceModelIdVectorizationSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(document.RootElement, options);
        }

        internal static InternalAzureChatDataSourceModelIdVectorizationSource DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model_id"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalAzureChatDataSourceModelIdVectorizationSource(type, serializedAdditionalRawData, modelId);
        }

        BinaryData IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAzureChatDataSourceModelIdVectorizationSource)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAzureChatDataSourceModelIdVectorizationSource IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAzureChatDataSourceModelIdVectorizationSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAzureChatDataSourceModelIdVectorizationSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new InternalAzureChatDataSourceModelIdVectorizationSource FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
