// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Load test run model. </summary>
    public partial class TestRun
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

        /// <summary> Initializes a new instance of <see cref="TestRun"/>. </summary>
        public TestRun()
        {
            Secrets = new ChangeTrackingDictionary<string, Secret>();
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            ErrorDetails = new ChangeTrackingList<ErrorDetails>();
            TestRunStatistics = new ChangeTrackingDictionary<string, TestRunStatistics>();
            RegionalStatistics = new ChangeTrackingDictionary<string, TestRunStatistics>();
        }

        /// <summary> Initializes a new instance of <see cref="TestRun"/>. </summary>
        /// <param name="testRunId"> Unique test run identifier for the load test run, must contain only lower-case alphabetic, numeric, underscore or hyphen characters. </param>
        /// <param name="passFailCriteria"> Pass fail criteria for a test. </param>
        /// <param name="autoStopCriteria"> Auto stop criteria for a test. This will automatically stop a load test if the error percentage is high for a certain time window. </param>
        /// <param name="secrets">
        /// Secrets can be stored in an Azure Key Vault or any other secret store. If the
        /// secret is stored in an Azure Key Vault, the value should be the secret
        /// identifier and the type should be AKV_SECRET_URI. If the secret is stored
        /// elsewhere, the secret value should be provided directly and the type should be
        /// SECRET_VALUE.
        /// </param>
        /// <param name="certificate"> Certificates metadata. </param>
        /// <param name="environmentVariables"> Environment variables which are defined as a set of &lt;name,value&gt; pairs. </param>
        /// <param name="errorDetails"> Error details if there is any failure in load test run. </param>
        /// <param name="testRunStatistics">
        /// Test run statistics. Key is the sampler name and value is the set of statistics for performance metrics like response time, throughput, etc. from the load test run.
        /// The sampler name is the same as the name mentioned in the test script.
        /// Sampler name "Total" represents the aggregated statistics of all the samplers.
        /// </param>
        /// <param name="regionalStatistics">
        /// Regional statistics. Key is the Azure region name and value is the test run statistics.
        /// The region name should of format accepted by ARM, and should be a region supported by Azure Load Testing. For example, East US should be passed as "eastus".
        /// The region name must match one of the strings in the "Name" column returned from running the "az account list-locations -o table" Azure CLI command.
        /// </param>
        /// <param name="loadTestConfiguration"> The load test configuration. </param>
        /// <param name="testArtifacts"> Collection of test run artifacts. </param>
        /// <param name="testResult"> Test result for pass/Fail criteria used during the test run. </param>
        /// <param name="virtualUsers"> Number of virtual users, for which test has been run. </param>
        /// <param name="displayName"> Display name of a testRun. </param>
        /// <param name="testId"> Associated test Id. </param>
        /// <param name="description"> The test run description. </param>
        /// <param name="status"> The test run status. </param>
        /// <param name="startDateTime"> The test run start DateTime(RFC 3339 literal format). </param>
        /// <param name="endDateTime"> The test run end DateTime(RFC 3339 literal format). </param>
        /// <param name="executedDateTime"> Test run initiated time. </param>
        /// <param name="portalUrl"> Portal url. </param>
        /// <param name="duration"> Test run duration in milliseconds. </param>
        /// <param name="virtualUserHours"> Virtual user hours consumed by the test run. </param>
        /// <param name="subnetId"> Subnet ID on which the load test instances should run. </param>
        /// <param name="kind"> Type of test. </param>
        /// <param name="requestDataLevel"> Request data collection level for test run. </param>
        /// <param name="debugLogsEnabled"> Enable or disable debug level logging. True if debug logs are enabled for the test run. False otherwise. </param>
        /// <param name="publicIPDisabled"> Inject load test engines without deploying public IP for outbound access. </param>
        /// <param name="createdByType"> The type of the entity that created the test run. (E.x. User, ScheduleTrigger, etc). </param>
        /// <param name="createdDateTime"> The creation datetime(RFC 3339 literal format). </param>
        /// <param name="createdBy"> The user that created. </param>
        /// <param name="lastModifiedDateTime"> The last Modified datetime(RFC 3339 literal format). </param>
        /// <param name="lastModifiedBy"> The user that last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestRun(string testRunId, PassFailCriteria passFailCriteria, AutoStopCriteria autoStopCriteria, IDictionary<string, Secret> secrets, CertificateMetadata certificate, IDictionary<string, string> environmentVariables, IReadOnlyList<ErrorDetails> errorDetails, IReadOnlyDictionary<string, TestRunStatistics> testRunStatistics, IReadOnlyDictionary<string, TestRunStatistics> regionalStatistics, LoadTestConfiguration loadTestConfiguration, TestRunArtifacts testArtifacts, PFTestResult? testResult, int? virtualUsers, string displayName, string testId, string description, Status? status, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime, DateTimeOffset? executedDateTime, string portalUrl, long? duration, double? virtualUserHours, string subnetId, TestKind? kind, RequestDataLevel? requestDataLevel, bool? debugLogsEnabled, bool? publicIPDisabled, CreatedByType? createdByType, DateTimeOffset? createdDateTime, string createdBy, DateTimeOffset? lastModifiedDateTime, string lastModifiedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TestRunId = testRunId;
            PassFailCriteria = passFailCriteria;
            AutoStopCriteria = autoStopCriteria;
            Secrets = secrets;
            Certificate = certificate;
            EnvironmentVariables = environmentVariables;
            ErrorDetails = errorDetails;
            TestRunStatistics = testRunStatistics;
            RegionalStatistics = regionalStatistics;
            LoadTestConfiguration = loadTestConfiguration;
            TestArtifacts = testArtifacts;
            TestResult = testResult;
            VirtualUsers = virtualUsers;
            DisplayName = displayName;
            TestId = testId;
            Description = description;
            Status = status;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            ExecutedDateTime = executedDateTime;
            PortalUrl = portalUrl;
            Duration = duration;
            VirtualUserHours = virtualUserHours;
            SubnetId = subnetId;
            Kind = kind;
            RequestDataLevel = requestDataLevel;
            DebugLogsEnabled = debugLogsEnabled;
            PublicIPDisabled = publicIPDisabled;
            CreatedByType = createdByType;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique test run identifier for the load test run, must contain only lower-case alphabetic, numeric, underscore or hyphen characters. </summary>
        public string TestRunId { get; }
        /// <summary> Pass fail criteria for a test. </summary>
        public PassFailCriteria PassFailCriteria { get; set; }
        /// <summary> Auto stop criteria for a test. This will automatically stop a load test if the error percentage is high for a certain time window. </summary>
        public AutoStopCriteria AutoStopCriteria { get; set; }
        /// <summary>
        /// Secrets can be stored in an Azure Key Vault or any other secret store. If the
        /// secret is stored in an Azure Key Vault, the value should be the secret
        /// identifier and the type should be AKV_SECRET_URI. If the secret is stored
        /// elsewhere, the secret value should be provided directly and the type should be
        /// SECRET_VALUE.
        /// </summary>
        public IDictionary<string, Secret> Secrets { get; }
        /// <summary> Certificates metadata. </summary>
        public CertificateMetadata Certificate { get; set; }
        /// <summary> Environment variables which are defined as a set of &lt;name,value&gt; pairs. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        /// <summary> Error details if there is any failure in load test run. </summary>
        public IReadOnlyList<ErrorDetails> ErrorDetails { get; }
        /// <summary>
        /// Test run statistics. Key is the sampler name and value is the set of statistics for performance metrics like response time, throughput, etc. from the load test run.
        /// The sampler name is the same as the name mentioned in the test script.
        /// Sampler name "Total" represents the aggregated statistics of all the samplers.
        /// </summary>
        public IReadOnlyDictionary<string, TestRunStatistics> TestRunStatistics { get; }
        /// <summary>
        /// Regional statistics. Key is the Azure region name and value is the test run statistics.
        /// The region name should of format accepted by ARM, and should be a region supported by Azure Load Testing. For example, East US should be passed as "eastus".
        /// The region name must match one of the strings in the "Name" column returned from running the "az account list-locations -o table" Azure CLI command.
        /// </summary>
        public IReadOnlyDictionary<string, TestRunStatistics> RegionalStatistics { get; }
        /// <summary> The load test configuration. </summary>
        public LoadTestConfiguration LoadTestConfiguration { get; set; }
        /// <summary> Collection of test run artifacts. </summary>
        public TestRunArtifacts TestArtifacts { get; }
        /// <summary> Test result for pass/Fail criteria used during the test run. </summary>
        public PFTestResult? TestResult { get; }
        /// <summary> Number of virtual users, for which test has been run. </summary>
        public int? VirtualUsers { get; }
        /// <summary> Display name of a testRun. </summary>
        public string DisplayName { get; set; }
        /// <summary> Associated test Id. </summary>
        public string TestId { get; set; }
        /// <summary> The test run description. </summary>
        public string Description { get; set; }
        /// <summary> The test run status. </summary>
        public Status? Status { get; }
        /// <summary> The test run start DateTime(RFC 3339 literal format). </summary>
        public DateTimeOffset? StartDateTime { get; }
        /// <summary> The test run end DateTime(RFC 3339 literal format). </summary>
        public DateTimeOffset? EndDateTime { get; }
        /// <summary> Test run initiated time. </summary>
        public DateTimeOffset? ExecutedDateTime { get; }
        /// <summary> Portal url. </summary>
        public string PortalUrl { get; }
        /// <summary> Test run duration in milliseconds. </summary>
        public long? Duration { get; }
        /// <summary> Virtual user hours consumed by the test run. </summary>
        public double? VirtualUserHours { get; }
        /// <summary> Subnet ID on which the load test instances should run. </summary>
        public string SubnetId { get; }
        /// <summary> Type of test. </summary>
        public TestKind? Kind { get; }
        /// <summary> Request data collection level for test run. </summary>
        public RequestDataLevel? RequestDataLevel { get; set; }
        /// <summary> Enable or disable debug level logging. True if debug logs are enabled for the test run. False otherwise. </summary>
        public bool? DebugLogsEnabled { get; set; }
        /// <summary> Inject load test engines without deploying public IP for outbound access. </summary>
        public bool? PublicIPDisabled { get; }
        /// <summary> The type of the entity that created the test run. (E.x. User, ScheduleTrigger, etc). </summary>
        public CreatedByType? CreatedByType { get; set; }
        /// <summary> The creation datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The user that created. </summary>
        public string CreatedBy { get; }
        /// <summary> The last Modified datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? LastModifiedDateTime { get; }
        /// <summary> The user that last modified. </summary>
        public string LastModifiedBy { get; }
    }
}
