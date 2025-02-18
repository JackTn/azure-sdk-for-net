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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceRegistrySchemaRegistryResource"/> and their operations.
    /// Each <see cref="DeviceRegistrySchemaRegistryResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DeviceRegistrySchemaRegistryCollection"/> instance call the GetDeviceRegistrySchemaRegistries method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DeviceRegistrySchemaRegistryCollection : ArmCollection, IEnumerable<DeviceRegistrySchemaRegistryResource>, IAsyncEnumerable<DeviceRegistrySchemaRegistryResource>
    {
        private readonly ClientDiagnostics _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics;
        private readonly SchemaRegistriesRestOperations _deviceRegistrySchemaRegistrySchemaRegistriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceRegistrySchemaRegistryCollection"/> class for mocking. </summary>
        protected DeviceRegistrySchemaRegistryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceRegistrySchemaRegistryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceRegistrySchemaRegistryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceRegistry", DeviceRegistrySchemaRegistryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceRegistrySchemaRegistryResource.ResourceType, out string deviceRegistrySchemaRegistrySchemaRegistriesApiVersion);
            _deviceRegistrySchemaRegistrySchemaRegistriesRestClient = new SchemaRegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceRegistrySchemaRegistrySchemaRegistriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a SchemaRegistry
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceRegistrySchemaRegistryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schemaRegistryName, DeviceRegistrySchemaRegistryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceRegistryArmOperation<DeviceRegistrySchemaRegistryResource>(new DeviceRegistrySchemaRegistryOperationSource(Client), _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics, Pipeline, _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a SchemaRegistry
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceRegistrySchemaRegistryResource> CreateOrUpdate(WaitUntil waitUntil, string schemaRegistryName, DeviceRegistrySchemaRegistryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, data, cancellationToken);
                var operation = new DeviceRegistryArmOperation<DeviceRegistrySchemaRegistryResource>(new DeviceRegistrySchemaRegistryOperationSource(Client), _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics, Pipeline, _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a SchemaRegistry
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual async Task<Response<DeviceRegistrySchemaRegistryResource>> GetAsync(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistrySchemaRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SchemaRegistry
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual Response<DeviceRegistrySchemaRegistryResource> Get(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistrySchemaRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List SchemaRegistry resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceRegistrySchemaRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceRegistrySchemaRegistryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceRegistrySchemaRegistryResource(Client, DeviceRegistrySchemaRegistryData.DeserializeDeviceRegistrySchemaRegistryData(e)), _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics, Pipeline, "DeviceRegistrySchemaRegistryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List SchemaRegistry resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceRegistrySchemaRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceRegistrySchemaRegistryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceRegistrySchemaRegistryResource(Client, DeviceRegistrySchemaRegistryData.DeserializeDeviceRegistrySchemaRegistryData(e)), _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics, Pipeline, "DeviceRegistrySchemaRegistryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeviceRegistrySchemaRegistryResource>> GetIfExistsAsync(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeviceRegistrySchemaRegistryResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistrySchemaRegistryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/schemaRegistries/{schemaRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SchemaRegistry_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistrySchemaRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaRegistryName"> Schema registry name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaRegistryName"/> is null. </exception>
        public virtual NullableResponse<DeviceRegistrySchemaRegistryResource> GetIfExists(string schemaRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaRegistryName, nameof(schemaRegistryName));

            using var scope = _deviceRegistrySchemaRegistrySchemaRegistriesClientDiagnostics.CreateScope("DeviceRegistrySchemaRegistryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceRegistrySchemaRegistrySchemaRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, schemaRegistryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeviceRegistrySchemaRegistryResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistrySchemaRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceRegistrySchemaRegistryResource> IEnumerable<DeviceRegistrySchemaRegistryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceRegistrySchemaRegistryResource> IAsyncEnumerable<DeviceRegistrySchemaRegistryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
