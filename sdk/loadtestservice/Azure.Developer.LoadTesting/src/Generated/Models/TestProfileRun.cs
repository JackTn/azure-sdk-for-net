// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> The Test Profile Run Model. Test Profile Run resource enables you to instantiate an already created test profile and run load tests to get recommendations on the optimal configuration for the target resource. </summary>
    public partial class TestProfileRun
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

        /// <summary> Initializes a new instance of <see cref="TestProfileRun"/>. </summary>
        public TestProfileRun()
        {
            ErrorDetails = new ChangeTrackingList<ErrorDetails>();
            TestRunDetails = new ChangeTrackingDictionary<string, TestRunDetail>();
            Recommendations = new ChangeTrackingList<TestProfileRunRecommendation>();
        }

        /// <summary> Initializes a new instance of <see cref="TestProfileRun"/>. </summary>
        /// <param name="testProfileRunId"> Unique identifier for the test profile run, must contain only lower-case alphabetic, numeric, underscore or hyphen characters. </param>
        /// <param name="displayName"> Display name for the test profile run. </param>
        /// <param name="description"> The test profile run description. </param>
        /// <param name="testProfileId"> Associated test profile ID for the test profile run. This is required to create a test profile run and can't be updated. </param>
        /// <param name="targetResourceId"> Target resource ID on which the test profile run is created. </param>
        /// <param name="targetResourceConfigurations">
        /// Configurations of the target resource on which the test profile ran.
        /// Please note <see cref="Models.TargetResourceConfigurations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionFlexConsumptionTargetResourceConfigurations"/>.
        /// </param>
        /// <param name="status"> The test profile run status. </param>
        /// <param name="errorDetails"> Error details if there is any failure in test profile run. These errors are specific to the Test Profile Run. </param>
        /// <param name="startDateTime"> The test profile run start DateTime(RFC 3339 literal format). </param>
        /// <param name="endDateTime"> The test profile run end DateTime(RFC 3339 literal format). </param>
        /// <param name="durationInSeconds"> Test profile run duration in seconds. </param>
        /// <param name="testRunDetails">
        /// Details of the test runs ran as part of the test profile run.
        /// Key is the testRunId of the corresponding testRun.
        /// </param>
        /// <param name="recommendations"> Recommendations provided based on a successful test profile run. </param>
        /// <param name="createdDateTime"> The creation datetime(RFC 3339 literal format). </param>
        /// <param name="createdBy"> The user that created. </param>
        /// <param name="lastModifiedDateTime"> The last Modified datetime(RFC 3339 literal format). </param>
        /// <param name="lastModifiedBy"> The user that last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestProfileRun(string testProfileRunId, string displayName, string description, string testProfileId, ResourceIdentifier targetResourceId, TargetResourceConfigurations targetResourceConfigurations, TestProfileRunStatus? status, IReadOnlyList<ErrorDetails> errorDetails, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime, long? durationInSeconds, IReadOnlyDictionary<string, TestRunDetail> testRunDetails, IReadOnlyList<TestProfileRunRecommendation> recommendations, DateTimeOffset? createdDateTime, string createdBy, DateTimeOffset? lastModifiedDateTime, string lastModifiedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TestProfileRunId = testProfileRunId;
            DisplayName = displayName;
            Description = description;
            TestProfileId = testProfileId;
            TargetResourceId = targetResourceId;
            TargetResourceConfigurations = targetResourceConfigurations;
            Status = status;
            ErrorDetails = errorDetails;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            DurationInSeconds = durationInSeconds;
            TestRunDetails = testRunDetails;
            Recommendations = recommendations;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique identifier for the test profile run, must contain only lower-case alphabetic, numeric, underscore or hyphen characters. </summary>
        public string TestProfileRunId { get; }
        /// <summary> Display name for the test profile run. </summary>
        public string DisplayName { get; set; }
        /// <summary> The test profile run description. </summary>
        public string Description { get; set; }
        /// <summary> Associated test profile ID for the test profile run. This is required to create a test profile run and can't be updated. </summary>
        public string TestProfileId { get; set; }
        /// <summary> Target resource ID on which the test profile run is created. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary>
        /// Configurations of the target resource on which the test profile ran.
        /// Please note <see cref="Models.TargetResourceConfigurations"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FunctionFlexConsumptionTargetResourceConfigurations"/>.
        /// </summary>
        public TargetResourceConfigurations TargetResourceConfigurations { get; }
        /// <summary> The test profile run status. </summary>
        public TestProfileRunStatus? Status { get; }
        /// <summary> Error details if there is any failure in test profile run. These errors are specific to the Test Profile Run. </summary>
        public IReadOnlyList<ErrorDetails> ErrorDetails { get; }
        /// <summary> The test profile run start DateTime(RFC 3339 literal format). </summary>
        public DateTimeOffset? StartDateTime { get; }
        /// <summary> The test profile run end DateTime(RFC 3339 literal format). </summary>
        public DateTimeOffset? EndDateTime { get; }
        /// <summary> Test profile run duration in seconds. </summary>
        public long? DurationInSeconds { get; }
        /// <summary>
        /// Details of the test runs ran as part of the test profile run.
        /// Key is the testRunId of the corresponding testRun.
        /// </summary>
        public IReadOnlyDictionary<string, TestRunDetail> TestRunDetails { get; }
        /// <summary> Recommendations provided based on a successful test profile run. </summary>
        public IReadOnlyList<TestProfileRunRecommendation> Recommendations { get; }
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
