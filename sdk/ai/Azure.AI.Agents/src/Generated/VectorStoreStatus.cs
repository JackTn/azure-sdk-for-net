// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents
{
    /// <summary> Vector store possible status. </summary>
    public readonly partial struct VectorStoreStatus : IEquatable<VectorStoreStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExpiredValue = "expired";
        private const string InProgressValue = "in_progress";
        private const string CompletedValue = "completed";

        /// <summary> expired status indicates that this vector store has expired and is no longer available for use. </summary>
        public static VectorStoreStatus Expired { get; } = new VectorStoreStatus(ExpiredValue);
        /// <summary> in_progress status indicates that this vector store is still processing files. </summary>
        public static VectorStoreStatus InProgress { get; } = new VectorStoreStatus(InProgressValue);
        /// <summary> completed status indicates that this vector store is ready for use. </summary>
        public static VectorStoreStatus Completed { get; } = new VectorStoreStatus(CompletedValue);
        /// <summary> Determines if two <see cref="VectorStoreStatus"/> values are the same. </summary>
        public static bool operator ==(VectorStoreStatus left, VectorStoreStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreStatus"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreStatus left, VectorStoreStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreStatus"/>. </summary>
        public static implicit operator VectorStoreStatus(string value) => new VectorStoreStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
