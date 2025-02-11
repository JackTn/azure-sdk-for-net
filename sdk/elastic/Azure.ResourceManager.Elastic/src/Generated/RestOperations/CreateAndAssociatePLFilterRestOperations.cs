// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Elastic
{
    internal partial class CreateAndAssociatePLFilterRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CreateAndAssociatePLFilterRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CreateAndAssociatePLFilterRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string subscriptionId, string resourceGroupName, string monitorName, string name, string privateEndpointGuid, string privateEndpointName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Elastic/monitors/", false);
            uri.AppendPath(monitorName, true);
            uri.AppendPath("/createAndAssociatePLFilter", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (privateEndpointGuid != null)
            {
                uri.AppendQuery("privateEndpointGuid", privateEndpointGuid, true);
            }
            if (privateEndpointName != null)
            {
                uri.AppendQuery("privateEndpointName", privateEndpointName, true);
            }
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string monitorName, string name, string privateEndpointGuid, string privateEndpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Elastic/monitors/", false);
            uri.AppendPath(monitorName, true);
            uri.AppendPath("/createAndAssociatePLFilter", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (privateEndpointGuid != null)
            {
                uri.AppendQuery("privateEndpointGuid", privateEndpointGuid, true);
            }
            if (privateEndpointName != null)
            {
                uri.AppendQuery("privateEndpointName", privateEndpointName, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create and Associate private link traffic filter for the given deployment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="name"> Name of the traffic filter. </param>
        /// <param name="privateEndpointGuid"> Guid of the private endpoint. </param>
        /// <param name="privateEndpointName"> Name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string monitorName, string name = null, string privateEndpointGuid = null, string privateEndpointName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, monitorName, name, privateEndpointGuid, privateEndpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create and Associate private link traffic filter for the given deployment. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="name"> Name of the traffic filter. </param>
        /// <param name="privateEndpointGuid"> Guid of the private endpoint. </param>
        /// <param name="privateEndpointName"> Name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string monitorName, string name = null, string privateEndpointGuid = null, string privateEndpointName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, monitorName, name, privateEndpointGuid, privateEndpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
