// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages.Models.Channels
{
    /// <summary> The template bindings component button for WhatsApp. </summary>
    public partial class WhatsAppMessageTemplateBindingsButton
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

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsButton"/>. </summary>
        /// <param name="subType"> The WhatsApp button sub type. </param>
        /// <param name="refValue"> The name of the referenced item in the template values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subType"/> or <paramref name="refValue"/> is null. </exception>
        public WhatsAppMessageTemplateBindingsButton(string subType, string refValue)
        {
            Argument.AssertNotNull(subType, nameof(subType));
            Argument.AssertNotNull(refValue, nameof(refValue));

            SubType = subType;
            RefValue = refValue;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsButton"/>. </summary>
        /// <param name="subType"> The WhatsApp button sub type. </param>
        /// <param name="refValue"> The name of the referenced item in the template values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WhatsAppMessageTemplateBindingsButton(string subType, string refValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubType = subType;
            RefValue = refValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindingsButton"/> for deserialization. </summary>
        internal WhatsAppMessageTemplateBindingsButton()
        {
        }
        /// <summary> The name of the referenced item in the template values. </summary>
        public string RefValue { get; set; }
    }
}
