// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A Class representing a RegionInfoResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RegionInfoResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRegionInfoResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetRegionInfoResource method.
    /// </summary>
    public partial class RegionInfoResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RegionInfoResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics;
        private readonly NetAppResourceRegionInfosRestOperations _regionInfoResourceNetAppResourceRegionInfosRestClient;
        private readonly RegionInfoResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NetApp/locations/regionInfos";

        /// <summary> Initializes a new instance of the <see cref="RegionInfoResource"/> class for mocking. </summary>
        protected RegionInfoResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegionInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RegionInfoResource(ArmClient client, RegionInfoResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RegionInfoResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RegionInfoResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string regionInfoResourceNetAppResourceRegionInfosApiVersion);
            _regionInfoResourceNetAppResourceRegionInfosRestClient = new NetAppResourceRegionInfosRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regionInfoResourceNetAppResourceRegionInfosApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RegionInfoResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegionInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResource.Get");
            scope.Start();
            try
            {
                var response = await _regionInfoResourceNetAppResourceRegionInfosRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegionInfoResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResource.Get");
            scope.Start();
            try
            {
                var response = _regionInfoResourceNetAppResourceRegionInfosRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
