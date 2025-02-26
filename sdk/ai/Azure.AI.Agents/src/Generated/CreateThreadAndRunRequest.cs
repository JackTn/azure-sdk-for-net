// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> The CreateThreadAndRunRequest. </summary>
    internal partial class CreateThreadAndRunRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateThreadAndRunRequest"/>. </summary>
        /// <param name="agentId"> The ID of the agent for which the thread should be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agentId"/> is null. </exception>
        internal CreateThreadAndRunRequest(string agentId)
        {
            Argument.AssertNotNull(agentId, nameof(agentId));

            AgentId = agentId;
            OverrideTools = new ChangeTrackingList<ToolDefinition>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateThreadAndRunRequest"/>. </summary>
        /// <param name="agentId"> The ID of the agent for which the thread should be created. </param>
        /// <param name="thread"> The details used to create the new thread. If no thread is provided, an empty one will be created. </param>
        /// <param name="overrideModelName"> The overridden model that the agent should use to run the thread. </param>
        /// <param name="overrideInstructions"> The overridden system instructions the agent should use to run the thread. </param>
        /// <param name="overrideTools">
        /// The overridden list of enabled tools the agent should use to run the thread.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureAISearchToolDefinition"/>, <see cref="AzureFunctionToolDefinition"/>, <see cref="BingGroundingToolDefinition"/>, <see cref="CodeInterpreterToolDefinition"/>, <see cref="MicrosoftFabricToolDefinition"/>, <see cref="FileSearchToolDefinition"/>, <see cref="FunctionToolDefinition"/>, <see cref="OpenApiToolDefinition"/> and <see cref="SharepointToolDefinition"/>.
        /// </param>
        /// <param name="toolResources"> Override the tools the agent can use for this run. This is useful for modifying the behavior on a per-run basis. </param>
        /// <param name="stream">
        /// If `true`, returns a stream of events that happen during the Run as server-sent events,
        /// terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model
        /// considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens
        /// comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </param>
        /// <param name="maxPromptTokens">
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only
        /// the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified,
        /// the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only
        /// the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens
        /// specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="truncationStrategy"> The strategy to use for dropping messages as the context windows moves forward. </param>
        /// <param name="toolChoice"> Controls whether or not and which tool is called by the model. </param>
        /// <param name="responseFormat"> Specifies the format that the model must output. </param>
        /// <param name="parallelToolCalls"> If `true` functions will run in parallel during tool use. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateThreadAndRunRequest(string agentId, AgentThreadCreationOptions thread, string overrideModelName, string overrideInstructions, IReadOnlyList<ToolDefinition> overrideTools, UpdateToolResourcesOptions toolResources, bool? stream, float? temperature, float? topP, int? maxPromptTokens, int? maxCompletionTokens, TruncationObject truncationStrategy, BinaryData toolChoice, BinaryData responseFormat, bool? parallelToolCalls, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AgentId = agentId;
            Thread = thread;
            OverrideModelName = overrideModelName;
            OverrideInstructions = overrideInstructions;
            OverrideTools = overrideTools;
            ToolResources = toolResources;
            Stream = stream;
            Temperature = temperature;
            TopP = topP;
            MaxPromptTokens = maxPromptTokens;
            MaxCompletionTokens = maxCompletionTokens;
            TruncationStrategy = truncationStrategy;
            ToolChoice = toolChoice;
            ResponseFormat = responseFormat;
            ParallelToolCalls = parallelToolCalls;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateThreadAndRunRequest"/> for deserialization. </summary>
        internal CreateThreadAndRunRequest()
        {
        }

        /// <summary> The ID of the agent for which the thread should be created. </summary>
        public string AgentId { get; }
        /// <summary> The details used to create the new thread. If no thread is provided, an empty one will be created. </summary>
        public AgentThreadCreationOptions Thread { get; }
        /// <summary> The overridden model that the agent should use to run the thread. </summary>
        public string OverrideModelName { get; }
        /// <summary> The overridden system instructions the agent should use to run the thread. </summary>
        public string OverrideInstructions { get; }
        /// <summary>
        /// The overridden list of enabled tools the agent should use to run the thread.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureAISearchToolDefinition"/>, <see cref="AzureFunctionToolDefinition"/>, <see cref="BingGroundingToolDefinition"/>, <see cref="CodeInterpreterToolDefinition"/>, <see cref="MicrosoftFabricToolDefinition"/>, <see cref="FileSearchToolDefinition"/>, <see cref="FunctionToolDefinition"/>, <see cref="OpenApiToolDefinition"/> and <see cref="SharepointToolDefinition"/>.
        /// </summary>
        public IReadOnlyList<ToolDefinition> OverrideTools { get; }
        /// <summary> Override the tools the agent can use for this run. This is useful for modifying the behavior on a per-run basis. </summary>
        public UpdateToolResourcesOptions ToolResources { get; }
        /// <summary>
        /// If `true`, returns a stream of events that happen during the Run as server-sent events,
        /// terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </summary>
        public bool? Stream { get; }
        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        /// </summary>
        public float? Temperature { get; }
        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model
        /// considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens
        /// comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </summary>
        public float? TopP { get; }
        /// <summary>
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only
        /// the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified,
        /// the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        public int? MaxPromptTokens { get; }
        /// <summary>
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only
        /// the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens
        /// specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </summary>
        public int? MaxCompletionTokens { get; }
        /// <summary> The strategy to use for dropping messages as the context windows moves forward. </summary>
        public TruncationObject TruncationStrategy { get; }
        /// <summary>
        /// Controls whether or not and which tool is called by the model.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsApiToolChoiceOptionMode"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsNamedToolChoice"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ToolChoice { get; }
        /// <summary>
        /// Specifies the format that the model must output.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsApiResponseFormatMode"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsApiResponseFormat"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ResponseFormatJsonSchemaType"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ResponseFormat { get; }
        /// <summary> If `true` functions will run in parallel during tool use. </summary>
        public bool? ParallelToolCalls { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
