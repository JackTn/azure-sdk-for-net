// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> DataflowEndpoint Resource properties. NOTE - Only one type of endpoint is supported for one Resource. </summary>
    public partial class IotOperationsDataflowEndpointProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotOperationsDataflowEndpointProperties"/>. </summary>
        /// <param name="endpointType"> Endpoint Type. </param>
        public IotOperationsDataflowEndpointProperties(DataflowEndpointType endpointType)
        {
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="IotOperationsDataflowEndpointProperties"/>. </summary>
        /// <param name="endpointType"> Endpoint Type. </param>
        /// <param name="dataExplorerSettings"> Azure Data Explorer endpoint. </param>
        /// <param name="dataLakeStorageSettings"> Azure Data Lake endpoint. </param>
        /// <param name="fabricOneLakeSettings"> Microsoft Fabric endpoint. </param>
        /// <param name="kafkaSettings"> Kafka endpoint. </param>
        /// <param name="localStorageSettings"> Local persistent volume endpoint. </param>
        /// <param name="mqttSettings"> Broker endpoint. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotOperationsDataflowEndpointProperties(DataflowEndpointType endpointType, DataflowEndpointDataExplorer dataExplorerSettings, DataflowEndpointDataLakeStorage dataLakeStorageSettings, DataflowEndpointFabricOneLake fabricOneLakeSettings, DataflowEndpointKafka kafkaSettings, DataflowEndpointLocalStorage localStorageSettings, DataflowEndpointMqtt mqttSettings, IotOperationsProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndpointType = endpointType;
            DataExplorerSettings = dataExplorerSettings;
            DataLakeStorageSettings = dataLakeStorageSettings;
            FabricOneLakeSettings = fabricOneLakeSettings;
            KafkaSettings = kafkaSettings;
            LocalStorageSettings = localStorageSettings;
            MqttSettings = mqttSettings;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotOperationsDataflowEndpointProperties"/> for deserialization. </summary>
        internal IotOperationsDataflowEndpointProperties()
        {
        }

        /// <summary> Endpoint Type. </summary>
        public DataflowEndpointType EndpointType { get; set; }
        /// <summary> Azure Data Explorer endpoint. </summary>
        public DataflowEndpointDataExplorer DataExplorerSettings { get; set; }
        /// <summary> Azure Data Lake endpoint. </summary>
        public DataflowEndpointDataLakeStorage DataLakeStorageSettings { get; set; }
        /// <summary> Microsoft Fabric endpoint. </summary>
        public DataflowEndpointFabricOneLake FabricOneLakeSettings { get; set; }
        /// <summary> Kafka endpoint. </summary>
        public DataflowEndpointKafka KafkaSettings { get; set; }
        /// <summary> Local persistent volume endpoint. </summary>
        internal DataflowEndpointLocalStorage LocalStorageSettings { get; set; }
        /// <summary> Persistent volume claim name. </summary>
        public string LocalStoragePersistentVolumeClaimRef
        {
            get => LocalStorageSettings is null ? default : LocalStorageSettings.PersistentVolumeClaimRef;
            set => LocalStorageSettings = new DataflowEndpointLocalStorage(value);
        }

        /// <summary> Broker endpoint. </summary>
        public DataflowEndpointMqtt MqttSettings { get; set; }
        /// <summary> The status of the last operation. </summary>
        public IotOperationsProvisioningState? ProvisioningState { get; }
    }
}
