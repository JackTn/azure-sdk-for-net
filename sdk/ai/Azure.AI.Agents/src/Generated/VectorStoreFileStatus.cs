// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents
{
    /// <summary> Vector store file status. </summary>
    public readonly partial struct VectorStoreFileStatus : IEquatable<VectorStoreFileStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreFileStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreFileStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "in_progress";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";

        /// <summary> The file is currently being processed. </summary>
        public static VectorStoreFileStatus InProgress { get; } = new VectorStoreFileStatus(InProgressValue);
        /// <summary> The file has been successfully processed. </summary>
        public static VectorStoreFileStatus Completed { get; } = new VectorStoreFileStatus(CompletedValue);
        /// <summary> The file has failed to process. </summary>
        public static VectorStoreFileStatus Failed { get; } = new VectorStoreFileStatus(FailedValue);
        /// <summary> The file was cancelled. </summary>
        public static VectorStoreFileStatus Cancelled { get; } = new VectorStoreFileStatus(CancelledValue);
        /// <summary> Determines if two <see cref="VectorStoreFileStatus"/> values are the same. </summary>
        public static bool operator ==(VectorStoreFileStatus left, VectorStoreFileStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreFileStatus"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreFileStatus left, VectorStoreFileStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreFileStatus"/>. </summary>
        public static implicit operator VectorStoreFileStatus(string value) => new VectorStoreFileStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreFileStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreFileStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
