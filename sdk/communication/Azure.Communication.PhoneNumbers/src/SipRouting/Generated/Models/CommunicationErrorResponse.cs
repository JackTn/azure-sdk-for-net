// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.PhoneNumbers.SipRouting;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The Communication Services error. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"> The Communication Services error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal CommunicationErrorResponse(SipRouting.CommunicationError error)
        {
            SipRouting.Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }
    }
}
