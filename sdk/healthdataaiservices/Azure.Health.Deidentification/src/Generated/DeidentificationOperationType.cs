// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Deidentification
{
    /// <summary> Enum of supported Operation Types. </summary>
    public readonly partial struct DeidentificationOperationType : IEquatable<DeidentificationOperationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeidentificationOperationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeidentificationOperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RedactValue = "Redact";
        private const string SurrogateValue = "Surrogate";
        private const string TagValue = "Tag";

        /// <summary> Redact Operation will remove all entities of PHI and replace them with a placeholder value. </summary>
        public static DeidentificationOperationType Redact { get; } = new DeidentificationOperationType(RedactValue);
        /// <summary> Surrogation Operation will replace all entities of PHI with a surrogate value. </summary>
        public static DeidentificationOperationType Surrogate { get; } = new DeidentificationOperationType(SurrogateValue);
        /// <summary> Tag Operation will detect all entities of PHI, their type, and return their locations in the document. </summary>
        public static DeidentificationOperationType Tag { get; } = new DeidentificationOperationType(TagValue);
        /// <summary> Determines if two <see cref="DeidentificationOperationType"/> values are the same. </summary>
        public static bool operator ==(DeidentificationOperationType left, DeidentificationOperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeidentificationOperationType"/> values are not the same. </summary>
        public static bool operator !=(DeidentificationOperationType left, DeidentificationOperationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeidentificationOperationType"/>. </summary>
        public static implicit operator DeidentificationOperationType(string value) => new DeidentificationOperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeidentificationOperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeidentificationOperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
