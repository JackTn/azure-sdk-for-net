// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Inference
{
    /// <summary> The EmbedRequest1. </summary>
    internal partial class EmbedRequest1
    {
        /// <summary> Initializes a new instance of <see cref="EmbedRequest1"/>. </summary>
        /// <param name="input">
        /// Input image to embed. To embed multiple inputs in a single request, pass an array.
        /// The input must not exceed the max input tokens for the model.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        internal EmbedRequest1(IEnumerable<ImageEmbeddingInput> input)
        {
            Argument.AssertNotNull(input, nameof(input));

            Input = input.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="EmbedRequest1"/>. </summary>
        /// <param name="input">
        /// Input image to embed. To embed multiple inputs in a single request, pass an array.
        /// The input must not exceed the max input tokens for the model.
        /// </param>
        /// <param name="dimensions">
        /// Optional. The number of dimensions the resulting output embeddings should have.
        /// Passing null causes the model to use its default value.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </param>
        /// <param name="encodingFormat">
        /// Optional. The number of dimensions the resulting output embeddings should have.
        /// Passing null causes the model to use its default value.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </param>
        /// <param name="inputType">
        /// Optional. The type of the input.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </param>
        /// <param name="model"> ID of the specific AI model to use, if more than one model is available on the endpoint. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal EmbedRequest1(IReadOnlyList<ImageEmbeddingInput> input, int? dimensions, EmbeddingEncodingFormat? encodingFormat, EmbeddingInputType? inputType, string model, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            Input = input;
            Dimensions = dimensions;
            EncodingFormat = encodingFormat;
            InputType = inputType;
            Model = model;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="EmbedRequest1"/> for deserialization. </summary>
        internal EmbedRequest1()
        {
        }

        /// <summary>
        /// Input image to embed. To embed multiple inputs in a single request, pass an array.
        /// The input must not exceed the max input tokens for the model.
        /// </summary>
        public IReadOnlyList<ImageEmbeddingInput> Input { get; }
        /// <summary>
        /// Optional. The number of dimensions the resulting output embeddings should have.
        /// Passing null causes the model to use its default value.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </summary>
        public int? Dimensions { get; }
        /// <summary>
        /// Optional. The number of dimensions the resulting output embeddings should have.
        /// Passing null causes the model to use its default value.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </summary>
        public EmbeddingEncodingFormat? EncodingFormat { get; }
        /// <summary>
        /// Optional. The type of the input.
        /// Returns a 422 error if the model doesn't support the value or parameter.
        /// </summary>
        public EmbeddingInputType? InputType { get; }
        /// <summary> ID of the specific AI model to use, if more than one model is available on the endpoint. </summary>
        public string Model { get; }
        /// <summary>
        /// Additional Properties
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
