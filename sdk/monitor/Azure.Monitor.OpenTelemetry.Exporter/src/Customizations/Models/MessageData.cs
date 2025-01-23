﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter.Internals;

using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MessageData
    {
        public MessageData(int version, LogRecord logRecord, ChangeTrackingDictionary<string, string> properties, string? message) : base(version)
        {
            Properties = properties;
            Measurements = new ChangeTrackingDictionary<string, double>();
            //Message = LogsHelper.GetMessageAndSetProperties(logRecord, Properties).Truncate(SchemaConstants.MessageData_Message_MaxLength);
            Message = message;
#pragma warning disable CS0618 // Type or member is obsolete
            // TODO: Remove warning disable with next Stable release.
            SeverityLevel = LogsHelper.GetSeverityLevel(logRecord.LogLevel); // TODO: CHANGE THIS.
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
