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
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAvsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAvsResourceGroupResource"/> class for mocking. </summary>
        protected MockableAvsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAvsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAvsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AvsPrivateCloudResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AvsPrivateCloudResources and their operations over a AvsPrivateCloudResource. </returns>
        public virtual AvsPrivateCloudCollection GetAvsPrivateClouds()
        {
            return GetCachedClient(client => new AvsPrivateCloudCollection(client, Id));
        }

        /// <summary>
        /// Get a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AvsPrivateCloudResource>> GetAvsPrivateCloudAsync(string privateCloudName, CancellationToken cancellationToken = default)
        {
            return await GetAvsPrivateClouds().GetAsync(privateCloudName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AvsPrivateCloudResource> GetAvsPrivateCloud(string privateCloudName, CancellationToken cancellationToken = default)
        {
            return GetAvsPrivateClouds().Get(privateCloudName, cancellationToken);
        }
    }
}
