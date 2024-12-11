// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.IoTOperations.Models;

namespace Azure.ResourceManager.IoTOperations
{
    internal partial class BrokerAuthorizationRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BrokerAuthorizationRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BrokerAuthorizationRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BrokerAuthorizationResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BrokerAuthorizationResourceData.DeserializeBrokerAuthorizationResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BrokerAuthorizationResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BrokerAuthorizationResourceData> Get(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BrokerAuthorizationResourceData.DeserializeBrokerAuthorizationResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BrokerAuthorizationResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, BrokerAuthorizationResourceData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, BrokerAuthorizationResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/>, <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, BrokerAuthorizationResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/>, <paramref name="authorizationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, BrokerAuthorizationResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a BrokerAuthorizationResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="authorizationName"> Name of Instance broker authorization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="brokerName"/> or <paramref name="authorizationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, string authorizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNullOrEmpty(authorizationName, nameof(authorizationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, instanceName, brokerName, authorizationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByResourceGroupRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string brokerName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByResourceGroupRequest(string subscriptionId, string resourceGroupName, string instanceName, string brokerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/brokers/", false);
            uri.AppendPath(brokerName, true);
            uri.AppendPath("/authorizations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List BrokerAuthorizationResource resources by BrokerResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BrokerAuthorizationResourceListResult>> ListByResourceGroupAsync(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName, instanceName, brokerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BrokerAuthorizationResourceListResult.DeserializeBrokerAuthorizationResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List BrokerAuthorizationResource resources by BrokerResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BrokerAuthorizationResourceListResult> ListByResourceGroup(string subscriptionId, string resourceGroupName, string instanceName, string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName, instanceName, brokerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BrokerAuthorizationResourceListResult.DeserializeBrokerAuthorizationResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByResourceGroupNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string brokerName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string brokerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List BrokerAuthorizationResource resources by BrokerResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BrokerAuthorizationResourceListResult>> ListByResourceGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, instanceName, brokerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BrokerAuthorizationResourceListResult.DeserializeBrokerAuthorizationResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List BrokerAuthorizationResource resources by BrokerResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BrokerAuthorizationResourceListResult> ListByResourceGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, instanceName, brokerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BrokerAuthorizationResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BrokerAuthorizationResourceListResult.DeserializeBrokerAuthorizationResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
