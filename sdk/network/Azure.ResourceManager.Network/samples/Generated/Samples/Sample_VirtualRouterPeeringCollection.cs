// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualRouterPeeringCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualRouterPeeringPut.json
            // this example is just showing the usage of "VirtualRouterPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // get the collection of this VirtualRouterPeeringResource
            VirtualRouterPeeringCollection collection = virtualRouter.GetVirtualRouterPeerings();

            // invoke the operation
            string peeringName = "peering1";
            VirtualRouterPeeringData data = new VirtualRouterPeeringData
            {
                PeerAsn = 20000L,
                PeerIP = "192.168.1.5",
            };
            ArmOperation<VirtualRouterPeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, peeringName, data);
            VirtualRouterPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualRouterPeeringGet.json
            // this example is just showing the usage of "VirtualRouterPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // get the collection of this VirtualRouterPeeringResource
            VirtualRouterPeeringCollection collection = virtualRouter.GetVirtualRouterPeerings();

            // invoke the operation
            string peeringName = "peering1";
            VirtualRouterPeeringResource result = await collection.GetAsync(peeringName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllVirtualRouterPeeringsForAGivenVirtualRouter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualRouterPeeringList.json
            // this example is just showing the usage of "VirtualRouterPeerings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // get the collection of this VirtualRouterPeeringResource
            VirtualRouterPeeringCollection collection = virtualRouter.GetVirtualRouterPeerings();

            // invoke the operation and iterate over the result
            await foreach (VirtualRouterPeeringResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualRouterPeeringData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualRouterPeeringGet.json
            // this example is just showing the usage of "VirtualRouterPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // get the collection of this VirtualRouterPeeringResource
            VirtualRouterPeeringCollection collection = virtualRouter.GetVirtualRouterPeerings();

            // invoke the operation
            string peeringName = "peering1";
            bool result = await collection.ExistsAsync(peeringName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetVirtualRouterPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualRouterPeeringGet.json
            // this example is just showing the usage of "VirtualRouterPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // get the collection of this VirtualRouterPeeringResource
            VirtualRouterPeeringCollection collection = virtualRouter.GetVirtualRouterPeerings();

            // invoke the operation
            string peeringName = "peering1";
            NullableResponse<VirtualRouterPeeringResource> response = await collection.GetIfExistsAsync(peeringName);
            VirtualRouterPeeringResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualRouterPeeringData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
