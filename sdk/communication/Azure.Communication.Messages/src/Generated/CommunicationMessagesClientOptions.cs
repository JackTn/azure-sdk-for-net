// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> Client options for Azure.Communication.Messages library clients. </summary>
    public partial class CommunicationMessagesClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2025_01_15_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2024-02-01". </summary>
            V2024_02_01 = 1,
            /// <summary> Service version "2024-08-30". </summary>
            V2024_08_30 = 2,
            /// <summary> Service version "2025-01-15-preview". </summary>
            V2025_01_15_Preview = 3,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of CommunicationMessagesClientOptions. </summary>
        public CommunicationMessagesClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2024_02_01 => "2024-02-01",
                ServiceVersion.V2024_08_30 => "2024-08-30",
                ServiceVersion.V2025_01_15_Preview => "2025-01-15-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
