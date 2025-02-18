// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkManagerSecurityUserRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsASecurityUserRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerSecurityUserRuleGet.json
            // this example is just showing the usage of "SecurityUserRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerSecurityUserRuleResource created on azure
            // for more information of creating NetworkManagerSecurityUserRuleResource, please refer to the document of NetworkManagerSecurityUserRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleUserRule";
            ResourceIdentifier networkManagerSecurityUserRuleResourceId = NetworkManagerSecurityUserRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerSecurityUserRuleResource networkManagerSecurityUserRule = client.GetNetworkManagerSecurityUserRuleResource(networkManagerSecurityUserRuleResourceId);

            // invoke the operation
            NetworkManagerSecurityUserRuleResource result = await networkManagerSecurityUserRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerSecurityUserRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteASecurityUserRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerSecurityUserRuleDelete.json
            // this example is just showing the usage of "SecurityUserRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerSecurityUserRuleResource created on azure
            // for more information of creating NetworkManagerSecurityUserRuleResource, please refer to the document of NetworkManagerSecurityUserRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleUserRule";
            ResourceIdentifier networkManagerSecurityUserRuleResourceId = NetworkManagerSecurityUserRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerSecurityUserRuleResource networkManagerSecurityUserRule = client.GetNetworkManagerSecurityUserRuleResource(networkManagerSecurityUserRuleResourceId);

            // invoke the operation
            bool? force = false;
            await networkManagerSecurityUserRule.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateASecurityUserRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerSecurityUserRulePut.json
            // this example is just showing the usage of "SecurityUserRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerSecurityUserRuleResource created on azure
            // for more information of creating NetworkManagerSecurityUserRuleResource, please refer to the document of NetworkManagerSecurityUserRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleUserRule";
            ResourceIdentifier networkManagerSecurityUserRuleResourceId = NetworkManagerSecurityUserRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerSecurityUserRuleResource networkManagerSecurityUserRule = client.GetNetworkManagerSecurityUserRuleResource(networkManagerSecurityUserRuleResourceId);

            // invoke the operation
            NetworkManagerSecurityUserRuleData data = new NetworkManagerSecurityUserRuleData
            {
                Description = "Sample User Rule",
                Protocol = SecurityConfigurationRuleProtocol.Tcp,
                Sources = {new AddressPrefixItem
{
AddressPrefix = "*",
AddressPrefixType = AddressPrefixType.IPPrefix,
}},
                Destinations = {new AddressPrefixItem
{
AddressPrefix = "*",
AddressPrefixType = AddressPrefixType.IPPrefix,
}},
                SourcePortRanges = { "0-65535" },
                DestinationPortRanges = { "22" },
                Direction = SecurityConfigurationRuleDirection.Inbound,
            };
            ArmOperation<NetworkManagerSecurityUserRuleResource> lro = await networkManagerSecurityUserRule.UpdateAsync(WaitUntil.Completed, data);
            NetworkManagerSecurityUserRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerSecurityUserRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
