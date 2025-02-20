// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> The CreateConversationRequest. </summary>
    internal partial class CreateConversationRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateConversationRequest"/>. </summary>
        /// <param name="conversation"> The conversation details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversation"/> is null. </exception>
        internal CreateConversationRequest(CommunicationConversation conversation)
        {
            Argument.AssertNotNull(conversation, nameof(conversation));

            Conversation = conversation;
        }

        /// <summary> Initializes a new instance of <see cref="CreateConversationRequest"/>. </summary>
        /// <param name="conversation"> The conversation details. </param>
        /// <param name="initialMessage"> An intial message within the conversation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateConversationRequest(CommunicationConversation conversation, ConversationMessage initialMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conversation = conversation;
            InitialMessage = initialMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateConversationRequest"/> for deserialization. </summary>
        internal CreateConversationRequest()
        {
        }

        /// <summary> The conversation details. </summary>
        public CommunicationConversation Conversation { get; }
        /// <summary> An intial message within the conversation. </summary>
        public ConversationMessage InitialMessage { get; }
    }
}
