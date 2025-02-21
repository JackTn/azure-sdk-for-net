﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Monitor.OpenTelemetry.Exporter.Models;
using Azure.Monitor.OpenTelemetry.Exporter.Tests.CommonTestFramework;
using Microsoft.Extensions.Logging;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Resources;
using Xunit;
using Xunit.Abstractions;

namespace Azure.Monitor.OpenTelemetry.Exporter.Tests.E2ETelemetryItemValidation
{
#if !NET6_0
    /// <summary>
    /// The purpose of these tests is to validate the <see cref="TelemetryItem"/> that is created
    /// based on interacting with <see cref="LoggerFactory"/> and <see cref="Logger"/>.
    /// </summary>
    public class CustomEventsTests
    {
        // TODO: WHAT IF A USER SUPPLIES CUSTOMEVENT ATTRIBUTE IN BOTH MESSAGE TEMPLATE/PROPERTIES AND SCOPE?

        internal readonly TelemetryItemOutputHelper telemetryOutput;

        internal readonly Dictionary<string, object> testResourceAttributes = new()
        {
            { "service.instance.id", "testInstance" },
            { "service.name", "testName" },
            { "service.namespace", "testNamespace" },
            { "service.version", "testVersion" },
        };

        public CustomEventsTests(ITestOutputHelper output)
        {
            this.telemetryOutput = new TelemetryItemOutputHelper(output);
        }

        [Fact]
        public void VerifyExceptionTakesPrecence()
        {
            // This test confirms that if an exception is present in a LogRecord that contains the "customevent" attribute then only an exception will be exported.

            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter<OpenTelemetryLoggerProvider>(logCategoryName, LogLevel.Information)
                    .AddOpenTelemetry(options =>
                    {
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            try
            {
                throw new Exception("Test Exception");
            }
            catch (Exception ex)
            {
                logger.Log(
                    logLevel: LogLevel.Information,
                    eventId: 1,
                    exception: ex,
                    message: "Hello {name} {microsoft.custom_event.name}.",
                    args: new object[] { "World", "MyCustomEventName" });
            }

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems!.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);

            Assert.Single(telemetryItems!.Where(x => x.Name == "Exception"));
            Assert.DoesNotContain(telemetryItems!, x => x.Name == "Event");
        }

        [Fact]
        public void VerifyCustomEventViaLogMethod()
        {
            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter<OpenTelemetryLoggerProvider>(logCategoryName, LogLevel.Information)
                    .AddOpenTelemetry(options =>
                    {
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);
            logger.LogInformation("{microsoft.custom_event.name}", "MyCustomEventName");

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);
            var telemetryItem = telemetryItems?.Where(x => x.Name == "Event").Single();

            TelemetryItemValidationHelper.AssertCustomEventTelemetry(
                telemetryItem: telemetryItem!,
                expectedName: "MyCustomEventName",
                expectedProperties: new Dictionary<string, string>(),
                expectedSpanId: null,
                expectedTraceId: null);
        }

        [Fact]
        public void VerifyCustomEventViaLogMethodWithScopes()
        {
            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter<OpenTelemetryLoggerProvider>(logCategoryName, LogLevel.Information)
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            List<KeyValuePair<string, object>> scope1 = new()
            {
                new("scopeKey1", "scopeValue1"),
                new("scopeKey2", "scopeValue2")
            };

            List<KeyValuePair<string, object>> scope2 = new()
            {
                new("microsoft.custom_event.name", "MyCustomEventName")
            };

            using (logger.BeginScope(scope1))
            using (logger.BeginScope(scope2))
            {
                logger.Log(
                    logLevel: LogLevel.Information,
                    eventId: 1,
                    exception: null,
                    message: "Hello {name}.",
                    args: new object[] { "World" });
            }

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);

            Assert.Single(telemetryItems!.Where(x => x.Name == "Message"));
            Assert.DoesNotContain(telemetryItems!, x => x.Name == "Event");

            var telemetryItem = telemetryItems?.Where(x => x.Name == "Message").Single();
            var messageData = (MessageData)telemetryItem!.Data.BaseData;

            Assert.True(messageData.Properties.ContainsKey("microsoft.custom_event.name"));
        }

        [Fact]
        public void VerifyCustomEventViaSourceGenerated()
        {
            // This method is testing Compile-time logging source generation.
            // https://learn.microsoft.com/dotnet/core/extensions/logger-message-generator

            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            logger.WriteCustomEvent("MyCustomEventName");

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);
            var telemetryItem = telemetryItems?.Where(x => x.Name == "Event").Single();

