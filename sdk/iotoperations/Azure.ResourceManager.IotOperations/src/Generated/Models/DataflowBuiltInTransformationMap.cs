// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Dataflow BuiltIn Transformation map properties. </summary>
    public partial class DataflowBuiltInTransformationMap
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

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationMap"/>. </summary>
        /// <param name="inputs"> List of fields for mapping in JSON path expression. </param>
        /// <param name="output"> Where and how the input fields to be organized in the output record. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="output"/> is null. </exception>
        public DataflowBuiltInTransformationMap(IEnumerable<string> inputs, string output)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(output, nameof(output));

            Inputs = inputs.ToList();
            Output = output;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationMap"/>. </summary>
        /// <param name="type"> Type of transformation. </param>
        /// <param name="description"> A user provided optional description of the mapping function. </param>
        /// <param name="inputs"> List of fields for mapping in JSON path expression. </param>
        /// <param name="expression"> Modify the inputs field(s) to the final output field. Example: $1 * 2.2 (Assuming inputs section $1 is provided). </param>
        /// <param name="output"> Where and how the input fields to be organized in the output record. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowBuiltInTransformationMap(DataflowMappingType? type, string description, IList<string> inputs, string expression, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Description = description;
            Inputs = inputs;
            Expression = expression;
            Output = output;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationMap"/> for deserialization. </summary>
        internal DataflowBuiltInTransformationMap()
        {
        }

        /// <summary> Type of transformation. </summary>
        public DataflowMappingType? Type { get; set; }
        /// <summary> A user provided optional description of the mapping function. </summary>
        public string Description { get; set; }
        /// <summary> List of fields for mapping in JSON path expression. </summary>
        public IList<string> Inputs { get; }
        /// <summary> Modify the inputs field(s) to the final output field. Example: $1 * 2.2 (Assuming inputs section $1 is provided). </summary>
        public string Expression { get; set; }
        /// <summary> Where and how the input fields to be organized in the output record. </summary>
        public string Output { get; set; }
    }
}
