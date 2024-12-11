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

namespace Azure.Communication.CallAutomation
{
    internal partial class AzureCommunicationServicesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AzureCommunicationServicesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public AzureCommunicationServicesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2024-01-22-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateCallRequest(CreateCallRequestInternal createCallRequestInternal)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createCallRequestInternal);
            request.Content = content;
            return message;
        }

        /// <summary> Create an outbound call. </summary>
        /// <param name="createCallRequestInternal"> The create call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCallRequestInternal"/> is null. </exception>
        public async Task<Response<CallConnectionPropertiesInternal>> CreateCallAsync(CreateCallRequestInternal createCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (createCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(createCallRequestInternal));
            }

            using var message = CreateCreateCallRequest(createCallRequestInternal);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create an outbound call. </summary>
        /// <param name="createCallRequestInternal"> The create call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCallRequestInternal"/> is null. </exception>
        public Response<CallConnectionPropertiesInternal> CreateCall(CreateCallRequestInternal createCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (createCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(createCallRequestInternal));
            }

            using var message = CreateCreateCallRequest(createCallRequestInternal);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnswerCallRequest(AnswerCallRequestInternal answerCallRequestInternal)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:answer", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(answerCallRequestInternal);
            request.Content = content;
            return message;
        }

        /// <summary> Answer a Call. </summary>
        /// <param name="answerCallRequestInternal"> The answer call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="answerCallRequestInternal"/> is null. </exception>
        /// <remarks> Answer a call using the IncomingCallContext from Event Grid. </remarks>
        public async Task<Response<CallConnectionPropertiesInternal>> AnswerCallAsync(AnswerCallRequestInternal answerCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (answerCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(answerCallRequestInternal));
            }

            using var message = CreateAnswerCallRequest(answerCallRequestInternal);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Answer a Call. </summary>
        /// <param name="answerCallRequestInternal"> The answer call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="answerCallRequestInternal"/> is null. </exception>
        /// <remarks> Answer a call using the IncomingCallContext from Event Grid. </remarks>
        public Response<CallConnectionPropertiesInternal> AnswerCall(AnswerCallRequestInternal answerCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (answerCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(answerCallRequestInternal));
            }

            using var message = CreateAnswerCallRequest(answerCallRequestInternal);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRedirectCallRequest(RedirectCallRequestInternal redirectCallRequestInternal)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:redirect", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(redirectCallRequestInternal);
            request.Content = content;
            return message;
        }

        /// <summary> Redirect a call. </summary>
        /// <param name="redirectCallRequestInternal"> The redirect call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="redirectCallRequestInternal"/> is null. </exception>
        public async Task<Response> RedirectCallAsync(RedirectCallRequestInternal redirectCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (redirectCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(redirectCallRequestInternal));
            }

            using var message = CreateRedirectCallRequest(redirectCallRequestInternal);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Redirect a call. </summary>
        /// <param name="redirectCallRequestInternal"> The redirect call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="redirectCallRequestInternal"/> is null. </exception>
        public Response RedirectCall(RedirectCallRequestInternal redirectCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (redirectCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(redirectCallRequestInternal));
            }

            using var message = CreateRedirectCallRequest(redirectCallRequestInternal);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRejectCallRequest(RejectCallRequestInternal rejectCallRequestInternal)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:reject", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(rejectCallRequestInternal);
            request.Content = content;
            return message;
        }

        /// <summary> Reject the call. </summary>
        /// <param name="rejectCallRequestInternal"> The reject call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rejectCallRequestInternal"/> is null. </exception>
        public async Task<Response> RejectCallAsync(RejectCallRequestInternal rejectCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (rejectCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(rejectCallRequestInternal));
            }

            using var message = CreateRejectCallRequest(rejectCallRequestInternal);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reject the call. </summary>
        /// <param name="rejectCallRequestInternal"> The reject call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rejectCallRequestInternal"/> is null. </exception>
        public Response RejectCall(RejectCallRequestInternal rejectCallRequestInternal, CancellationToken cancellationToken = default)
        {
            if (rejectCallRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(rejectCallRequestInternal));
            }

            using var message = CreateRejectCallRequest(rejectCallRequestInternal);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateConnectRequest(ConnectRequestInternal connectRequestInternal)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/callConnections:connect", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(connectRequestInternal);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Connection to a CallLocator. </summary>
        /// <param name="connectRequestInternal"> The create connection request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectRequestInternal"/> is null. </exception>
        /// <remarks> Create a connection to a CallLocator. </remarks>
        public async Task<Response<CallConnectionPropertiesInternal>> ConnectAsync(ConnectRequestInternal connectRequestInternal, CancellationToken cancellationToken = default)
        {
            if (connectRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(connectRequestInternal));
            }

            using var message = CreateConnectRequest(connectRequestInternal);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a Connection to a CallLocator. </summary>
        /// <param name="connectRequestInternal"> The create connection request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectRequestInternal"/> is null. </exception>
        /// <remarks> Create a connection to a CallLocator. </remarks>
        public Response<CallConnectionPropertiesInternal> Connect(ConnectRequestInternal connectRequestInternal, CancellationToken cancellationToken = default)
        {
            if (connectRequestInternal == null)
            {
                throw new ArgumentNullException(nameof(connectRequestInternal));
            }

            using var message = CreateConnectRequest(connectRequestInternal);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
