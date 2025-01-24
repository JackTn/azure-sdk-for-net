// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameters supplied to the Create Redis operation. </summary>
    public partial class RedisCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="RedisCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="sku"> The SKU of the Redis cache to deploy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public RedisCreateOrUpdateContent(AzureLocation location, RedisSku sku)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Zones = new ChangeTrackingList<string>();
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            TenantSettings = new ChangeTrackingDictionary<string, string>();
            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="RedisCreateOrUpdateContent"/>. </summary>
        /// <param name="zones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="redisConfiguration"> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta, maxmemory-policy,notify-keyspace-events, aof-backup-enabled, aof-storage-connection-string-0, aof-storage-connection-string-1 etc. </param>
        /// <param name="redisVersion"> Redis version. This should be in the form 'major[.minor]' (only 'major' is required) or the value 'latest' which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value is 'latest'. </param>
        /// <param name="enableNonSslPort"> Specifies whether the non-ssl Redis server port (6379) is enabled. </param>
        /// <param name="replicasPerMaster"> The number of replicas to be created per primary. </param>
        /// <param name="replicasPerPrimary"> The number of replicas to be created per primary. </param>
        /// <param name="tenantSettings"> A dictionary of tenant settings. </param>
        /// <param name="shardCount"> The number of shards to be created on a Premium Cluster Cache. </param>
        /// <param name="minimumTlsVersion"> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2'). </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </param>
        /// <param name="updateChannel"> Optional: Specifies the update channel for the monthly Redis updates your Redis Cache will receive. Caches using 'Preview' update channel get latest Redis updates at least 4 weeks ahead of 'Stable' channel caches. Default value is 'Stable'. </param>
        /// <param name="isAccessKeyAuthenticationDisabled"> Authentication to Redis through access keys is disabled when set as true. Default value is false. </param>
        /// <param name="zonalAllocationPolicy"> Optional: Specifies how availability zones are allocated to the Redis cache. 'Automatic' enables zone redundancy and Azure will automatically select zones based on regional availability and capacity. 'UserDefined' will select availability zones passed in by you using the 'zones' parameter. 'NoZones' will produce a non-zonal cache. If 'zonalAllocationPolicy' is not passed, it will be set to 'UserDefined' when zones are passed in, otherwise, it will be set to 'Automatic' in regions where zones are supported and 'NoZones' in regions where zones are not supported. </param>
        /// <param name="sku"> The SKU of the Redis cache to deploy. </param>
        /// <param name="subnetId"> The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1. </param>
        /// <param name="staticIP"> Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual Network; auto assigned by default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisCreateOrUpdateContent(IList<string> zones, AzureLocation location, IDictionary<string, string> tags, ManagedServiceIdentity identity, RedisCommonConfiguration redisConfiguration, string redisVersion, bool? enableNonSslPort, int? replicasPerMaster, int? replicasPerPrimary, IDictionary<string, string> tenantSettings, int? shardCount, RedisTlsVersion? minimumTlsVersion, RedisPublicNetworkAccess? publicNetworkAccess, UpdateChannel? updateChannel, bool? isAccessKeyAuthenticationDisabled, ZonalAllocationPolicy? zonalAllocationPolicy, RedisSku sku, ResourceIdentifier subnetId, IPAddress staticIP, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Zones = zones;
            Location = location;
            Tags = tags;
            Identity = identity;
            RedisConfiguration = redisConfiguration;
            RedisVersion = redisVersion;
            EnableNonSslPort = enableNonSslPort;
            ReplicasPerMaster = replicasPerMaster;
            ReplicasPerPrimary = replicasPerPrimary;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            MinimumTlsVersion = minimumTlsVersion;
            PublicNetworkAccess = publicNetworkAccess;
            UpdateChannel = updateChannel;
            IsAccessKeyAuthenticationDisabled = isAccessKeyAuthenticationDisabled;
            ZonalAllocationPolicy = zonalAllocationPolicy;
            Sku = sku;
            SubnetId = subnetId;
            StaticIP = staticIP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisCreateOrUpdateContent"/> for deserialization. </summary>
        internal RedisCreateOrUpdateContent()
        {
        }

        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        [WirePath("zones")]
        public IList<string> Zones { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        [WirePath("location")]
        public AzureLocation Location { get; }
        /// <summary> Resource tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta, maxmemory-policy,notify-keyspace-events, aof-backup-enabled, aof-storage-connection-string-0, aof-storage-connection-string-1 etc. </summary>
        [WirePath("properties.redisConfiguration")]
        public RedisCommonConfiguration RedisConfiguration { get; set; }
        /// <summary> Redis version. This should be in the form 'major[.minor]' (only 'major' is required) or the value 'latest' which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value is 'latest'. </summary>
        [WirePath("properties.redisVersion")]
        public string RedisVersion { get; set; }
        /// <summary> Specifies whether the non-ssl Redis server port (6379) is enabled. </summary>
        [WirePath("properties.enableNonSslPort")]
        public bool? EnableNonSslPort { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        [WirePath("properties.replicasPerMaster")]
        public int? ReplicasPerMaster { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        [WirePath("properties.replicasPerPrimary")]
        public int? ReplicasPerPrimary { get; set; }
        /// <summary> A dictionary of tenant settings. </summary>
        [WirePath("properties.tenantSettings")]
        public IDictionary<string, string> TenantSettings { get; }
        /// <summary> The number of shards to be created on a Premium Cluster Cache. </summary>
        [WirePath("properties.shardCount")]
        public int? ShardCount { get; set; }
        /// <summary> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2'). </summary>
        [WirePath("properties.minimumTlsVersion")]
        public RedisTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public RedisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Optional: Specifies the update channel for the monthly Redis updates your Redis Cache will receive. Caches using 'Preview' update channel get latest Redis updates at least 4 weeks ahead of 'Stable' channel caches. Default value is 'Stable'. </summary>
        [WirePath("properties.updateChannel")]
        public UpdateChannel? UpdateChannel { get; set; }
        /// <summary> Authentication to Redis through access keys is disabled when set as true. Default value is false. </summary>
        [WirePath("properties.disableAccessKeyAuthentication")]
        public bool? IsAccessKeyAuthenticationDisabled { get; set; }
        /// <summary> Optional: Specifies how availability zones are allocated to the Redis cache. 'Automatic' enables zone redundancy and Azure will automatically select zones based on regional availability and capacity. 'UserDefined' will select availability zones passed in by you using the 'zones' parameter. 'NoZones' will produce a non-zonal cache. If 'zonalAllocationPolicy' is not passed, it will be set to 'UserDefined' when zones are passed in, otherwise, it will be set to 'Automatic' in regions where zones are supported and 'NoZones' in regions where zones are not supported. </summary>
        [WirePath("properties.zonalAllocationPolicy")]
        public ZonalAllocationPolicy? ZonalAllocationPolicy { get; set; }
        /// <summary> The SKU of the Redis cache to deploy. </summary>
        [WirePath("properties.sku")]
        public RedisSku Sku { get; }
        /// <summary> The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1. </summary>
        [WirePath("properties.subnetId")]
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual Network; auto assigned by default. </summary>
        [WirePath("properties.staticIP")]
        public IPAddress StaticIP { get; set; }
    }
}
