// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_DeviceRegistrySchemaVersionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Create_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // get the collection of this DeviceRegistrySchemaVersionResource
            DeviceRegistrySchemaVersionCollection collection = deviceRegistrySchema.GetDeviceRegistrySchemaVersions();

            // invoke the operation
            string schemaVersionName = "1";
            DeviceRegistrySchemaVersionData data = new DeviceRegistrySchemaVersionData
            {
                Properties = new DeviceRegistrySchemaVersionProperties("{\"$schema\": \"http://json-schema.org/draft-07/schema#\",\"type\": \"object\",\"properties\": {\"humidity\": {\"type\": \"string\"},\"temperature\": {\"type\":\"number\"}}}")
                {
                    Description = "Schema version 1",
                },
            };
            ArmOperation<DeviceRegistrySchemaVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, schemaVersionName, data);
            DeviceRegistrySchemaVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistrySchemaVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Get_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // get the collection of this DeviceRegistrySchemaVersionResource
            DeviceRegistrySchemaVersionCollection collection = deviceRegistrySchema.GetDeviceRegistrySchemaVersions();

            // invoke the operation
            string schemaVersionName = "1";
            DeviceRegistrySchemaVersionResource result = await collection.GetAsync(schemaVersionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistrySchemaVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListSchemaVersionsSchema()
        {
            // Generated from example definition: 2024-09-01-preview/List_SchemaVersions_Schema.json
            // this example is just showing the usage of "SchemaVersion_ListBySchema" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // get the collection of this DeviceRegistrySchemaVersionResource
            DeviceRegistrySchemaVersionCollection collection = deviceRegistrySchema.GetDeviceRegistrySchemaVersions();

            // invoke the operation and iterate over the result
            await foreach (DeviceRegistrySchemaVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceRegistrySchemaVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Get_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // get the collection of this DeviceRegistrySchemaVersionResource
            DeviceRegistrySchemaVersionCollection collection = deviceRegistrySchema.GetDeviceRegistrySchemaVersions();

            // invoke the operation
            string schemaVersionName = "1";
            bool result = await collection.ExistsAsync(schemaVersionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Get_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistrySchemaResource created on azure
            // for more information of creating DeviceRegistrySchemaResource, please refer to the document of DeviceRegistrySchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            ResourceIdentifier deviceRegistrySchemaResourceId = DeviceRegistrySchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName);
            DeviceRegistrySchemaResource deviceRegistrySchema = client.GetDeviceRegistrySchemaResource(deviceRegistrySchemaResourceId);

            // get the collection of this DeviceRegistrySchemaVersionResource
            DeviceRegistrySchemaVersionCollection collection = deviceRegistrySchema.GetDeviceRegistrySchemaVersions();

            // invoke the operation
            string schemaVersionName = "1";
            NullableResponse<DeviceRegistrySchemaVersionResource> response = await collection.GetIfExistsAsync(schemaVersionName);
            DeviceRegistrySchemaVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceRegistrySchemaVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
