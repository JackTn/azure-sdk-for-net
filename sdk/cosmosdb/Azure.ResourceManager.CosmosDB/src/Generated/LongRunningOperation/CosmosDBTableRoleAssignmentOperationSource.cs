// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBTableRoleAssignmentOperationSource : IOperationSource<CosmosDBTableRoleAssignmentResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBTableRoleAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBTableRoleAssignmentResource IOperationSource<CosmosDBTableRoleAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBTableRoleAssignmentData.DeserializeCosmosDBTableRoleAssignmentData(document.RootElement);
            return new CosmosDBTableRoleAssignmentResource(_client, data);
        }

        async ValueTask<CosmosDBTableRoleAssignmentResource> IOperationSource<CosmosDBTableRoleAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBTableRoleAssignmentData.DeserializeCosmosDBTableRoleAssignmentData(document.RootElement);
            return new CosmosDBTableRoleAssignmentResource(_client, data);
        }
    }
}
