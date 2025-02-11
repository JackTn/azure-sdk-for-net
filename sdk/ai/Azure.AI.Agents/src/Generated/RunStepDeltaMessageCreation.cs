// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> Represents a message creation within a streaming run step delta. </summary>
    public partial class RunStepDeltaMessageCreation : RunStepDeltaDetail
    {
        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMessageCreation"/>. </summary>
        internal RunStepDeltaMessageCreation()
        {
            Type = "message_creation";
        }

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMessageCreation"/>. </summary>
        /// <param name="type"> The object type for the run step detail object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="messageCreation"> The message creation data. </param>
        internal RunStepDeltaMessageCreation(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, RunStepDeltaMessageCreationObject messageCreation) : base(type, serializedAdditionalRawData)
        {
            MessageCreation = messageCreation;
        }

        /// <summary> The message creation data. </summary>
        public RunStepDeltaMessageCreationObject MessageCreation { get; }
    }
}
