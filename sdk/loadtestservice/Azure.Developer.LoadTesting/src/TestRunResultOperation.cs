﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Developer.LoadTesting.Models;

namespace Azure.Developer.LoadTesting
{
    /// <summary>
    /// Represents a long-running operation for TestRun.
    /// </summary>
    public class TestRunResultOperation : Operation<TestRun>
    {
        private bool _completed;
        private Response<TestRun> _response;
        private TestRun _value;
        private readonly string _testRunId;
        private readonly LoadTestRunClient _client;
        private readonly List<string> _terminalStatus = new()
            {
                "DONE",
                "FAILED",
                "CANCELLED"
            };

        /// <summary>
        /// Value.
        /// </summary>
        public override TestRun Value
        {
            get {
                if (HasCompleted && !HasValue)
                {
                    throw new InvalidOperationException("The operation is not complete.");
                }
                else
                {
                    return _value;
                }
            }
        }

        /// <summary>
        /// HasValue.
        /// </summary>
        public override bool HasValue => _completed;

        /// <summary>
        /// Id.
        /// </summary>
        public override string Id { get; }

        /// <summary>
        /// HasCompleted.
        /// </summary>
        public override bool HasCompleted => _completed;

        /// <summary>
        /// TestRunResultOperation.
        /// </summary>
        protected TestRunResultOperation() { }

        /// <summary>
        /// TestRunResultOperation.
        /// </summary>
        public TestRunResultOperation(string testRunId, LoadTestRunClient client, Response<TestRun> initialResponse = null)
        {
            _testRunId = Id = testRunId;
            _client = client;
            _completed = false;
            if (initialResponse != null)
            {
                _response = initialResponse;
                _value = _response.Value;
                GetCompletionResponse();
            }
        }

        /// <summary>
        /// GetRawResponse.
        /// </summary>
        public override Response GetRawResponse()
        {
            return _response.GetRawResponse();
        }

        /// <summary>
        /// UpdateStatus.
        /// </summary>
        public override Response UpdateStatus(CancellationToken cancellationToken = default)
        {
            if (_completed)
            {
                return GetRawResponse();
            }

            _response = _client.GetTestRun(_testRunId);
            _value = _response.Value;

            return GetCompletionResponse();
        }

        /// <summary>
        /// UpdateStatusAsync.
        /// </summary>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default)
        {
            if (_completed)
            {
                return GetRawResponse();
            }

            try
            {
                _response = await _client.GetTestRunAsync(_testRunId).ConfigureAwait(false);
                _value = _response.Value;
            }
            catch
            {
                throw new RequestFailedException(_response.GetRawResponse());
            }

            return GetCompletionResponse();
        }

        private Response GetCompletionResponse()
        {
            string testRunStatus = _value.Status.ToString();

            if (_terminalStatus.Contains(testRunStatus))
            {
                _completed = true;
            }

            return GetRawResponse();
        }
    }
}
