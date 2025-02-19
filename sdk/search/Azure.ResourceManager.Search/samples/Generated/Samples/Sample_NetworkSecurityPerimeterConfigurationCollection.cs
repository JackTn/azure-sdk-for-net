// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Search.Samples
{
    public partial class Sample_NetworkSecurityPerimeterConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnNSPConfigByName()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2025-02-01-preview/examples/NetworkSecurityPerimeterConfigurationsGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = searchService.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string nspConfigName = "00000001-2222-3333-4444-111144444444.assoc1";
            NetworkSecurityPerimeterConfigurationResource result = await collection.GetAsync(nspConfigName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListNSPConfigsBySearchService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2025-02-01-preview/examples/NetworkSecurityPerimeterConfigurationsListByService.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = searchService.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation and iterate over the result
            await foreach (NetworkSecurityPerimeterConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkSecurityPerimeterConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnNSPConfigByName()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2025-02-01-preview/examples/NetworkSecurityPerimeterConfigurationsGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = searchService.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string nspConfigName = "00000001-2222-3333-4444-111144444444.assoc1";
            bool result = await collection.ExistsAsync(nspConfigName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnNSPConfigByName()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2025-02-01-preview/examples/NetworkSecurityPerimeterConfigurationsGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = searchService.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string nspConfigName = "00000001-2222-3333-4444-111144444444.assoc1";
            NullableResponse<NetworkSecurityPerimeterConfigurationResource> response = await collection.GetIfExistsAsync(nspConfigName);
            NetworkSecurityPerimeterConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
