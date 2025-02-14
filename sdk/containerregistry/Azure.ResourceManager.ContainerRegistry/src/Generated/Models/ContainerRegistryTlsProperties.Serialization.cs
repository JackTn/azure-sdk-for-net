// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class DeploymentCapacitySettings : IUtf8JsonSerializable, IJsonModel<DeploymentCapacitySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentCapacitySettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentCapacitySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
========
namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTlsProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTlsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTlsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryTlsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentCapacitySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentCapacitySettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DesignatedCapacity))
            {
                writer.WritePropertyName("designatedCapacity"u8);
                writer.WriteNumberValue(DesignatedCapacity.Value);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
========
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTlsProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate, options);
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
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

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
        DeploymentCapacitySettings IJsonModel<DeploymentCapacitySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentCapacitySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentCapacitySettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentCapacitySettings(document.RootElement, options);
        }

        internal static DeploymentCapacitySettings DeserializeDeploymentCapacitySettings(JsonElement element, ModelReaderWriterOptions options = null)
========
        ContainerRegistryTlsProperties IJsonModel<ContainerRegistryTlsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTlsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTlsProperties(document.RootElement, options);
        }

        internal static ContainerRegistryTlsProperties DeserializeContainerRegistryTlsProperties(JsonElement element, ModelReaderWriterOptions options = null)
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
            int? designatedCapacity = default;
            int? priority = default;
========
            ContainerRegistryTlsStatus? status = default;
            ContainerRegistryTlsCertificateProperties certificate = default;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                if (property.NameEquals("designatedCapacity"u8))
========
                if (property.NameEquals("status"u8))
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                    designatedCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("priority"u8))
========
                    status = new ContainerRegistryTlsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificate"u8))
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                    priority = property.Value.GetInt32();
========
                    certificate = ContainerRegistryTlsCertificateProperties.DeserializeContainerRegistryTlsCertificateProperties(property.Value, options);
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
            return new DeploymentCapacitySettings(designatedCapacity, priority, serializedAdditionalRawData);
========
            return new ContainerRegistryTlsProperties(status, certificate, serializedAdditionalRawData);
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
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

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DesignatedCapacity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  designatedCapacity: ");
========
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                builder.AppendLine(propertyOverride);
            }
            else
            {
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                if (Optional.IsDefined(DesignatedCapacity))
                {
                    builder.Append("  designatedCapacity: ");
                    builder.AppendLine($"{DesignatedCapacity.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Priority), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  priority: ");
========
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Certificate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificate: ");
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                builder.AppendLine(propertyOverride);
            }
            else
            {
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                if (Optional.IsDefined(Priority))
                {
                    builder.Append("  priority: ");
                    builder.AppendLine($"{Priority.Value}");
========
                if (Optional.IsDefined(Certificate))
                {
                    builder.Append("  certificate: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Certificate, options, 2, false, "  certificate: ");
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
        BinaryData IPersistableModel<DeploymentCapacitySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentCapacitySettings>)this).GetFormatFromOptions(options) : options.Format;
========
        BinaryData IPersistableModel<ContainerRegistryTlsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                    throw new FormatException($"The model {nameof(DeploymentCapacitySettings)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentCapacitySettings IPersistableModel<DeploymentCapacitySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentCapacitySettings>)this).GetFormatFromOptions(options) : options.Format;
========
                    throw new FormatException($"The model {nameof(ContainerRegistryTlsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryTlsProperties IPersistableModel<ContainerRegistryTlsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTlsProperties>)this).GetFormatFromOptions(options) : options.Format;
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
<<<<<<<< HEAD:sdk/cognitiveservices/Azure.ResourceManager.CognitiveServices/src/Generated/Models/DeploymentCapacitySettings.Serialization.cs
                        return DeserializeDeploymentCapacitySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentCapacitySettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentCapacitySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
========
                        return DeserializeContainerRegistryTlsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTlsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTlsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
>>>>>>>> main:sdk/containerregistry/Azure.ResourceManager.ContainerRegistry/src/Generated/Models/ContainerRegistryTlsProperties.Serialization.cs
    }
}
