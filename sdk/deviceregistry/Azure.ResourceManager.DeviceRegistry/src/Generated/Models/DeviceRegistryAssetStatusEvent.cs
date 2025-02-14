// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the asset status event properties. </summary>
    public partial class DeviceRegistryAssetStatusEvent
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

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetStatusEvent"/>. </summary>
        /// <param name="name"> The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec and status event information. </param>
        internal DeviceRegistryAssetStatusEvent(string name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetStatusEvent"/>. </summary>
        /// <param name="name"> The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec and status event information. </param>
        /// <param name="messageSchemaReference"> The message schema reference object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceRegistryAssetStatusEvent(string name, MessageSchemaReference messageSchemaReference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MessageSchemaReference = messageSchemaReference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetStatusEvent"/> for deserialization. </summary>
        internal DeviceRegistryAssetStatusEvent()
        {
        }

        /// <summary> The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec and status event information. </summary>
        public string Name { get; }
        /// <summary> The message schema reference object. </summary>
        public MessageSchemaReference MessageSchemaReference { get; }
    }
}
