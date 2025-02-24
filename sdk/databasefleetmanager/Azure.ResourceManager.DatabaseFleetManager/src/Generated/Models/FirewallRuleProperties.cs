// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> A Firewall rule properties. </summary>
    public partial class FirewallRuleProperties
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

        /// <summary> Initializes a new instance of <see cref="FirewallRuleProperties"/>. </summary>
        public FirewallRuleProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallRuleProperties"/>. </summary>
        /// <param name="startIPAddress"> Start IP address. </param>
        /// <param name="endIPAddress"> End IP address. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallRuleProperties(string startIPAddress, string endIPAddress, AzureProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Start IP address. </summary>
        public string StartIPAddress { get; set; }
        /// <summary> End IP address. </summary>
        public string EndIPAddress { get; set; }
        /// <summary> Provisioning state. </summary>
        public AzureProvisioningState? ProvisioningState { get; }
    }
}
