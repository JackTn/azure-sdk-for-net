// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ServiceNetworking.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableServiceNetworkingSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _trafficControllerTrafficControllerInterfaceClientDiagnostics;
        private TrafficControllerInterfaceRestOperations _trafficControllerTrafficControllerInterfaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableServiceNetworkingSubscriptionResource"/> class for mocking. </summary>
        protected MockableServiceNetworkingSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceNetworkingSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceNetworkingSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics TrafficControllerTrafficControllerInterfaceClientDiagnostics => _trafficControllerTrafficControllerInterfaceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceNetworking", TrafficControllerResource.ResourceType.Namespace, Diagnostics);
        private TrafficControllerInterfaceRestOperations TrafficControllerTrafficControllerInterfaceRestClient => _trafficControllerTrafficControllerInterfaceRestClient ??= new TrafficControllerInterfaceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(TrafficControllerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List TrafficController resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceNetworking/trafficControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficController_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TrafficControllerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TrafficControllerResource> GetTrafficControllersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => TrafficControllerTrafficControllerInterfaceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TrafficControllerTrafficControllerInterfaceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TrafficControllerResource(Client, TrafficControllerData.DeserializeTrafficControllerData(e)), TrafficControllerTrafficControllerInterfaceClientDiagnostics, Pipeline, "MockableServiceNetworkingSubscriptionResource.GetTrafficControllers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TrafficController resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceNetworking/trafficControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficController_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TrafficControllerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TrafficControllerResource> GetTrafficControllers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => TrafficControllerTrafficControllerInterfaceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TrafficControllerTrafficControllerInterfaceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TrafficControllerResource(Client, TrafficControllerData.DeserializeTrafficControllerData(e)), TrafficControllerTrafficControllerInterfaceClientDiagnostics, Pipeline, "MockableServiceNetworkingSubscriptionResource.GetTrafficControllers", "value", "nextLink", cancellationToken);
        }
    }
}
