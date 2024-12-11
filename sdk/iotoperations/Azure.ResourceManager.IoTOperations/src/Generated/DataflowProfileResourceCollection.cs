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

namespace Azure.ResourceManager.IoTOperations
{
    /// <summary>
    /// A class representing a collection of <see cref="DataflowProfileResource"/> and their operations.
    /// Each <see cref="DataflowProfileResource"/> in the collection will belong to the same instance of <see cref="InstanceResource"/>.
    /// To get a <see cref="DataflowProfileResourceCollection"/> instance call the GetDataflowProfileResources method from an instance of <see cref="InstanceResource"/>.
    /// </summary>
    public partial class DataflowProfileResourceCollection : ArmCollection, IEnumerable<DataflowProfileResource>, IAsyncEnumerable<DataflowProfileResource>
    {
        private readonly ClientDiagnostics _dataflowProfileResourceDataflowProfileClientDiagnostics;
        private readonly DataflowProfileRestOperations _dataflowProfileResourceDataflowProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataflowProfileResourceCollection"/> class for mocking. </summary>
        protected DataflowProfileResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataflowProfileResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataflowProfileResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataflowProfileResourceDataflowProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IoTOperations", DataflowProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataflowProfileResource.ResourceType, out string dataflowProfileResourceDataflowProfileApiVersion);
            _dataflowProfileResourceDataflowProfileRestClient = new DataflowProfileRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataflowProfileResourceDataflowProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != InstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, InstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DataflowProfileResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataflowProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataflowProfileName, DataflowProfileResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataflowProfileResourceDataflowProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IoTOperationsArmOperation<DataflowProfileResource>(new DataflowProfileResourceOperationSource(Client), _dataflowProfileResourceDataflowProfileClientDiagnostics, Pipeline, _dataflowProfileResourceDataflowProfileRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DataflowProfileResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataflowProfileResource> CreateOrUpdate(WaitUntil waitUntil, string dataflowProfileName, DataflowProfileResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataflowProfileResourceDataflowProfileRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, data, cancellationToken);
                var operation = new IoTOperationsArmOperation<DataflowProfileResource>(new DataflowProfileResourceOperationSource(Client), _dataflowProfileResourceDataflowProfileClientDiagnostics, Pipeline, _dataflowProfileResourceDataflowProfileRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DataflowProfileResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual async Task<Response<DataflowProfileResource>> GetAsync(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataflowProfileResourceDataflowProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataflowProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DataflowProfileResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual Response<DataflowProfileResource> Get(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _dataflowProfileResourceDataflowProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataflowProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DataflowProfileResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataflowProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataflowProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataflowProfileResourceDataflowProfileRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataflowProfileResourceDataflowProfileRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataflowProfileResource(Client, DataflowProfileResourceData.DeserializeDataflowProfileResourceData(e)), _dataflowProfileResourceDataflowProfileClientDiagnostics, Pipeline, "DataflowProfileResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DataflowProfileResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataflowProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataflowProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataflowProfileResourceDataflowProfileRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataflowProfileResourceDataflowProfileRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataflowProfileResource(Client, DataflowProfileResourceData.DeserializeDataflowProfileResourceData(e)), _dataflowProfileResourceDataflowProfileClientDiagnostics, Pipeline, "DataflowProfileResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataflowProfileResourceDataflowProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataflowProfileResourceDataflowProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataflowProfileResource>> GetIfExistsAsync(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataflowProfileResourceDataflowProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataflowProfileResource>(response.GetRawResponse());
                return Response.FromValue(new DataflowProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/dataflowProfiles/{dataflowProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataflowProfileResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataflowProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataflowProfileName"/> is null. </exception>
        public virtual NullableResponse<DataflowProfileResource> GetIfExists(string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var scope = _dataflowProfileResourceDataflowProfileClientDiagnostics.CreateScope("DataflowProfileResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataflowProfileResourceDataflowProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataflowProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataflowProfileResource>(response.GetRawResponse());
                return Response.FromValue(new DataflowProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataflowProfileResource> IEnumerable<DataflowProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataflowProfileResource> IAsyncEnumerable<DataflowProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
