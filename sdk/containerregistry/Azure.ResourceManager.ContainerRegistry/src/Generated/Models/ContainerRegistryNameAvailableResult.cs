// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to check the availability of a container registry name. </summary>
    public partial class ContainerRegistryNameAvailableResult
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNameAvailableResult"/>. </summary>
        internal ContainerRegistryNameAvailableResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNameAvailableResult"/>. </summary>
        /// <param name="availableLoginServerName"> The complete login server name with domain name label (DNL) hash, if available. </param>
        /// <param name="isNameAvailable"> The value that indicates whether the name is available. </param>
        /// <param name="reason"> If any, the reason that the name is not available. </param>
        /// <param name="message"> If any, the error message that provides more detail for the reason that the name is not available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryNameAvailableResult(string availableLoginServerName, bool? isNameAvailable, string reason, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AvailableLoginServerName = availableLoginServerName;
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The complete login server name with domain name label (DNL) hash, if available. </summary>
        [WirePath("availableLoginServerName")]
        public string AvailableLoginServerName { get; }
        /// <summary> The value that indicates whether the name is available. </summary>
        [WirePath("nameAvailable")]
        public bool? IsNameAvailable { get; }
        /// <summary> If any, the reason that the name is not available. </summary>
        [WirePath("reason")]
        public string Reason { get; }
        /// <summary> If any, the error message that provides more detail for the reason that the name is not available. </summary>
        [WirePath("message")]
        public string Message { get; }
    }
}
