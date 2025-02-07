// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of IpamPool resource properties which are specific to the Pool resource. </summary>
    public partial class IpamPoolProperties
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

        /// <summary> Initializes a new instance of <see cref="IpamPoolProperties"/>. </summary>
        /// <param name="addressPrefixes"> List of IP address prefixes of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressPrefixes"/> is null. </exception>
        public IpamPoolProperties(IEnumerable<string> addressPrefixes)
        {
            Argument.AssertNotNull(addressPrefixes, nameof(addressPrefixes));

            IPAddressType = new ChangeTrackingList<IpamIPType>();
            AddressPrefixes = addressPrefixes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IpamPoolProperties"/>. </summary>
        /// <param name="description"></param>
        /// <param name="displayName"> String representing a friendly name for the resource. </param>
        /// <param name="ipAddressType"> List of IP address type for the IpamPool. </param>
        /// <param name="parentPoolName"> String representing parent IpamPool resource name. If empty the IpamPool will be a root pool. </param>
        /// <param name="addressPrefixes"> List of IP address prefixes of the resource. </param>
        /// <param name="provisioningState"> Provisioning states of a resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IpamPoolProperties(string description, string displayName, IReadOnlyList<IpamIPType> ipAddressType, string parentPoolName, IList<string> addressPrefixes, NetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            DisplayName = displayName;
            IPAddressType = ipAddressType;
            ParentPoolName = parentPoolName;
            AddressPrefixes = addressPrefixes;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IpamPoolProperties"/> for deserialization. </summary>
        internal IpamPoolProperties()
        {
        }

        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> String representing a friendly name for the resource. </summary>
        public string DisplayName { get; set; }
        /// <summary> List of IP address type for the IpamPool. </summary>
        public IReadOnlyList<IpamIPType> IPAddressType { get; }
        /// <summary> String representing parent IpamPool resource name. If empty the IpamPool will be a root pool. </summary>
        public string ParentPoolName { get; set; }
        /// <summary> List of IP address prefixes of the resource. </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> Provisioning states of a resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; set; }
    }
}
