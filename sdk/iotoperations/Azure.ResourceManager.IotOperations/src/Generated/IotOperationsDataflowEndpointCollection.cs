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

namespace Azure.ResourceManager.IotOperations
{
    /// <summary>
    /// A class representing a collection of <see cref="IotOperationsDataflowEndpointResource"/> and their operations.
    /// Each <see cref="IotOperationsDataflowEndpointResource"/> in the collection will belong to the same instance of <see cref="IotOperationsInstanceResource"/>.
    /// To get an <see cref="IotOperationsDataflowEndpointCollection"/> instance call the GetIotOperationsDataflowEndpoints method from an instance of <see cref="IotOperationsInstanceResource"/>.
    /// </summary>
    public partial class IotOperationsDataflowEndpointCollection : ArmCollection, IEnumerable<IotOperationsDataflowEndpointResource>, IAsyncEnumerable<IotOperationsDataflowEndpointResource>
    {
        private readonly ClientDiagnostics _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics;
        private readonly DataflowEndpointRestOperations _iotOperationsDataflowEndpointDataflowEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotOperationsDataflowEndpointCollection"/> class for mocking. </summary>
        protected IotOperationsDataflowEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotOperationsDataflowEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotOperationsDataflowEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotOperations", IotOperationsDataflowEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotOperationsDataflowEndpointResource.ResourceType, out string iotOperationsDataflowEndpointDataflowEndpointApiVersion);
            _iotOperationsDataflowEndpointDataflowEndpointRestClient = new DataflowEndpointRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotOperationsDataflowEndpointDataflowEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotOperationsInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotOperationsInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotOperationsDataflowEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataflowEndpointName, IotOperationsDataflowEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotOperationsArmOperation<IotOperationsDataflowEndpointResource>(new IotOperationsDataflowEndpointOperationSource(Client), _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics, Pipeline, _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotOperationsDataflowEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string dataflowEndpointName, IotOperationsDataflowEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data, cancellationToken);
                var operation = new IotOperationsArmOperation<IotOperationsDataflowEndpointResource>(new IotOperationsDataflowEndpointOperationSource(Client), _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics, Pipeline, _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<Response<IotOperationsDataflowEndpointResource>> GetAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotOperationsDataflowEndpointDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsDataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DataflowEndpointResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual Response<IotOperationsDataflowEndpointResource> Get(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _iotOperationsDataflowEndpointDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsDataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DataflowEndpointResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotOperationsDataflowEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotOperationsDataflowEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotOperationsDataflowEndpointResource(Client, IotOperationsDataflowEndpointData.DeserializeIotOperationsDataflowEndpointData(e)), _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics, Pipeline, "IotOperationsDataflowEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DataflowEndpointResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotOperationsDataflowEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotOperationsDataflowEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotOperationsDataflowEndpointDataflowEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotOperationsDataflowEndpointResource(Client, IotOperationsDataflowEndpointData.DeserializeIotOperationsDataflowEndpointData(e)), _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics, Pipeline, "IotOperationsDataflowEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotOperationsDataflowEndpointDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotOperationsDataflowEndpointDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<IotOperationsDataflowEndpointResource>> GetIfExistsAsync(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _iotOperationsDataflowEndpointDataflowEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IotOperationsDataflowEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new IotOperationsDataflowEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowEndpoints/{dataflowEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowEndpointResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsDataflowEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowEndpointName"> Name of Instance dataflowEndpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowEndpointName"/> is null. </exception>
        public virtual NullableResponse<IotOperationsDataflowEndpointResource> GetIfExists(string dataflowEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowEndpointName, nameof(dataflowEndpointName));

            using var scope = _iotOperationsDataflowEndpointDataflowEndpointClientDiagnostics.CreateScope("IotOperationsDataflowEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _iotOperationsDataflowEndpointDataflowEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IotOperationsDataflowEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new IotOperationsDataflowEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotOperationsDataflowEndpointResource> IEnumerable<IotOperationsDataflowEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotOperationsDataflowEndpointResource> IAsyncEnumerable<IotOperationsDataflowEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
