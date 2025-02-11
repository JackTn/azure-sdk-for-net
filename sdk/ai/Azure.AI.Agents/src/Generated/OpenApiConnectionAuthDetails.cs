// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents
{
    /// <summary> Security details for OpenApi connection authentication. </summary>
    public partial class OpenApiConnectionAuthDetails : OpenApiAuthDetails
    {
        /// <summary> Initializes a new instance of <see cref="OpenApiConnectionAuthDetails"/>. </summary>
        /// <param name="securityScheme"> Connection auth security details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityScheme"/> is null. </exception>
        public OpenApiConnectionAuthDetails(OpenApiConnectionSecurityScheme securityScheme)
        {
            Argument.AssertNotNull(securityScheme, nameof(securityScheme));

            Type = OpenApiAuthType.Connection;
            SecurityScheme = securityScheme;
        }

        /// <summary> Initializes a new instance of <see cref="OpenApiConnectionAuthDetails"/>. </summary>
        /// <param name="type"> The type of authentication, must be anonymous/connection/managed_identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="securityScheme"> Connection auth security details. </param>
        internal OpenApiConnectionAuthDetails(OpenApiAuthType type, IDictionary<string, BinaryData> serializedAdditionalRawData, OpenApiConnectionSecurityScheme securityScheme) : base(type, serializedAdditionalRawData)
        {
            SecurityScheme = securityScheme;
        }

        /// <summary> Initializes a new instance of <see cref="OpenApiConnectionAuthDetails"/> for deserialization. </summary>
        internal OpenApiConnectionAuthDetails()
        {
        }

        /// <summary> Connection auth security details. </summary>
        public OpenApiConnectionSecurityScheme SecurityScheme { get; set; }
    }
}
