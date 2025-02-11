// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> A request to send a template notification. </summary>
    public partial class TemplateNotificationContent : NotificationContent
    {
        /// <summary> Initializes a new instance of <see cref="TemplateNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="template"> The template object used to create templates. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="template"/> is null. </exception>
        public TemplateNotificationContent(Guid channelRegistrationId, IEnumerable<string> to, MessageTemplate template) : base(channelRegistrationId, to)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(template, nameof(template));

            Kind = CommunicationMessageKind.Template;
            Template = template;
        }

        /// <summary> Initializes a new instance of <see cref="TemplateNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="kind"> The type discriminator describing a message type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="template"> The template object used to create templates. </param>
        internal TemplateNotificationContent(Guid channelRegistrationId, IList<string> to, CommunicationMessageKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, MessageTemplate template) : base(channelRegistrationId, to, kind, serializedAdditionalRawData)
        {
            Template = template;
        }

        /// <summary> Initializes a new instance of <see cref="TemplateNotificationContent"/> for deserialization. </summary>
        internal TemplateNotificationContent()
        {
        }

        /// <summary> The template object used to create templates. </summary>
        public MessageTemplate Template { get; }
    }
}
