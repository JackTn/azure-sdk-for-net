// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Unknown version of ExportedOrchestrationDetails. </summary>
    internal partial class UnknownExportedOrchestrationDetails : ExportedOrchestrationDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownExportedOrchestrationDetails"/>. </summary>
        /// <param name="targetProjectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownExportedOrchestrationDetails(OrchestrationTargetProjectKind targetProjectKind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(targetProjectKind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownExportedOrchestrationDetails"/> for deserialization. </summary>
        internal UnknownExportedOrchestrationDetails()
        {
        }
    }
}
