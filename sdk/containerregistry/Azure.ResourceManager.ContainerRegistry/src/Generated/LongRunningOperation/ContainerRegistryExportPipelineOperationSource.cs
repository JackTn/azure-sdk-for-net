// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryExportPipelineOperationSource : IOperationSource<ContainerRegistryExportPipelineResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryExportPipelineOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryExportPipelineResource IOperationSource<ContainerRegistryExportPipelineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerRegistryExportPipelineData.DeserializeContainerRegistryExportPipelineData(document.RootElement);
            return new ContainerRegistryExportPipelineResource(_client, data);
        }

        async ValueTask<ContainerRegistryExportPipelineResource> IOperationSource<ContainerRegistryExportPipelineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerRegistryExportPipelineData.DeserializeContainerRegistryExportPipelineData(document.RootElement);
            return new ContainerRegistryExportPipelineResource(_client, data);
        }
    }
}
