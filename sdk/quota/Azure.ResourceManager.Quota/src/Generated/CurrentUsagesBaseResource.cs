// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a CurrentUsagesBase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CurrentUsagesBaseResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCurrentUsagesBaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetCurrentUsagesBase method.
    /// </summary>
    public partial class CurrentUsagesBaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CurrentUsagesBaseResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="resourceName"> The resourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string resourceName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Quota/usages/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _currentUsagesBaseUsagesClientDiagnostics;
        private readonly UsagesRestOperations _currentUsagesBaseUsagesRestClient;
        private readonly CurrentUsagesBaseData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/usages";

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseResource"/> class for mocking. </summary>
        protected CurrentUsagesBaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CurrentUsagesBaseResource(ArmClient client, CurrentUsagesBaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentUsagesBaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CurrentUsagesBaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _currentUsagesBaseUsagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string currentUsagesBaseUsagesApiVersion);
            _currentUsagesBaseUsagesRestClient = new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, currentUsagesBaseUsagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CurrentUsagesBaseData Data
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

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CurrentUsagesBaseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseResource.Get");
            scope.Start();
            try
            {
                var response = await _currentUsagesBaseUsagesRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current usage of a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/usages/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CurrentUsagesBaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CurrentUsagesBaseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _currentUsagesBaseUsagesClientDiagnostics.CreateScope("CurrentUsagesBaseResource.Get");
            scope.Start();
            try
            {
                var response = _currentUsagesBaseUsagesRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentUsagesBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
