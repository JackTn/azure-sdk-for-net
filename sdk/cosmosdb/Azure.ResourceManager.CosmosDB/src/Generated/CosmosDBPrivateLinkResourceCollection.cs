// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBPrivateLinkResource"/> and their operations.
    /// Each <see cref="CosmosDBPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="CosmosDBPrivateLinkResourceCollection"/> instance call the GetCosmosDBPrivateLinkResources method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class CosmosDBPrivateLinkResourceCollection : ArmCollection, IEnumerable<CosmosDBPrivateLinkResource>, IAsyncEnumerable<CosmosDBPrivateLinkResource>
    {
        private readonly ClientDiagnostics _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected CosmosDBPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBPrivateLinkResource.ResourceType, out string cosmosDBPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Cosmos DB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBPrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Cosmos DB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<CosmosDBPrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Cosmos DB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByDatabaseAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByDatabaseAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBPrivateLinkResource(Client, CosmosDBPrivateLinkResourceData.DeserializeCosmosDBPrivateLinkResourceData(e)), _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "CosmosDBPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Cosmos DB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByDatabaseAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByDatabaseAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBPrivateLinkResource(Client, CosmosDBPrivateLinkResourceData.DeserializeCosmosDBPrivateLinkResourceData(e)), _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "CosmosDBPrivateLinkResourceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBPrivateLinkResource>> GetIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBPrivateLinkResource> GetIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _cosmosDBPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("CosmosDBPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBPrivateLinkResource> IEnumerable<CosmosDBPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBPrivateLinkResource> IAsyncEnumerable<CosmosDBPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
