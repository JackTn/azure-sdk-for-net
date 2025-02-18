// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistry data model.
    /// An object that represents a container registry.
    /// </summary>
    public partial class ContainerRegistryData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the container registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ContainerRegistryData(AzureLocation location, ContainerRegistrySku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            DataEndpointHostNames = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<ContainerRegistryPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the container registry. </param>
        /// <param name="identity"> The identity of the container registry. </param>
        /// <param name="loginServer"> The URL that can be used to log into the container registry. </param>
        /// <param name="createdOn"> The creation date of the container registry in ISO8601 format. </param>
        /// <param name="provisioningState"> The provisioning state of the container registry at the time the operation was called. </param>
        /// <param name="status"> The status of the container registry at the time the operation was called. </param>
        /// <param name="isAdminUserEnabled"> The value that indicates whether the admin user is enabled. </param>
        /// <param name="networkRuleSet"> The network rule set for a container registry. </param>
        /// <param name="policies"> The policies for a container registry. </param>
        /// <param name="encryption"> The encryption settings of container registry. </param>
        /// <param name="isDataEndpointEnabled"> Enable a single data endpoint per region for serving data. </param>
        /// <param name="dataEndpointHostNames"> List of host names that will serve data when dataEndpointEnabled is true. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections for a container registry. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for the container registry. </param>
        /// <param name="networkRuleBypassOptions"> Whether to allow trusted Azure services to access a network restricted registry. </param>
        /// <param name="zoneRedundancy"> Whether or not zone redundancy is enabled for this container registry. </param>
        /// <param name="isAnonymousPullEnabled"> Enables registry-wide pull from unauthenticated clients. </param>
        /// <param name="metadataSearch"> Determines whether registry artifacts are indexed for metadata search. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> Determines the domain name label reuse scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContainerRegistrySku sku, ManagedServiceIdentity identity, string loginServer, DateTimeOffset? createdOn, ContainerRegistryProvisioningState? provisioningState, ContainerRegistryResourceStatus status, bool? isAdminUserEnabled, ContainerRegistryNetworkRuleSet networkRuleSet, ContainerRegistryPolicies policies, ContainerRegistryEncryption encryption, bool? isDataEndpointEnabled, IReadOnlyList<string> dataEndpointHostNames, IReadOnlyList<ContainerRegistryPrivateEndpointConnectionData> privateEndpointConnections, ContainerRegistryPublicNetworkAccess? publicNetworkAccess, ContainerRegistryNetworkRuleBypassOption? networkRuleBypassOptions, ContainerRegistryZoneRedundancy? zoneRedundancy, bool? isAnonymousPullEnabled, ContainerRegistryMetadataSearch? metadataSearch, AutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            LoginServer = loginServer;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            Status = status;
            IsAdminUserEnabled = isAdminUserEnabled;
            NetworkRuleSet = networkRuleSet;
            Policies = policies;
            Encryption = encryption;
            IsDataEndpointEnabled = isDataEndpointEnabled;
            DataEndpointHostNames = dataEndpointHostNames;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkRuleBypassOptions = networkRuleBypassOptions;
            ZoneRedundancy = zoneRedundancy;
            IsAnonymousPullEnabled = isAnonymousPullEnabled;
            MetadataSearch = metadataSearch;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryData"/> for deserialization. </summary>
        internal ContainerRegistryData()
        {
        }

        /// <summary> The SKU of the container registry. </summary>
        [WirePath("sku")]
        public ContainerRegistrySku Sku { get; set; }
        /// <summary> The identity of the container registry. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The URL that can be used to log into the container registry. </summary>
        [WirePath("properties.loginServer")]
        public string LoginServer { get; }
        /// <summary> The creation date of the container registry in ISO8601 format. </summary>
        [WirePath("properties.creationDate")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The provisioning state of the container registry at the time the operation was called. </summary>
        [WirePath("properties.provisioningState")]
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
        /// <summary> The status of the container registry at the time the operation was called. </summary>
        [WirePath("properties.status")]
        public ContainerRegistryResourceStatus Status { get; }
        /// <summary> The value that indicates whether the admin user is enabled. </summary>
        [WirePath("properties.adminUserEnabled")]
        public bool? IsAdminUserEnabled { get; set; }
        /// <summary> The network rule set for a container registry. </summary>
        [WirePath("properties.networkRuleSet")]
        public ContainerRegistryNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> The policies for a container registry. </summary>
        [WirePath("properties.policies")]
        public ContainerRegistryPolicies Policies { get; set; }
        /// <summary> The encryption settings of container registry. </summary>
        [WirePath("properties.encryption")]
        public ContainerRegistryEncryption Encryption { get; set; }
        /// <summary> Enable a single data endpoint per region for serving data. </summary>
        [WirePath("properties.dataEndpointEnabled")]
        public bool? IsDataEndpointEnabled { get; set; }
        /// <summary> List of host names that will serve data when dataEndpointEnabled is true. </summary>
        [WirePath("properties.dataEndpointHostNames")]
        public IReadOnlyList<string> DataEndpointHostNames { get; }
        /// <summary> List of private endpoint connections for a container registry. </summary>
        [WirePath("properties.privateEndpointConnections")]
        public IReadOnlyList<ContainerRegistryPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Whether or not public network access is allowed for the container registry. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public ContainerRegistryPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Whether to allow trusted Azure services to access a network restricted registry. </summary>
        [WirePath("properties.networkRuleBypassOptions")]
        public ContainerRegistryNetworkRuleBypassOption? NetworkRuleBypassOptions { get; set; }
        /// <summary> Whether or not zone redundancy is enabled for this container registry. </summary>
        [WirePath("properties.zoneRedundancy")]
        public ContainerRegistryZoneRedundancy? ZoneRedundancy { get; set; }
        /// <summary> Enables registry-wide pull from unauthenticated clients. </summary>
        [WirePath("properties.anonymousPullEnabled")]
        public bool? IsAnonymousPullEnabled { get; set; }
        /// <summary> Determines whether registry artifacts are indexed for metadata search. </summary>
        [WirePath("properties.metadataSearch")]
        public ContainerRegistryMetadataSearch? MetadataSearch { get; set; }
        /// <summary> Determines the domain name label reuse scope. </summary>
        [WirePath("properties.autoGeneratedDomainNameLabelScope")]
        public AutoGeneratedDomainNameLabelScope? AutoGeneratedDomainNameLabelScope { get; set; }
    }
}
