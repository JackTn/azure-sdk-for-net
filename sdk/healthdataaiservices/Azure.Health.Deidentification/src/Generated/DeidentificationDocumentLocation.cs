// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> Location of a document. </summary>
    public partial class DeidentificationDocumentLocation
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

        /// <summary> Initializes a new instance of <see cref="DeidentificationDocumentLocation"/>. </summary>
        /// <param name="location"> Location of document in storage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal DeidentificationDocumentLocation(Uri location)
        {
            Argument.AssertNotNull(location, nameof(location));

            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="DeidentificationDocumentLocation"/>. </summary>
        /// <param name="location"> Location of document in storage. </param>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeidentificationDocumentLocation(Uri location, ETag etag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Etag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeidentificationDocumentLocation"/> for deserialization. </summary>
        internal DeidentificationDocumentLocation()
        {
        }

        /// <summary> Location of document in storage. </summary>
        public Uri Location { get; }
        /// <summary> The entity tag for this resource. </summary>
        public ETag Etag { get; }
    }
}
