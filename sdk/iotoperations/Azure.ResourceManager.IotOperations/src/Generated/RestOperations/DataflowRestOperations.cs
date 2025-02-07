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
using Azure.ResourceManager.IotOperations.Models;

namespace Azure.ResourceManager.IotOperations
{
    internal partial class DataflowRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DataflowRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataflowRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName)
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
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IotOperationsDataflowData>> GetAsync(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotOperationsDataflowData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IotOperationsDataflowData.DeserializeIotOperationsDataflowData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IotOperationsDataflowData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IotOperationsDataflowData> Get(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IotOperationsDataflowData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IotOperationsDataflowData.DeserializeIotOperationsDataflowData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IotOperationsDataflowData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, IotOperationsDataflowData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, IotOperationsDataflowData data)
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
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
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

        /// <summary> Create a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/>, <paramref name="dataflowName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, IotOperationsDataflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName, data);
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

        /// <summary> Create a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/>, <paramref name="dataflowName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, IotOperationsDataflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName, data);
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

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName)
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
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataflowName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
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

        /// <summary> Delete a DataflowResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="dataflowName"> Name of Instance dataflowProfile dataflow resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/>, <paramref name="dataflowProfileName"/> or <paramref name="dataflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, string dataflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));
            Argument.AssertNotNullOrEmpty(dataflowName, nameof(dataflowName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
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

        internal RequestUriBuilder CreateListByResourceGroupRequestUri(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.IoTOperations/instances/", false);
            uri.AppendPath(instanceName, true);
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByResourceGroupRequest(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName)
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
            uri.AppendPath("/dataflowProfiles/", false);
            uri.AppendPath(dataflowProfileName, true);
            uri.AppendPath("/dataflows", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List DataflowResource resources by DataflowProfileResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataflowResourceListResult>> ListByResourceGroupAsync(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataflowResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataflowResourceListResult.DeserializeDataflowResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DataflowResource resources by DataflowProfileResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataflowResourceListResult> ListByResourceGroup(string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName, instanceName, dataflowProfileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataflowResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataflowResourceListResult.DeserializeDataflowResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByResourceGroupNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName)
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

        /// <summary> List DataflowResource resources by DataflowProfileResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataflowResourceListResult>> ListByResourceGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, instanceName, dataflowProfileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataflowResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataflowResourceListResult.DeserializeDataflowResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DataflowResource resources by DataflowProfileResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="instanceName"> Name of instance. </param>
        /// <param name="dataflowProfileName"> Name of Instance dataflowProfile resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="instanceName"/> or <paramref name="dataflowProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataflowResourceListResult> ListByResourceGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, string instanceName, string dataflowProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(instanceName, nameof(instanceName));
            Argument.AssertNotNullOrEmpty(dataflowProfileName, nameof(dataflowProfileName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName, instanceName, dataflowProfileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataflowResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataflowResourceListResult.DeserializeDataflowResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
