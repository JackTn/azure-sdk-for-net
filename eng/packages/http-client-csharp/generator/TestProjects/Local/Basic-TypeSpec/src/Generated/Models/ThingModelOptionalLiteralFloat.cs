// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace BasicTypeSpec.Models
{
    /// <summary> The ThingModel_optionalLiteralFloat. </summary>
    public readonly partial struct ThingModelOptionalLiteralFloat : IEquatable<ThingModelOptionalLiteralFloat>
    {
        private readonly float _value;
        /// <summary> 4.56. </summary>
        private const float _456Value = 4.56F;

        /// <summary> Initializes a new instance of <see cref="ThingModelOptionalLiteralFloat"/>. </summary>
        /// <param name="value"> The value. </param>
        public ThingModelOptionalLiteralFloat(float value)
        {
            _value = value;
        }

        /// <summary> 4.56. </summary>
        public static ThingModelOptionalLiteralFloat _456 { get; } = new ThingModelOptionalLiteralFloat(_456Value);

        /// <summary> Determines if two <see cref="ThingModelOptionalLiteralFloat"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(ThingModelOptionalLiteralFloat left, ThingModelOptionalLiteralFloat right) => left.Equals(right);

        /// <summary> Determines if two <see cref="ThingModelOptionalLiteralFloat"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(ThingModelOptionalLiteralFloat left, ThingModelOptionalLiteralFloat right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="ThingModelOptionalLiteralFloat"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator ThingModelOptionalLiteralFloat(float value) => new ThingModelOptionalLiteralFloat(value);

        /// <param name="obj"> The object to compare. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThingModelOptionalLiteralFloat other && Equals(other);

        /// <param name="other"> The instance to compare. </param>
        public bool Equals(ThingModelOptionalLiteralFloat other) => Equals(_value, other._value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();

        /// <inheritdoc/>
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
