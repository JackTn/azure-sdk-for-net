// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a StaticSiteBuild along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StaticSiteBuildResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStaticSiteBuildResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteResource" /> using the GetStaticSiteBuild method.
    /// </summary>
    public partial class StaticSiteBuildResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteBuildResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="environmentName"> The environmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string environmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteBuildStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildStaticSitesRestClient;
        private readonly StaticSiteBuildData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildResource"/> class for mocking. </summary>
        protected StaticSiteBuildResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteBuildResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteBuildResource(ArmClient client, StaticSiteBuildData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteBuildResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteBuildStaticSitesApiVersion);
            _staticSiteBuildStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/builds";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteBuildData Data
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

        /// <summary> Gets a collection of StaticSiteBuildUserProvidedFunctionAppResources in the StaticSiteBuild. </summary>
        /// <returns> An object representing collection of StaticSiteBuildUserProvidedFunctionAppResources and their operations over a StaticSiteBuildUserProvidedFunctionAppResource. </returns>
        public virtual StaticSiteBuildUserProvidedFunctionAppCollection GetStaticSiteBuildUserProvidedFunctionApps()
        {
            return GetCachedClient(client => new StaticSiteBuildUserProvidedFunctionAppCollection(client, Id));
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionAppResource>> GetStaticSiteBuildUserProvidedFunctionAppAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            return await GetStaticSiteBuildUserProvidedFunctionApps().GetAsync(functionAppName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StaticSiteBuildUserProvidedFunctionAppResource> GetStaticSiteBuildUserProvidedFunctionApp(string functionAppName, CancellationToken cancellationToken = default)
        {
            return GetStaticSiteBuildUserProvidedFunctionApps().Get(functionAppName, cancellationToken);
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteBuildResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteBuildResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.DeleteStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteBuildStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildStaticSitesRestClient.CreateDeleteStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.DeleteStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteBuildStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildStaticSitesRestClient.CreateDeleteStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the app settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/appsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteBuildAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual async Task<Response<AppServiceConfigurationDictionary>> CreateOrUpdateAppSettingsAsync(AppServiceConfigurationDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateOrUpdateAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.CreateOrUpdateStaticSiteBuildAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the app settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/appsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteBuildAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual Response<AppServiceConfigurationDictionary> CreateOrUpdateAppSettings(AppServiceConfigurationDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateOrUpdateAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.CreateOrUpdateStaticSiteBuildAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the function app settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/functionappsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteBuildFunctionAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site function app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual async Task<Response<AppServiceConfigurationDictionary>> CreateOrUpdateFunctionAppSettingsAsync(AppServiceConfigurationDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateOrUpdateFunctionAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.CreateOrUpdateStaticSiteBuildFunctionAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates or updates the function app settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/config/functionappsettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateStaticSiteBuildFunctionAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appSettings"> The dictionary containing the static site function app settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettings"/> is null. </exception>
        public virtual Response<AppServiceConfigurationDictionary> CreateOrUpdateFunctionAppSettings(AppServiceConfigurationDictionary appSettings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(appSettings, nameof(appSettings));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateOrUpdateFunctionAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.CreateOrUpdateStaticSiteBuildFunctionAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettings, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the functions of a particular static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildFunctions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteFunctionOverview" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteFunctionOverview> GetFunctionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildStaticSitesRestClient.CreateListStaticSiteBuildFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildStaticSitesRestClient.CreateListStaticSiteBuildFunctionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, StaticSiteFunctionOverview.DeserializeStaticSiteFunctionOverview, _staticSiteBuildStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildResource.GetFunctions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the functions of a particular static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/functions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildFunctions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteFunctionOverview" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteFunctionOverview> GetFunctions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildStaticSitesRestClient.CreateListStaticSiteBuildFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildStaticSitesRestClient.CreateListStaticSiteBuildFunctionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, StaticSiteFunctionOverview.DeserializeStaticSiteFunctionOverview, _staticSiteBuildStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildResource.GetFunctions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listAppSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppServiceConfigurationDictionary>> GetStaticSiteBuildAppSettingsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.GetStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.ListStaticSiteBuildAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listAppSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppServiceConfigurationDictionary> GetStaticSiteBuildAppSettings(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.GetStaticSiteBuildAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.ListStaticSiteBuildAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listFunctionAppSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildFunctionAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppServiceConfigurationDictionary>> GetFunctionAppSettingsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.GetFunctionAppSettings");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.ListStaticSiteBuildFunctionAppSettingsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the application settings of a static site build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/listFunctionAppSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_ListStaticSiteBuildFunctionAppSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppServiceConfigurationDictionary> GetFunctionAppSettings(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.GetFunctionAppSettings");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.ListStaticSiteBuildFunctionAppSettings(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deploys zipped content to a specific environment of a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/zipdeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateZipDeploymentForStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticSiteZipDeploymentEnvelope"> A JSON representation of the StaticSiteZipDeployment properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteZipDeploymentEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateZipDeploymentAsync(WaitUntil waitUntil, StaticSiteZipDeployment staticSiteZipDeploymentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(staticSiteZipDeploymentEnvelope, nameof(staticSiteZipDeploymentEnvelope));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateZipDeployment");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildStaticSitesRestClient.CreateZipDeploymentForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(_staticSiteBuildStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildStaticSitesRestClient.CreateCreateZipDeploymentForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deploys zipped content to a specific environment of a static site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/zipdeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateZipDeploymentForStaticSiteBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="staticSiteZipDeploymentEnvelope"> A JSON representation of the StaticSiteZipDeployment properties. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteZipDeploymentEnvelope"/> is null. </exception>
        public virtual ArmOperation CreateZipDeployment(WaitUntil waitUntil, StaticSiteZipDeployment staticSiteZipDeploymentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(staticSiteZipDeploymentEnvelope, nameof(staticSiteZipDeploymentEnvelope));

            using var scope = _staticSiteBuildStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildResource.CreateZipDeployment");
            scope.Start();
            try
            {
                var response = _staticSiteBuildStaticSitesRestClient.CreateZipDeploymentForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation(_staticSiteBuildStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildStaticSitesRestClient.CreateCreateZipDeploymentForStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteZipDeploymentEnvelope).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
