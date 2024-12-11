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
    public partial class DataflowEndpointMqtt : IUtf8JsonSerializable, IJsonModel<DataflowEndpointMqtt>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointMqtt>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointMqtt>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqtt>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointMqtt)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("authentication"u8);
            writer.WriteObjectValue(Authentication, options);
            if (Optional.IsDefined(ClientIdPrefix))
            {
                writer.WritePropertyName("clientIdPrefix"u8);
                writer.WriteStringValue(ClientIdPrefix);
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(KeepAliveSeconds))
            {
                writer.WritePropertyName("keepAliveSeconds"u8);
                writer.WriteNumberValue(KeepAliveSeconds.Value);
            }
            if (Optional.IsDefined(Retain))
            {
                writer.WritePropertyName("retain"u8);
                writer.WriteStringValue(Retain.Value.ToString());
            }
            if (Optional.IsDefined(MaxInflightMessages))
            {
                writer.WritePropertyName("maxInflightMessages"u8);
                writer.WriteNumberValue(MaxInflightMessages.Value);
            }
            if (Optional.IsDefined(Qos))
            {
                writer.WritePropertyName("qos"u8);
                writer.WriteNumberValue(Qos.Value);
            }
            if (Optional.IsDefined(SessionExpirySeconds))
            {
                writer.WritePropertyName("sessionExpirySeconds"u8);
                writer.WriteNumberValue(SessionExpirySeconds.Value);
            }
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                writer.WriteObjectValue(Tls, options);
            }
            if (Optional.IsDefined(CloudEventAttributes))
            {
                writer.WritePropertyName("cloudEventAttributes"u8);
                writer.WriteStringValue(CloudEventAttributes.Value.ToString());
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

        DataflowEndpointMqtt IJsonModel<DataflowEndpointMqtt>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqtt>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointMqtt)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointMqtt(document.RootElement, options);
        }

        internal static DataflowEndpointMqtt DeserializeDataflowEndpointMqtt(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataflowEndpointMqttAuthentication authentication = default;
            string clientIdPrefix = default;
            string host = default;
            BrokerProtocolType? protocol = default;
            int? keepAliveSeconds = default;
            MqttRetainType? retain = default;
            int? maxInflightMessages = default;
            int? qos = default;
            int? sessionExpirySeconds = default;
            TlsProperties tls = default;
            CloudEventAttributeType? cloudEventAttributes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authentication"u8))
                {
                    authentication = DataflowEndpointMqttAuthentication.DeserializeDataflowEndpointMqttAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clientIdPrefix"u8))
                {
                    clientIdPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new BrokerProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keepAliveSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keepAliveSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retain = new MqttRetainType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxInflightMessages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInflightMessages = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("qos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qos = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sessionExpirySeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionExpirySeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tls = TlsProperties.DeserializeTlsProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cloudEventAttributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudEventAttributes = new CloudEventAttributeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointMqtt(
                authentication,
                clientIdPrefix,
                host,
                protocol,
                keepAliveSeconds,
                retain,
                maxInflightMessages,
                qos,
                sessionExpirySeconds,
                tls,
                cloudEventAttributes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointMqtt>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqtt>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointMqtt)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointMqtt IPersistableModel<DataflowEndpointMqtt>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqtt>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataflowEndpointMqtt(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointMqtt)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointMqtt>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
