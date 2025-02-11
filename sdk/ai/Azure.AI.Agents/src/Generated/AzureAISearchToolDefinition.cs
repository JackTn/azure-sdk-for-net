// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> The input definition information for an Azure AI search tool as used to configure an agent. </summary>
    public partial class AzureAISearchToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="AzureAISearchToolDefinition"/>. </summary>
        public AzureAISearchToolDefinition()
        {
            Type = "azure_ai_search";
        }

        /// <summary> Initializes a new instance of <see cref="AzureAISearchToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureAISearchToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
