// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> A Fleetspace properties. </summary>
    public partial class FleetspaceProperties
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

        /// <summary> Initializes a new instance of <see cref="FleetspaceProperties"/>. </summary>
        public FleetspaceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FleetspaceProperties"/>. </summary>
        /// <param name="provisioningState"> Fleetspace state. </param>
        /// <param name="capacityMax"> Maximum number of vCores database fleet manager is allowed to provision in the fleetspace. </param>
        /// <param name="mainPrincipal"> Main Microsoft Entra ID principal that has admin access to all databases in the fleetspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FleetspaceProperties(AzureProvisioningState? provisioningState, int? capacityMax, MainPrincipal mainPrincipal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            CapacityMax = capacityMax;
            MainPrincipal = mainPrincipal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fleetspace state. </summary>
        public AzureProvisioningState? ProvisioningState { get; }
        /// <summary> Maximum number of vCores database fleet manager is allowed to provision in the fleetspace. </summary>
        public int? CapacityMax { get; set; }
        /// <summary> Main Microsoft Entra ID principal that has admin access to all databases in the fleetspace. </summary>
        public MainPrincipal MainPrincipal { get; set; }
    }
}
