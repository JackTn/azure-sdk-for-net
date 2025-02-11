// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> Result of the get conversation messages AI Analysis operation. </summary>
    public partial class GetConversationMessagesAnalysisResult
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

        /// <summary> Initializes a new instance of <see cref="GetConversationMessagesAnalysisResult"/>. </summary>
        /// <param name="summary"> The AI summary of the conversation messages. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="summary"/> is null. </exception>
        internal GetConversationMessagesAnalysisResult(string summary)
        {
            Argument.AssertNotNull(summary, nameof(summary));

            Summary = summary;
        }

        /// <summary> Initializes a new instance of <see cref="GetConversationMessagesAnalysisResult"/>. </summary>
        /// <param name="summary"> The AI summary of the conversation messages. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetConversationMessagesAnalysisResult(string summary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Summary = summary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetConversationMessagesAnalysisResult"/> for deserialization. </summary>
        internal GetConversationMessagesAnalysisResult()
        {
        }

        /// <summary> The AI summary of the conversation messages. </summary>
        public string Summary { get; }
    }
}
