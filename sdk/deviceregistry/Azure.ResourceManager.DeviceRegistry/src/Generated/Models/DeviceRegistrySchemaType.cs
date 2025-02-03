// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the schema type. </summary>
    public readonly partial struct DeviceRegistrySchemaType : IEquatable<DeviceRegistrySchemaType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceRegistrySchemaType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceRegistrySchemaType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MessageSchemaValue = "MessageSchema";

        /// <summary> Message Schema schema type. </summary>
        public static DeviceRegistrySchemaType MessageSchema { get; } = new DeviceRegistrySchemaType(MessageSchemaValue);
        /// <summary> Determines if two <see cref="DeviceRegistrySchemaType"/> values are the same. </summary>
        public static bool operator ==(DeviceRegistrySchemaType left, DeviceRegistrySchemaType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceRegistrySchemaType"/> values are not the same. </summary>
        public static bool operator !=(DeviceRegistrySchemaType left, DeviceRegistrySchemaType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeviceRegistrySchemaType"/>. </summary>
        public static implicit operator DeviceRegistrySchemaType(string value) => new DeviceRegistrySchemaType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceRegistrySchemaType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceRegistrySchemaType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
