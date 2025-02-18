// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Projects
{
    internal static partial class AuthenticationTypeExtensions
    {
        public static string ToSerialString(this AuthenticationType value) => value switch
        {
            AuthenticationType.ApiKey => "ApiKey",
            AuthenticationType.EntraId => "AAD",
            AuthenticationType.SAS => "SAS",
            AuthenticationType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthenticationType value.")
        };

        public static AuthenticationType ToAuthenticationType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ApiKey")) return AuthenticationType.ApiKey;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AAD")) return AuthenticationType.EntraId;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SAS")) return AuthenticationType.SAS;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return AuthenticationType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthenticationType value.");
        }
    }
}
