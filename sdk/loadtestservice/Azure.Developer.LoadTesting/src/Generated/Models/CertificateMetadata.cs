// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Certificates metadata. </summary>
    public partial class CertificateMetadata
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

        /// <summary> Initializes a new instance of <see cref="CertificateMetadata"/>. </summary>
        public CertificateMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CertificateMetadata"/>. </summary>
        /// <param name="value"> The value of the certificate for respective type. </param>
        /// <param name="certificateKind"> Type of certificate. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CertificateMetadata(string value, CertificateType? certificateKind, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            CertificateKind = certificateKind;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The value of the certificate for respective type. </summary>
        public string Value { get; set; }
        /// <summary> Type of certificate. </summary>
        public CertificateType? CertificateKind { get; set; }
        /// <summary> Name of the certificate. </summary>
        public string Name { get; set; }
    }
}
