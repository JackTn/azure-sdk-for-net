// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotOperations.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IotOperations.Samples
{
    public partial class Sample_IotOperationsBrokerListenerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BrokerListenerGet()
        {
            // Generated from example definition: 2024-11-01/BrokerListener_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "BrokerListenerResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsBrokerListenerResource created on azure
            // for more information of creating IotOperationsBrokerListenerResource, please refer to the document of IotOperationsBrokerListenerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            string listenerName = "resource-name123";
            ResourceIdentifier iotOperationsBrokerListenerResourceId = IotOperationsBrokerListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName, listenerName);
            IotOperationsBrokerListenerResource iotOperationsBrokerListener = client.GetIotOperationsBrokerListenerResource(iotOperationsBrokerListenerResourceId);

            // invoke the operation
            IotOperationsBrokerListenerResource result = await iotOperationsBrokerListener.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsBrokerListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_BrokerListenerDelete()
        {
            // Generated from example definition: 2024-11-01/BrokerListener_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "BrokerListenerResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsBrokerListenerResource created on azure
            // for more information of creating IotOperationsBrokerListenerResource, please refer to the document of IotOperationsBrokerListenerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            string listenerName = "resource-name123";
            ResourceIdentifier iotOperationsBrokerListenerResourceId = IotOperationsBrokerListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName, listenerName);
            IotOperationsBrokerListenerResource iotOperationsBrokerListener = client.GetIotOperationsBrokerListenerResource(iotOperationsBrokerListenerResourceId);

            // invoke the operation
            await iotOperationsBrokerListener.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BrokerListenerCreateOrUpdateComplex()
        {
            // Generated from example definition: 2024-11-01/BrokerListener_CreateOrUpdate_Complex.json
            // this example is just showing the usage of "BrokerListenerResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsBrokerListenerResource created on azure
            // for more information of creating IotOperationsBrokerListenerResource, please refer to the document of IotOperationsBrokerListenerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            string listenerName = "resource-name123";
            ResourceIdentifier iotOperationsBrokerListenerResourceId = IotOperationsBrokerListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName, listenerName);
            IotOperationsBrokerListenerResource iotOperationsBrokerListener = client.GetIotOperationsBrokerListenerResource(iotOperationsBrokerListenerResourceId);

            // invoke the operation
            IotOperationsBrokerListenerData data = new IotOperationsBrokerListenerData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsBrokerListenerProperties(new BrokerListenerPort[]
            {
new BrokerListenerPort(8080)
{
AuthenticationRef = "example-authentication",
Protocol = BrokerProtocolType.WebSockets,
},
new BrokerListenerPort(8443)
{
AuthenticationRef = "example-authentication",
Protocol = BrokerProtocolType.WebSockets,
Tls = new ListenerPortTlsCertMethod(TlsCertMethodMode.Automatic)
{
CertManagerCertificateSpec = new CertManagerCertificateSpec(new CertManagerIssuerRef("jtmuladdkpasfpoyvewekmiy", CertManagerIssuerKind.Issuer, "example-issuer")),
},
},
new BrokerListenerPort(1883)
{
AuthenticationRef = "example-authentication",
},
new BrokerListenerPort(8883)
{
AuthenticationRef = "example-authentication",
Tls = new ListenerPortTlsCertMethod(TlsCertMethodMode.Manual)
{
ManualSecretRef = "example-secret",
},
}
            })
                {
                    ServiceType = BlockerListenerServiceType.LoadBalancer,
                },
            };
            ArmOperation<IotOperationsBrokerListenerResource> lro = await iotOperationsBrokerListener.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsBrokerListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsBrokerListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BrokerListenerCreateOrUpdate()
        {
            // Generated from example definition: 2024-11-01/BrokerListener_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "BrokerListenerResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsBrokerListenerResource created on azure
            // for more information of creating IotOperationsBrokerListenerResource, please refer to the document of IotOperationsBrokerListenerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            string listenerName = "resource-name123";
            ResourceIdentifier iotOperationsBrokerListenerResourceId = IotOperationsBrokerListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName, listenerName);
            IotOperationsBrokerListenerResource iotOperationsBrokerListener = client.GetIotOperationsBrokerListenerResource(iotOperationsBrokerListenerResourceId);

            // invoke the operation
            IotOperationsBrokerListenerData data = new IotOperationsBrokerListenerData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsBrokerListenerProperties(new BrokerListenerPort[]
            {
new BrokerListenerPort(1268)
{
AuthenticationRef = "tjvdroaqqy",
AuthorizationRef = "inxhvxnwswyrvt",
NodePort = 7281,
Protocol = BrokerProtocolType.Mqtt,
Tls = new ListenerPortTlsCertMethod(TlsCertMethodMode.Automatic)
{
CertManagerCertificateSpec = new CertManagerCertificateSpec(new CertManagerIssuerRef("jtmuladdkpasfpoyvewekmiy", CertManagerIssuerKind.Issuer, "ocwoqpgucvjrsuudtjhb"))
{
Duration = "qmpeffoksron",
SecretName = "oagi",
RenewBefore = "hutno",
PrivateKey = new CertManagerPrivateKey(PrivateKeyAlgorithm.Ec256, PrivateKeyRotationPolicy.Always),
San = new SanForCert(new string[]{"xhvmhrrhgfsapocjeebqtnzarlj"}, new string[]{"zbgugfzcgsmegevzktsnibyuyp"}),
},
ManualSecretRef = "secret-name",
},
}
            })
                {
                    ServiceName = "tpfiszlapdpxktx",
                    ServiceType = BlockerListenerServiceType.ClusterIP,
                },
            };
            ArmOperation<IotOperationsBrokerListenerResource> lro = await iotOperationsBrokerListener.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsBrokerListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsBrokerListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BrokerListenerCreateOrUpdateSimple()
        {
            // Generated from example definition: 2024-11-01/BrokerListener_CreateOrUpdate_Simple.json
            // this example is just showing the usage of "BrokerListenerResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsBrokerListenerResource created on azure
            // for more information of creating IotOperationsBrokerListenerResource, please refer to the document of IotOperationsBrokerListenerResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string brokerName = "resource-name123";
            string listenerName = "resource-name123";
            ResourceIdentifier iotOperationsBrokerListenerResourceId = IotOperationsBrokerListenerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, brokerName, listenerName);
            IotOperationsBrokerListenerResource iotOperationsBrokerListener = client.GetIotOperationsBrokerListenerResource(iotOperationsBrokerListenerResourceId);

            // invoke the operation
            IotOperationsBrokerListenerData data = new IotOperationsBrokerListenerData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsBrokerListenerProperties(new BrokerListenerPort[]
            {
new BrokerListenerPort(1883)
            }),
            };
            ArmOperation<IotOperationsBrokerListenerResource> lro = await iotOperationsBrokerListener.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsBrokerListenerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsBrokerListenerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
