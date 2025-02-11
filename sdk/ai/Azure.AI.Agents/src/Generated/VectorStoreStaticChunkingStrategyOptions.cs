// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> Options to configure a vector store static chunking strategy. </summary>
    public partial class VectorStoreStaticChunkingStrategyOptions
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

        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyOptions"/>. </summary>
        /// <param name="maxChunkSizeTokens"> The maximum number of tokens in each chunk. The default value is 800. The minimum value is 100 and the maximum value is 4096. </param>
        /// <param name="chunkOverlapTokens">
        /// The number of tokens that overlap between chunks. The default value is 400.
        /// Note that the overlap must not exceed half of max_chunk_size_tokens.
        /// </param>
        public VectorStoreStaticChunkingStrategyOptions(int maxChunkSizeTokens, int chunkOverlapTokens)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyOptions"/>. </summary>
        /// <param name="maxChunkSizeTokens"> The maximum number of tokens in each chunk. The default value is 800. The minimum value is 100 and the maximum value is 4096. </param>
        /// <param name="chunkOverlapTokens">
        /// The number of tokens that overlap between chunks. The default value is 400.
        /// Note that the overlap must not exceed half of max_chunk_size_tokens.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStoreStaticChunkingStrategyOptions(int maxChunkSizeTokens, int chunkOverlapTokens, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyOptions"/> for deserialization. </summary>
        internal VectorStoreStaticChunkingStrategyOptions()
        {
        }

        /// <summary> The maximum number of tokens in each chunk. The default value is 800. The minimum value is 100 and the maximum value is 4096. </summary>
        public int MaxChunkSizeTokens { get; set; }
        /// <summary>
        /// The number of tokens that overlap between chunks. The default value is 400.
        /// Note that the overlap must not exceed half of max_chunk_size_tokens.
        /// </summary>
        public int ChunkOverlapTokens { get; set; }
    }
}
