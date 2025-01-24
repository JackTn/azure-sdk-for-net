// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents an utterance of an orchestration project. </summary>
    public partial class OrchestrationExportedUtterance
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

        /// <summary> Initializes a new instance of <see cref="OrchestrationExportedUtterance"/>. </summary>
        /// <param name="text"> The utterance text. </param>
        /// <param name="intent"> The intent of the utterance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="intent"/> is null. </exception>
        public OrchestrationExportedUtterance(string text, string intent)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(intent, nameof(intent));

            Text = text;
            Intent = intent;
        }

        /// <summary> Initializes a new instance of <see cref="OrchestrationExportedUtterance"/>. </summary>
        /// <param name="text"> The utterance text. </param>
        /// <param name="language"> Represents the utterance's language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="intent"> The intent of the utterance. </param>
        /// <param name="dataset"> The dataset for this utterance. Allowed values are 'Train' and 'Test'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrchestrationExportedUtterance(string text, string language, string intent, string dataset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Language = language;
            Intent = intent;
            Dataset = dataset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OrchestrationExportedUtterance"/> for deserialization. </summary>
        internal OrchestrationExportedUtterance()
        {
        }

        /// <summary> The utterance text. </summary>
        public string Text { get; }
        /// <summary> Represents the utterance's language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </summary>
        public string Language { get; set; }
        /// <summary> The intent of the utterance. </summary>
        public string Intent { get; }
        /// <summary> The dataset for this utterance. Allowed values are 'Train' and 'Test'. </summary>
        public string Dataset { get; set; }
    }
}
