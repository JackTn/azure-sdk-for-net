// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> Unknown version of ConversationMessageContent. </summary>
    internal partial class UnknownConversationMessageContent : ConversationMessageContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConversationMessageContent"/>. </summary>
        /// <param name="kind"> The type discriminator describing a message type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownConversationMessageContent(CommunicationMessageKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownConversationMessageContent"/> for deserialization. </summary>
        internal UnknownConversationMessageContent()
        {
        }
    }
}
