// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> A Index resource. </summary>
    public partial class IndexResource
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

        /// <summary> Initializes a new instance of <see cref="IndexResource"/>. </summary>
        /// <param name="indexConnectionId"> An index connection id in an IndexResource attached to this agent. </param>
        /// <param name="indexName"> The name of an index in an IndexResource attached to this agent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexConnectionId"/> or <paramref name="indexName"/> is null. </exception>
        public IndexResource(string indexConnectionId, string indexName)
        {
            Argument.AssertNotNull(indexConnectionId, nameof(indexConnectionId));
            Argument.AssertNotNull(indexName, nameof(indexName));

            IndexConnectionId = indexConnectionId;
            IndexName = indexName;
        }

        /// <summary> Initializes a new instance of <see cref="IndexResource"/>. </summary>
        /// <param name="indexConnectionId"> An index connection id in an IndexResource attached to this agent. </param>
        /// <param name="indexName"> The name of an index in an IndexResource attached to this agent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IndexResource(string indexConnectionId, string indexName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IndexConnectionId = indexConnectionId;
            IndexName = indexName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IndexResource"/> for deserialization. </summary>
        internal IndexResource()
        {
        }

        /// <summary> An index connection id in an IndexResource attached to this agent. </summary>
        public string IndexConnectionId { get; set; }
        /// <summary> The name of an index in an IndexResource attached to this agent. </summary>
        public string IndexName { get; set; }
    }
}
