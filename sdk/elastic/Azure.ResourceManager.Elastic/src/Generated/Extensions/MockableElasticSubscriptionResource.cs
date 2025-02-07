// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Elastic.Models;

namespace Azure.ResourceManager.Elastic.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableElasticSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _elasticMonitorMonitorsClientDiagnostics;
        private MonitorsRestOperations _elasticMonitorMonitorsRestClient;
        private ClientDiagnostics _elasticVersionsClientDiagnostics;
        private ElasticVersionsRestOperations _elasticVersionsRestClient;
        private ClientDiagnostics _organizationsClientDiagnostics;
        private OrganizationsRestOperations _organizationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSubscriptionResource"/> class for mocking. </summary>
        protected MockableElasticSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableElasticSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ElasticMonitorMonitorsClientDiagnostics => _elasticMonitorMonitorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Elastic", ElasticMonitorResource.ResourceType.Namespace, Diagnostics);
        private MonitorsRestOperations ElasticMonitorMonitorsRestClient => _elasticMonitorMonitorsRestClient ??= new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ElasticMonitorResource.ResourceType));
        private ClientDiagnostics ElasticVersionsClientDiagnostics => _elasticVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Elastic", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ElasticVersionsRestOperations ElasticVersionsRestClient => _elasticVersionsRestClient ??= new ElasticVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics OrganizationsClientDiagnostics => _organizationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Elastic", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OrganizationsRestOperations OrganizationsRestClient => _organizationsRestClient ??= new OrganizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticMonitorResource> GetElasticMonitorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticMonitorMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticMonitorMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticMonitorResource(Client, ElasticMonitorData.DeserializeElasticMonitorData(e)), ElasticMonitorMonitorsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticMonitors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticMonitorResource> GetElasticMonitors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticMonitorMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticMonitorMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticMonitorResource(Client, ElasticMonitorData.DeserializeElasticMonitorData(e)), ElasticMonitorMonitorsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticMonitors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of available versions for a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/elasticVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="region"> Region where elastic deployment will take place. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        /// <returns> An async collection of <see cref="ElasticVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticVersion> GetElasticVersionsAsync(string region, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(region, nameof(region));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticVersionsRestClient.CreateListRequest(Id.SubscriptionId, region);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, region);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ElasticVersion.DeserializeElasticVersion(e), ElasticVersionsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticVersions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of available versions for a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/elasticVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="region"> Region where elastic deployment will take place. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        /// <returns> A collection of <see cref="ElasticVersion"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticVersion> GetElasticVersions(string region, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(region, nameof(region));

            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticVersionsRestClient.CreateListRequest(Id.SubscriptionId, region);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, region);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ElasticVersion.DeserializeElasticVersion(e), ElasticVersionsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticVersions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Fetch User API Key from internal database, if it was generated and stored while creating the Elasticsearch Organization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/getOrganizationApiKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_GetApiKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Email Id parameter of the User Organization, of which the API Key must be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ElasticUserApiKeyResult>> GetApiKeyAsync(ElasticUserEmailId body = null, CancellationToken cancellationToken = default)
        {
            using var scope = OrganizationsClientDiagnostics.CreateScope("MockableElasticSubscriptionResource.GetApiKey");
            scope.Start();
            try
            {
                var response = await OrganizationsRestClient.GetApiKeyAsync(Id.SubscriptionId, body, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetch User API Key from internal database, if it was generated and stored while creating the Elasticsearch Organization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/getOrganizationApiKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_GetApiKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Email Id parameter of the User Organization, of which the API Key must be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ElasticUserApiKeyResult> GetApiKey(ElasticUserEmailId body = null, CancellationToken cancellationToken = default)
        {
            using var scope = OrganizationsClientDiagnostics.CreateScope("MockableElasticSubscriptionResource.GetApiKey");
            scope.Start();
            try
            {
                var response = OrganizationsRestClient.GetApiKey(Id.SubscriptionId, body, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Elastic Organization To Azure Subscription Mapping details for the logged-in user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/getElasticOrganizationToAzureSubscriptionMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_GetElasticToAzureSubscriptionMapping</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ElasticOrganizationToAzureSubscriptionMappingResult>> GetElasticToAzureSubscriptionMappingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = OrganizationsClientDiagnostics.CreateScope("MockableElasticSubscriptionResource.GetElasticToAzureSubscriptionMapping");
            scope.Start();
            try
            {
                var response = await OrganizationsRestClient.GetElasticToAzureSubscriptionMappingAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Elastic Organization To Azure Subscription Mapping details for the logged-in user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/getElasticOrganizationToAzureSubscriptionMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_GetElasticToAzureSubscriptionMapping</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ElasticOrganizationToAzureSubscriptionMappingResult> GetElasticToAzureSubscriptionMapping(CancellationToken cancellationToken = default)
        {
            using var scope = OrganizationsClientDiagnostics.CreateScope("MockableElasticSubscriptionResource.GetElasticToAzureSubscriptionMapping");
            scope.Start();
            try
            {
                var response = OrganizationsRestClient.GetElasticToAzureSubscriptionMapping(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
