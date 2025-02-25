// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceNetworking.Models
{
    /// <summary> The type used for update operations of the Association. </summary>
    [Obsolete("This class is now deprecated. Please use the new class `TrafficControllerAssociationPatch` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class AssociationPatch
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

        /// <summary> Initializes a new instance of <see cref="AssociationPatch"/>. </summary>
        public AssociationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AssociationPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="associationType"> Association Type. </param>
        /// <param name="subnet"> Association Subnet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssociationPatch(IDictionary<string, string> tags, AssociationType? associationType, WritableSubResource subnet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            AssociationType = associationType;
            Subnet = subnet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal AssociationPatch(TrafficControllerAssociationPatch patch)
        {
            Tags = patch.Tags;
            AssociationType = patch.AssociationType.ToString();
            Subnet = new WritableSubResource() { Id = patch.SubnetId };
            _serializedAdditionalRawData = null;
        }

        internal TrafficControllerAssociationPatch ToTrafficControllerAssociationPatch()
        {
            // The subnet code is incorrect, issue https://github.com/Azure/autorest.csharp/issues/5243 opened to track this
            return new TrafficControllerAssociationPatch(Tags, AssociationType.ToString(), new SubResource(), _serializedAdditionalRawData);
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Association Type. </summary>
        public AssociationType? AssociationType { get; set; }
        /// <summary> Association Subnet. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }
    }
}
