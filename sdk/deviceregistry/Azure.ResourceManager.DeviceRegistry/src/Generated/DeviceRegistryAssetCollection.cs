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
    /// A class representing a collection of <see cref="DeviceRegistryAssetResource"/> and their operations.
    /// Each <see cref="DeviceRegistryAssetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DeviceRegistryAssetCollection"/> instance call the GetDeviceRegistryAssets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DeviceRegistryAssetCollection : ArmCollection, IEnumerable<DeviceRegistryAssetResource>, IAsyncEnumerable<DeviceRegistryAssetResource>
    {
        private readonly ClientDiagnostics _deviceRegistryAssetAssetsClientDiagnostics;
        private readonly AssetsRestOperations _deviceRegistryAssetAssetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceRegistryAssetCollection"/> class for mocking. </summary>
        protected DeviceRegistryAssetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceRegistryAssetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceRegistryAssetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceRegistryAssetAssetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceRegistry", DeviceRegistryAssetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceRegistryAssetResource.ResourceType, out string deviceRegistryAssetAssetsApiVersion);
            _deviceRegistryAssetAssetsRestClient = new AssetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceRegistryAssetAssetsApiVersion);
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
        /// Create a Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceRegistryAssetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string assetName, DeviceRegistryAssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceRegistryAssetAssetsRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, assetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceRegistryArmOperation<DeviceRegistryAssetResource>(new DeviceRegistryAssetOperationSource(Client), _deviceRegistryAssetAssetsClientDiagnostics, Pipeline, _deviceRegistryAssetAssetsRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, assetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceRegistryAssetResource> CreateOrUpdate(WaitUntil waitUntil, string assetName, DeviceRegistryAssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceRegistryAssetAssetsRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, assetName, data, cancellationToken);
                var operation = new DeviceRegistryArmOperation<DeviceRegistryAssetResource>(new DeviceRegistryAssetOperationSource(Client), _deviceRegistryAssetAssetsClientDiagnostics, Pipeline, _deviceRegistryAssetAssetsRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, assetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual async Task<Response<DeviceRegistryAssetResource>> GetAsync(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceRegistryAssetAssetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistryAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual Response<DeviceRegistryAssetResource> Get(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceRegistryAssetAssetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistryAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Asset resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceRegistryAssetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceRegistryAssetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceRegistryAssetAssetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceRegistryAssetAssetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceRegistryAssetResource(Client, DeviceRegistryAssetData.DeserializeDeviceRegistryAssetData(e)), _deviceRegistryAssetAssetsClientDiagnostics, Pipeline, "DeviceRegistryAssetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Asset resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceRegistryAssetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceRegistryAssetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceRegistryAssetAssetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deviceRegistryAssetAssetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceRegistryAssetResource(Client, DeviceRegistryAssetData.DeserializeDeviceRegistryAssetData(e)), _deviceRegistryAssetAssetsClientDiagnostics, Pipeline, "DeviceRegistryAssetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceRegistryAssetAssetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual Response<bool> Exists(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceRegistryAssetAssetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeviceRegistryAssetResource>> GetIfExistsAsync(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceRegistryAssetAssetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeviceRegistryAssetResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistryAssetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceRegistry/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Asset_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceRegistryAssetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assetName"> Asset name parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assetName"/> is null. </exception>
        public virtual NullableResponse<DeviceRegistryAssetResource> GetIfExists(string assetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assetName, nameof(assetName));

            using var scope = _deviceRegistryAssetAssetsClientDiagnostics.CreateScope("DeviceRegistryAssetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceRegistryAssetAssetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, assetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeviceRegistryAssetResource>(response.GetRawResponse());
                return Response.FromValue(new DeviceRegistryAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceRegistryAssetResource> IEnumerable<DeviceRegistryAssetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceRegistryAssetResource> IAsyncEnumerable<DeviceRegistryAssetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
