// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> An image reference emitted by a code interpreter tool in response to a tool call by the model. </summary>
    public partial class RunStepCodeInterpreterImageReference
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

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageReference"/>. </summary>
        /// <param name="fileId"> The ID of the file associated with this image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        internal RunStepCodeInterpreterImageReference(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageReference"/>. </summary>
        /// <param name="fileId"> The ID of the file associated with this image. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunStepCodeInterpreterImageReference(string fileId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageReference"/> for deserialization. </summary>
        internal RunStepCodeInterpreterImageReference()
        {
        }

        /// <summary> The ID of the file associated with this image. </summary>
        public string FileId { get; }
    }
}
