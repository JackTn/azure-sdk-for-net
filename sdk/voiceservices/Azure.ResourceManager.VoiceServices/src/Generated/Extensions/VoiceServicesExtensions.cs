// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.VoiceServices.Mocking;
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.VoiceServices. </summary>
    public static partial class VoiceServicesExtensions
    {
        private static MockableVoiceServicesArmClient GetMockableVoiceServicesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableVoiceServicesArmClient(client0));
        }

        private static MockableVoiceServicesResourceGroupResource GetMockableVoiceServicesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableVoiceServicesResourceGroupResource(client, resource.Id));
        }

        private static MockableVoiceServicesSubscriptionResource GetMockableVoiceServicesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableVoiceServicesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="VoiceServicesCommunicationsGatewayResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VoiceServicesCommunicationsGatewayResource.CreateResourceIdentifier" /> to create a <see cref="VoiceServicesCommunicationsGatewayResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesArmClient.GetVoiceServicesCommunicationsGatewayResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VoiceServicesCommunicationsGatewayResource" /> object. </returns>
        public static VoiceServicesCommunicationsGatewayResource GetVoiceServicesCommunicationsGatewayResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableVoiceServicesArmClient(client).GetVoiceServicesCommunicationsGatewayResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VoiceServicesTestLineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VoiceServicesTestLineResource.CreateResourceIdentifier" /> to create a <see cref="VoiceServicesTestLineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesArmClient.GetVoiceServicesTestLineResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VoiceServicesTestLineResource" /> object. </returns>
        public static VoiceServicesTestLineResource GetVoiceServicesTestLineResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableVoiceServicesArmClient(client).GetVoiceServicesTestLineResource(id);
        }

        /// <summary>
        /// Gets a collection of VoiceServicesCommunicationsGatewayResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesResourceGroupResource.GetVoiceServicesCommunicationsGateways()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VoiceServicesCommunicationsGatewayResources and their operations over a VoiceServicesCommunicationsGatewayResource. </returns>
        public static VoiceServicesCommunicationsGatewayCollection GetVoiceServicesCommunicationsGateways(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableVoiceServicesResourceGroupResource(resourceGroupResource).GetVoiceServicesCommunicationsGateways();
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesResourceGroupResource.GetVoiceServicesCommunicationsGatewayAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<VoiceServicesCommunicationsGatewayResource>> GetVoiceServicesCommunicationsGatewayAsync(this ResourceGroupResource resourceGroupResource, string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            return await GetMockableVoiceServicesResourceGroupResource(resourceGroupResource).GetVoiceServicesCommunicationsGatewayAsync(communicationsGatewayName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesResourceGroupResource.GetVoiceServicesCommunicationsGateway(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGateway(this ResourceGroupResource resourceGroupResource, string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            return GetMockableVoiceServicesResourceGroupResource(resourceGroupResource).GetVoiceServicesCommunicationsGateway(communicationsGatewayName, cancellationToken);
        }

        /// <summary>
        /// List CommunicationsGateway resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesSubscriptionResource.GetVoiceServicesCommunicationsGateways(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGatewaysAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableVoiceServicesSubscriptionResource(subscriptionResource).GetVoiceServicesCommunicationsGatewaysAsync(cancellationToken);
        }

        /// <summary>
        /// List CommunicationsGateway resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesSubscriptionResource.GetVoiceServicesCommunicationsGateways(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGateways(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableVoiceServicesSubscriptionResource(subscriptionResource).GetVoiceServicesCommunicationsGateways(cancellationToken);
        }

        /// <summary>
        /// Check whether the resource name is available in the given region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NameAvailability_CheckLocal</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesSubscriptionResource.CheckVoiceServicesNameAvailability(AzureLocation,VoiceServicesCheckNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> The check availability request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<VoiceServicesCheckNameAvailabilityResult>> CheckVoiceServicesNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, VoiceServicesCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableVoiceServicesSubscriptionResource(subscriptionResource).CheckVoiceServicesNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check whether the resource name is available in the given region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NameAvailability_CheckLocal</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableVoiceServicesSubscriptionResource.CheckVoiceServicesNameAvailability(AzureLocation,VoiceServicesCheckNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> The check availability request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<VoiceServicesCheckNameAvailabilityResult> CheckVoiceServicesNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, VoiceServicesCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableVoiceServicesSubscriptionResource(subscriptionResource).CheckVoiceServicesNameAvailability(location, content, cancellationToken);
        }
    }
}
