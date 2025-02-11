// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> Represents a streamed file citation applied to a streaming text content part. </summary>
    public partial class MessageDeltaTextFileCitationAnnotation : MessageDeltaTextAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextFileCitationAnnotation"/>. </summary>
        /// <param name="index"> The index of the annotation within a text content part. </param>
        internal MessageDeltaTextFileCitationAnnotation(int index) : base(index)
        {
            Type = "file_citation";
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextFileCitationAnnotation"/>. </summary>
        /// <param name="index"> The index of the annotation within a text content part. </param>
        /// <param name="type"> The type of the text content annotation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="fileCitation"> The file citation information. </param>
        /// <param name="text"> The text in the message content that needs to be replaced. </param>
        /// <param name="startIndex"> The start index of this annotation in the content text. </param>
        /// <param name="endIndex"> The end index of this annotation in the content text. </param>
        internal MessageDeltaTextFileCitationAnnotation(int index, string type, IDictionary<string, BinaryData> serializedAdditionalRawData, MessageDeltaTextFileCitationAnnotationObject fileCitation, string text, int? startIndex, int? endIndex) : base(index, type, serializedAdditionalRawData)
        {
            FileCitation = fileCitation;
            Text = text;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextFileCitationAnnotation"/> for deserialization. </summary>
        internal MessageDeltaTextFileCitationAnnotation()
        {
        }

        /// <summary> The file citation information. </summary>
        public MessageDeltaTextFileCitationAnnotationObject FileCitation { get; }
        /// <summary> The text in the message content that needs to be replaced. </summary>
        public string Text { get; }
        /// <summary> The start index of this annotation in the content text. </summary>
        public int? StartIndex { get; }
        /// <summary> The end index of this annotation in the content text. </summary>
        public int? EndIndex { get; }
    }
}
