// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> Broker Retain types. </summary>
    public readonly partial struct MqttRetainType : IEquatable<MqttRetainType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MqttRetainType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MqttRetainType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeepValue = "Keep";
        private const string NeverValue = "Never";

        /// <summary> Retain the messages. </summary>
        public static MqttRetainType Keep { get; } = new MqttRetainType(KeepValue);
        /// <summary> Never retain messages. </summary>
        public static MqttRetainType Never { get; } = new MqttRetainType(NeverValue);
        /// <summary> Determines if two <see cref="MqttRetainType"/> values are the same. </summary>
        public static bool operator ==(MqttRetainType left, MqttRetainType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MqttRetainType"/> values are not the same. </summary>
        public static bool operator !=(MqttRetainType left, MqttRetainType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MqttRetainType"/>. </summary>
        public static implicit operator MqttRetainType(string value) => new MqttRetainType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MqttRetainType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MqttRetainType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
