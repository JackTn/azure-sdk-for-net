// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.Language.Text.Authoring;
using Azure.AI.Language.Text.Authoring.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;
#region Snippet:TextAuthoring_Identity_Namespace
using Azure.Identity;
using Azure.Core;
#endregion

namespace Azure.AI.Language.Text.Authoring.Tests.Samples
{
    public partial class CreateClient : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        public void CreateAuthoringClientForSpecificApiVersion()
        {
            #region Snippet:CreateTextAuthoringClientForSpecificApiVersion
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
            AzureKeyCredential credential = new("your apikey");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
            credential = new(TestEnvironment.ApiKey);
#endif
            AuthoringClientOptions options = new AuthoringClientOptions(AuthoringClientOptions.ServiceVersion.V2024_11_15_Preview);
            AuthoringClient client = new AuthoringClient(endpoint, credential, options);
            TextAnalysisAuthoring authoringClient = client.GetTextAnalysisAuthoringClient();
            #endregion
        }

        [Test]
        public void AuthoringClient_CreateWithDefaultAzureCredential()
        {
            #region Snippet:TextAnalysisAuthoring_CreateWithDefaultAzureCredential
            Uri endpoint = new Uri("https://myaccount.cognitiveservices.azure.com");
#if !SNIPPET
            endpoint = TestEnvironment.Endpoint;
#endif
            DefaultAzureCredential credential = new DefaultAzureCredential();
            AuthoringClient client = new AuthoringClient(endpoint, credential);
            TextAnalysisAuthoring authoringClient = client.GetTextAnalysisAuthoringClient();
            #endregion
        }

        [Test]
        public void BadArgument()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
            AuthoringClient client = new AuthoringClient(endpoint, credential);
            TextAnalysisAuthoring authoringClient = client.GetTextAnalysisAuthoringClient();

            #region Snippet:TextAuthoringClient_BadRequest
            try
            {
                string invalidProjectName = "InvalidProject";

                var projectData = new
                {
                    projectName = invalidProjectName,
                    language = "invalid-lang", // Invalid language code
                    projectKind = "Text",
                    description = "This is a test for invalid configuration."
                };

                using RequestContent content = RequestContent.Create(projectData);
                Response response = authoringClient.CreateProject(invalidProjectName, content);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
