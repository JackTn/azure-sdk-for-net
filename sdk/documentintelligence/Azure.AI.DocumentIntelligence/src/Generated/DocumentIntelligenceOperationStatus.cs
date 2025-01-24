// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Operation status. </summary>
    public readonly partial struct DocumentIntelligenceOperationStatus : IEquatable<DocumentIntelligenceOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentIntelligenceOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentIntelligenceOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string FailedValue = "failed";
        private const string SucceededValue = "succeeded";
        private const string CanceledValue = "canceled";
        private const string SkippedValue = "skipped";

        /// <summary> The operation has not started yet. </summary>
        public static DocumentIntelligenceOperationStatus NotStarted { get; } = new DocumentIntelligenceOperationStatus(NotStartedValue);
        /// <summary> The operation is in progress. </summary>
        public static DocumentIntelligenceOperationStatus Running { get; } = new DocumentIntelligenceOperationStatus(RunningValue);
        /// <summary> The operation has failed. </summary>
        public static DocumentIntelligenceOperationStatus Failed { get; } = new DocumentIntelligenceOperationStatus(FailedValue);
        /// <summary> The operation has succeeded. </summary>
        public static DocumentIntelligenceOperationStatus Succeeded { get; } = new DocumentIntelligenceOperationStatus(SucceededValue);
        /// <summary> The operation has been canceled. </summary>
        public static DocumentIntelligenceOperationStatus Canceled { get; } = new DocumentIntelligenceOperationStatus(CanceledValue);
        /// <summary> The operation has been skipped. </summary>
        public static DocumentIntelligenceOperationStatus Skipped { get; } = new DocumentIntelligenceOperationStatus(SkippedValue);
        /// <summary> Determines if two <see cref="DocumentIntelligenceOperationStatus"/> values are the same. </summary>
        public static bool operator ==(DocumentIntelligenceOperationStatus left, DocumentIntelligenceOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentIntelligenceOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(DocumentIntelligenceOperationStatus left, DocumentIntelligenceOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentIntelligenceOperationStatus"/>. </summary>
        public static implicit operator DocumentIntelligenceOperationStatus(string value) => new DocumentIntelligenceOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentIntelligenceOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentIntelligenceOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