            TelemetryItemValidationHelper.AssertCustomEventTelemetry(
                telemetryItem: telemetryItem!,
                expectedName: "MyCustomEventName",
                expectedProperties: new Dictionary<string, string> (),
                expectedSpanId: null,
                expectedTraceId: null);
        }

        [Fact]
        public void VerifyCustomEventViaSourceGeneratedAndScopeAttribute()
        {
            // This method is testing Compile-time logging source generation.
            // https://learn.microsoft.com/dotnet/core/extensions/logger-message-generator

            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            List<KeyValuePair<string, object>> customEventScope = new()
            {
                new("microsoft.custom_event.name", "MyCustomEventName")
            };

            using (logger.BeginScope(customEventScope))
            {
                logger.WriteLog("value1");
            }

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);

            Assert.Single(telemetryItems!.Where(x => x.Name == "Message"));
            Assert.DoesNotContain(telemetryItems!, x => x.Name == "Event");

            var telemetryItem = telemetryItems?.Where(x => x.Name == "Message").Single();
            var messageData = (MessageData)telemetryItem!.Data.BaseData;

            Assert.True(messageData.Properties.ContainsKey("microsoft.custom_event.name"));
        }

        [Fact]
        public void VerifyCustomEventViaSourceGeneratedWithScope()
        {
            // This method is testing Compile-time logging source generation.
            // https://learn.microsoft.com/dotnet/core/extensions/logger-message-generator

            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            List<KeyValuePair<string, object>> scope1 = new()
            {
                new("scopeKey1", "scopeValue1"),
                new("scopeKey2", "scopeValue2")
            };

            using (logger.BeginScope(scope1))
            {
                logger.WriteCustomEventWithAdditionalProperties("MyCustomEventName", "value1", "value2");
            }

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);
            var telemetryItem = telemetryItems?.Where(x => x.Name == "Event").Single();

            TelemetryItemValidationHelper.AssertCustomEventTelemetry(
                telemetryItem: telemetryItem!,
                expectedName: "MyCustomEventName",
                expectedProperties: new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" }, { "scopeKey1", "scopeValue1" }, { "scopeKey2", "scopeValue2" } },
                expectedSpanId: null,
                expectedTraceId: null);
        }

        [Fact]
        public void VerifyCustomEventWithTwoCustomEventAttributes()
        {
            // This method is testing Compile-time logging source generation.
            // https://learn.microsoft.com/dotnet/core/extensions/logger-message-generator

            // SETUP
            var uniqueTestId = Guid.NewGuid();

            var logCategoryName = $"logCategoryName{uniqueTestId}";

            List<TelemetryItem>? telemetryItems = null;

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault().AddAttributes(testResourceAttributes));
                        options.AddAzureMonitorLogExporterForTest(out telemetryItems);
                    });
            });

            // ACT
            var logger = loggerFactory.CreateLogger(logCategoryName);

            List<KeyValuePair<string, object>> customEventScope = new()
            {
                new("microsoft.custom_event.name", "Name2")
            };

            using (logger.BeginScope(customEventScope))
            {
                logger.WriteCustomEvent("Name1");
            }

            // CLEANUP
            loggerFactory.Dispose();

            // ASSERT
            Assert.True(telemetryItems?.Any(), "Unit test failed to collect telemetry.");
            this.telemetryOutput.Write(telemetryItems);
            var telemetryItem = telemetryItems?.Where(x => x.Name == "Event").Single();

            TelemetryItemValidationHelper.AssertCustomEventTelemetry(
                telemetryItem: telemetryItem!,
                expectedName: "Name1",
                expectedProperties: new Dictionary<string, string>() { { "microsoft.custom_event.name", "Name2" } },
                expectedSpanId: null,
                expectedTraceId: null);
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "UnitTest")]
    public static partial class CustomEventLoggerExtensions
    {
        [LoggerMessage(level: LogLevel.Information, Message = "{key1}")]
        public static partial void WriteLog(this ILogger logger, string key1);

        // TODO: REMOVE THIS PRAGMA AFTER Microsoft.Extensions.Telemetry SHIPS THE TagName API AS STABLE.
#pragma warning disable EXTEXP0003 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        [LoggerMessage(level: LogLevel.Information, Message = "{microsoft.custom_event.name}")]
        public static partial void WriteCustomEvent(this ILogger logger, [TagName("microsoft.custom_event.name")] string customEventName);

        [LoggerMessage(level: LogLevel.Information, Message = "{microsoft.custom_event.name} {key1} {key2}")]
        public static partial void WriteCustomEventWithAdditionalProperties(this ILogger logger, [TagName("microsoft.custom_event.name")] string customEventName, string key1, string key2);
#pragma warning restore EXTEXP0003
    }
#endif
}
