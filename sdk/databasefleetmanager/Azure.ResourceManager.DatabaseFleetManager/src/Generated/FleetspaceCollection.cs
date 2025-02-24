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

namespace Azure.ResourceManager.DatabaseFleetManager
{
    /// <summary>
    /// A class representing a collection of <see cref="FleetspaceResource"/> and their operations.
    /// Each <see cref="FleetspaceResource"/> in the collection will belong to the same instance of <see cref="FleetResource"/>.
    /// To get a <see cref="FleetspaceCollection"/> instance call the GetFleetspaces method from an instance of <see cref="FleetResource"/>.
    /// </summary>
    public partial class FleetspaceCollection : ArmCollection, IEnumerable<FleetspaceResource>, IAsyncEnumerable<FleetspaceResource>
    {
        private readonly ClientDiagnostics _fleetspaceClientDiagnostics;
        private readonly FleetspacesRestOperations _fleetspaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="FleetspaceCollection"/> class for mocking. </summary>
        protected FleetspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FleetspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FleetspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fleetspaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseFleetManager", FleetspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FleetspaceResource.ResourceType, out string fleetspaceApiVersion);
            _fleetspaceRestClient = new FleetspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fleetspaceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FleetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FleetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a fleetspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="data"> The fleet object to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FleetspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fleetspaceName, FleetspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fleetspaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseFleetManagerArmOperation<FleetspaceResource>(new FleetspaceOperationSource(Client), _fleetspaceClientDiagnostics, Pipeline, _fleetspaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a fleetspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="data"> The fleet object to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FleetspaceResource> CreateOrUpdate(WaitUntil waitUntil, string fleetspaceName, FleetspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fleetspaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, data, cancellationToken);
                var operation = new DatabaseFleetManagerArmOperation<FleetspaceResource>(new FleetspaceOperationSource(Client), _fleetspaceClientDiagnostics, Pipeline, _fleetspaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets fleetspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual async Task<Response<FleetspaceResource>> GetAsync(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _fleetspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FleetspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets fleetspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual Response<FleetspaceResource> Get(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _fleetspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FleetspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists fleetspaces in a fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_ListByFleet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FleetspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FleetspaceResource> GetAllAsync(long? skip = null, long? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fleetspaceRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fleetspaceRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FleetspaceResource(Client, FleetspaceData.DeserializeFleetspaceData(e)), _fleetspaceClientDiagnostics, Pipeline, "FleetspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists fleetspaces in a fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_ListByFleet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FleetspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FleetspaceResource> GetAll(long? skip = null, long? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fleetspaceRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fleetspaceRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FleetspaceResource(Client, FleetspaceData.DeserializeFleetspaceData(e)), _fleetspaceClientDiagnostics, Pipeline, "FleetspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fleetspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _fleetspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<FleetspaceResource>> GetIfExistsAsync(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fleetspaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FleetspaceResource>(response.GetRawResponse());
                return Response.FromValue(new FleetspaceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseFleetManager/fleets/{fleetName}/fleetspaces/{fleetspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleetspace_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FleetspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetspaceName"> Name of the fleetspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetspaceName"/> is null. </exception>
        public virtual NullableResponse<FleetspaceResource> GetIfExists(string fleetspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetspaceName, nameof(fleetspaceName));

            using var scope = _fleetspaceClientDiagnostics.CreateScope("FleetspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fleetspaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FleetspaceResource>(response.GetRawResponse());
                return Response.FromValue(new FleetspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FleetspaceResource> IEnumerable<FleetspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FleetspaceResource> IAsyncEnumerable<FleetspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
