// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents
{
    /// <summary> Describes the relationship between the days and the expiration of this vector store. </summary>
    public readonly partial struct VectorStoreExpirationPolicyAnchor : IEquatable<VectorStoreExpirationPolicyAnchor>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreExpirationPolicyAnchor"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreExpirationPolicyAnchor(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LastActiveAtValue = "last_active_at";

        /// <summary> The expiration policy is based on the last time the vector store was active. </summary>
        public static VectorStoreExpirationPolicyAnchor LastActiveAt { get; } = new VectorStoreExpirationPolicyAnchor(LastActiveAtValue);
        /// <summary> Determines if two <see cref="VectorStoreExpirationPolicyAnchor"/> values are the same. </summary>
        public static bool operator ==(VectorStoreExpirationPolicyAnchor left, VectorStoreExpirationPolicyAnchor right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreExpirationPolicyAnchor"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreExpirationPolicyAnchor left, VectorStoreExpirationPolicyAnchor right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreExpirationPolicyAnchor"/>. </summary>
        public static implicit operator VectorStoreExpirationPolicyAnchor(string value) => new VectorStoreExpirationPolicyAnchor(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreExpirationPolicyAnchor other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreExpirationPolicyAnchor other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
