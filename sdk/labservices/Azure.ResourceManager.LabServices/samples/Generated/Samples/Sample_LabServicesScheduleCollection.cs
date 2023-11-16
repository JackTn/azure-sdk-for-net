// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.LabServices;
using Azure.ResourceManager.LabServices.Models;

namespace Azure.ResourceManager.LabServices.Samples
{
    public partial class Sample_LabServicesScheduleCollection
    {
        // getListSchedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetListSchedule()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Schedules/listSchedule.json
            // this example is just showing the usage of "Schedules_ListByLab" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabResource created on azure
            // for more information of creating LabResource, please refer to the document of LabResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            ResourceIdentifier labResourceId = LabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            LabResource lab = client.GetLabResource(labResourceId);

            // get the collection of this LabServicesScheduleResource
            LabServicesScheduleCollection collection = lab.GetLabServicesSchedules();

            // invoke the operation and iterate over the result
            await foreach (LabServicesScheduleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LabServicesScheduleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // getSchedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSchedule()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Schedules/getSchedule.json
            // this example is just showing the usage of "Schedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabResource created on azure
            // for more information of creating LabResource, please refer to the document of LabResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            ResourceIdentifier labResourceId = LabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            LabResource lab = client.GetLabResource(labResourceId);

            // get the collection of this LabServicesScheduleResource
            LabServicesScheduleCollection collection = lab.GetLabServicesSchedules();

            // invoke the operation
            string scheduleName = "schedule1";
            LabServicesScheduleResource result = await collection.GetAsync(scheduleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LabServicesScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // getSchedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSchedule()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Schedules/getSchedule.json
            // this example is just showing the usage of "Schedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabResource created on azure
            // for more information of creating LabResource, please refer to the document of LabResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            ResourceIdentifier labResourceId = LabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            LabResource lab = client.GetLabResource(labResourceId);

            // get the collection of this LabServicesScheduleResource
            LabServicesScheduleCollection collection = lab.GetLabServicesSchedules();

            // invoke the operation
            string scheduleName = "schedule1";
            bool result = await collection.ExistsAsync(scheduleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // getSchedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetSchedule()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Schedules/getSchedule.json
            // this example is just showing the usage of "Schedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabResource created on azure
            // for more information of creating LabResource, please refer to the document of LabResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            ResourceIdentifier labResourceId = LabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            LabResource lab = client.GetLabResource(labResourceId);

            // get the collection of this LabServicesScheduleResource
            LabServicesScheduleCollection collection = lab.GetLabServicesSchedules();

            // invoke the operation
            string scheduleName = "schedule1";
            NullableResponse<LabServicesScheduleResource> response = await collection.GetIfExistsAsync(scheduleName);
            LabServicesScheduleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LabServicesScheduleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // putSchedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutSchedule()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/Schedules/putSchedule.json
            // this example is just showing the usage of "Schedules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabResource created on azure
            // for more information of creating LabResource, please refer to the document of LabResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            ResourceIdentifier labResourceId = LabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            LabResource lab = client.GetLabResource(labResourceId);

            // get the collection of this LabServicesScheduleResource
            LabServicesScheduleCollection collection = lab.GetLabServicesSchedules();

            // invoke the operation
            string scheduleName = "schedule1";
            LabServicesScheduleData data = new LabServicesScheduleData()
            {
                StartOn = DateTimeOffset.Parse("2020-05-26T12:00:00Z"),
                StopOn = DateTimeOffset.Parse("2020-05-26T18:00:00Z"),
                RecurrencePattern = new LabServicesRecurrencePattern(LabServicesRecurrenceFrequency.Daily, DateTimeOffset.Parse("2020-08-14T23:59:59Z"))
                {
                    Interval = 2,
                },
                TimeZoneId = "America/Los_Angeles",
                Notes = BinaryData.FromString("\"Schedule 1 for students\""),
            };
            ArmOperation<LabServicesScheduleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scheduleName, data);
            LabServicesScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LabServicesScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
