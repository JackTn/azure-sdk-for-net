// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an update to a Kusto cluster. </summary>
    public partial class KustoClusterPatch : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="KustoClusterPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public KustoClusterPatch(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            TrustedExternalTenants = new ChangeTrackingList<KustoClusterTrustedExternalTenant>();
            AllowedIPRangeList = new ChangeTrackingList<string>();
            AcceptedAudiences = new ChangeTrackingList<AcceptedAudience>();
            AllowedFqdnList = new ChangeTrackingList<string>();
            CalloutPolicies = new ChangeTrackingList<KustoCalloutPolicy>();
            PrivateEndpointConnections = new ChangeTrackingList<KustoPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the cluster. </param>
        /// <param name="zones"> The availability zones of the cluster. </param>
        /// <param name="identity"> The identity of the cluster, if configured. </param>
        /// <param name="state"> The state of the resource. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="uri"> The cluster URI. </param>
        /// <param name="dataIngestionUri"> The cluster data ingestion URI. </param>
        /// <param name="stateReason"> The reason for the cluster's current state. </param>
        /// <param name="trustedExternalTenants"> The cluster's external tenants. </param>
        /// <param name="optimizedAutoscale"> Optimized auto scale definition. </param>
        /// <param name="isDiskEncryptionEnabled"> A boolean value that indicates if the cluster's disks are encrypted. </param>
        /// <param name="isStreamingIngestEnabled"> A boolean value that indicates if the streaming ingest is enabled. </param>
        /// <param name="virtualNetworkConfiguration"> Virtual network definition. </param>
        /// <param name="keyVaultProperties"> KeyVault properties for the cluster encryption. </param>
        /// <param name="isPurgeEnabled"> A boolean value that indicates if the purge operations are enabled. </param>
        /// <param name="languageExtensions"> List of the cluster's language extensions. </param>
        /// <param name="isDoubleEncryptionEnabled"> A boolean value that indicates if double encryption is enabled. </param>
        /// <param name="publicNetworkAccess"> Public network access to the cluster is enabled by default. When disabled, only private endpoint connection to the cluster is allowed. </param>
        /// <param name="allowedIPRangeList"> The list of ips in the format of CIDR allowed to connect to the cluster. </param>
        /// <param name="engineType"> The engine type. </param>
        /// <param name="acceptedAudiences"> The cluster's accepted audiences. </param>
        /// <param name="isAutoStopEnabled"> A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no activity for many days). </param>
        /// <param name="restrictOutboundNetworkAccess"> Whether or not to restrict outbound network access.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="allowedFqdnList"> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster. </param>
        /// <param name="calloutPolicies"> List of callout policies for egress from Cluster. </param>
        /// <param name="publicIPType"> Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). </param>
        /// <param name="virtualClusterGraduationProperties"> Virtual Cluster graduation properties. </param>
        /// <param name="privateEndpointConnections"> A list of private endpoint connections. </param>
        /// <param name="migrationCluster"> Properties of the peer cluster involved in a migration to/from this cluster. </param>
        /// <param name="zoneStatus"> Indicates whether the cluster is zonal or non-zonal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoClusterPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, KustoSku sku, IList<string> zones, ManagedServiceIdentity identity, KustoClusterState? state, KustoProvisioningState? provisioningState, Uri uri, Uri dataIngestionUri, string stateReason, IList<KustoClusterTrustedExternalTenant> trustedExternalTenants, OptimizedAutoscale optimizedAutoscale, bool? isDiskEncryptionEnabled, bool? isStreamingIngestEnabled, KustoClusterVirtualNetworkConfiguration virtualNetworkConfiguration, KustoKeyVaultProperties keyVaultProperties, bool? isPurgeEnabled, KustoLanguageExtensionList languageExtensions, bool? isDoubleEncryptionEnabled, KustoClusterPublicNetworkAccess? publicNetworkAccess, IList<string> allowedIPRangeList, KustoClusterEngineType? engineType, IList<AcceptedAudience> acceptedAudiences, bool? isAutoStopEnabled, KustoClusterNetworkAccessFlag? restrictOutboundNetworkAccess, IList<string> allowedFqdnList, IList<KustoCalloutPolicy> calloutPolicies, KustoClusterPublicIPType? publicIPType, string virtualClusterGraduationProperties, IReadOnlyList<KustoPrivateEndpointConnectionData> privateEndpointConnections, MigrationClusterProperties migrationCluster, KustoClusterZoneStatus? zoneStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Zones = zones;
            Identity = identity;
            State = state;
            ProvisioningState = provisioningState;
            Uri = uri;
            DataIngestionUri = dataIngestionUri;
            StateReason = stateReason;
            TrustedExternalTenants = trustedExternalTenants;
            OptimizedAutoscale = optimizedAutoscale;
            IsDiskEncryptionEnabled = isDiskEncryptionEnabled;
            IsStreamingIngestEnabled = isStreamingIngestEnabled;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            KeyVaultProperties = keyVaultProperties;
            IsPurgeEnabled = isPurgeEnabled;
            LanguageExtensions = languageExtensions;
            IsDoubleEncryptionEnabled = isDoubleEncryptionEnabled;
            PublicNetworkAccess = publicNetworkAccess;
            AllowedIPRangeList = allowedIPRangeList;
            EngineType = engineType;
            AcceptedAudiences = acceptedAudiences;
            IsAutoStopEnabled = isAutoStopEnabled;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdnList = allowedFqdnList;
            CalloutPolicies = calloutPolicies;
            PublicIPType = publicIPType;
            VirtualClusterGraduationProperties = virtualClusterGraduationProperties;
            PrivateEndpointConnections = privateEndpointConnections;
            MigrationCluster = migrationCluster;
            ZoneStatus = zoneStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterPatch"/> for deserialization. </summary>
        internal KustoClusterPatch()
        {
        }

        /// <summary> The SKU of the cluster. </summary>
        public KustoSku Sku { get; set; }
        /// <summary> The availability zones of the cluster. </summary>
        public IList<string> Zones { get; }
        /// <summary> The identity of the cluster, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The state of the resource. </summary>
        public KustoClusterState? State { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
        /// <summary> The cluster URI. </summary>
        public Uri Uri { get; }
        /// <summary> The cluster data ingestion URI. </summary>
        public Uri DataIngestionUri { get; }
        /// <summary> The reason for the cluster's current state. </summary>
        public string StateReason { get; }
        /// <summary> The cluster's external tenants. </summary>
        public IList<KustoClusterTrustedExternalTenant> TrustedExternalTenants { get; }
        /// <summary> Optimized auto scale definition. </summary>
        public OptimizedAutoscale OptimizedAutoscale { get; set; }
        /// <summary> A boolean value that indicates if the cluster's disks are encrypted. </summary>
        public bool? IsDiskEncryptionEnabled { get; set; }
        /// <summary> A boolean value that indicates if the streaming ingest is enabled. </summary>
        public bool? IsStreamingIngestEnabled { get; set; }
        /// <summary> Virtual network definition. </summary>
        public KustoClusterVirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }
        /// <summary> KeyVault properties for the cluster encryption. </summary>
        public KustoKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> A boolean value that indicates if the purge operations are enabled. </summary>
        public bool? IsPurgeEnabled { get; set; }
        /// <summary> List of the cluster's language extensions. </summary>
        internal KustoLanguageExtensionList LanguageExtensions { get; set; }
        /// <summary> The list of language extensions. </summary>
        public IList<KustoLanguageExtension> LanguageExtensionsValue
        {
            get
            {
                if (LanguageExtensions is null)
                    LanguageExtensions = new KustoLanguageExtensionList();
                return LanguageExtensions.Value;
            }
        }

        /// <summary> A boolean value that indicates if double encryption is enabled. </summary>
        public bool? IsDoubleEncryptionEnabled { get; set; }
        /// <summary> Public network access to the cluster is enabled by default. When disabled, only private endpoint connection to the cluster is allowed. </summary>
        public KustoClusterPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The list of ips in the format of CIDR allowed to connect to the cluster. </summary>
        public IList<string> AllowedIPRangeList { get; }
        /// <summary> The engine type. </summary>
        public KustoClusterEngineType? EngineType { get; set; }
        /// <summary> The cluster's accepted audiences. </summary>
        public IList<AcceptedAudience> AcceptedAudiences { get; }
        /// <summary> A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no activity for many days). </summary>
        public bool? IsAutoStopEnabled { get; set; }
        /// <summary> Whether or not to restrict outbound network access.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
        public KustoClusterNetworkAccessFlag? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster. </summary>
        public IList<string> AllowedFqdnList { get; }
        /// <summary> List of callout policies for egress from Cluster. </summary>
        public IList<KustoCalloutPolicy> CalloutPolicies { get; }
        /// <summary> Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6). </summary>
        public KustoClusterPublicIPType? PublicIPType { get; set; }
        /// <summary> Virtual Cluster graduation properties. </summary>
        public string VirtualClusterGraduationProperties { get; set; }
        /// <summary> A list of private endpoint connections. </summary>
        public IReadOnlyList<KustoPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Properties of the peer cluster involved in a migration to/from this cluster. </summary>
        public MigrationClusterProperties MigrationCluster { get; }
        /// <summary> Indicates whether the cluster is zonal or non-zonal. </summary>
        public KustoClusterZoneStatus? ZoneStatus { get; }
    }
}
