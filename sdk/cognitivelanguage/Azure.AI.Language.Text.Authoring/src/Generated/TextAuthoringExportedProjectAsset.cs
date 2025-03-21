// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary>
    /// Represents the assets of an exported project.
    /// Please note <see cref="TextAuthoringExportedProjectAsset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ExportedCustomAbstractiveSummarizationProjectAsset"/>, <see cref="ExportedCustomEntityRecognitionProjectAsset"/>, <see cref="ExportedCustomHealthcareProjectAsset"/>, <see cref="ExportedCustomMultiLabelClassificationProjectAsset"/>, <see cref="ExportedCustomSingleLabelClassificationProjectAsset"/> and <see cref="CustomTextSentimentProjectAssets"/>.
    /// </summary>
    public abstract partial class TextAuthoringExportedProjectAsset
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TextAuthoringExportedProjectAsset"/>. </summary>
        protected TextAuthoringExportedProjectAsset()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringExportedProjectAsset"/>. </summary>
        /// <param name="projectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAuthoringExportedProjectAsset(TextAuthoringProjectKind projectKind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProjectKind = projectKind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the project kind. </summary>
        internal TextAuthoringProjectKind ProjectKind { get; set; }
    }
}
