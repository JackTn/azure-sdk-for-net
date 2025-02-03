// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Service Account Token for BrokerAuthentication. </summary>
    internal partial class DataflowEndpointAuthenticationServiceAccountToken
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

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointAuthenticationServiceAccountToken"/>. </summary>
        /// <param name="audience"> Audience of the service account. Optional, defaults to the broker internal service account audience. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audience"/> is null. </exception>
        public DataflowEndpointAuthenticationServiceAccountToken(string audience)
        {
            Argument.AssertNotNull(audience, nameof(audience));

            Audience = audience;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointAuthenticationServiceAccountToken"/>. </summary>
        /// <param name="audience"> Audience of the service account. Optional, defaults to the broker internal service account audience. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowEndpointAuthenticationServiceAccountToken(string audience, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Audience = audience;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointAuthenticationServiceAccountToken"/> for deserialization. </summary>
        internal DataflowEndpointAuthenticationServiceAccountToken()
        {
        }

        /// <summary> Audience of the service account. Optional, defaults to the broker internal service account audience. </summary>
        public string Audience { get; set; }
    }
}
