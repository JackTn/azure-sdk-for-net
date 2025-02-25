// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers.SipRouting
{
    /// <summary> IP address version. </summary>
    public readonly partial struct IpAddressVersion : IEquatable<IpAddressVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IpAddressVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IpAddressVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Ipv4Value = "ipv4";
        private const string Ipv6Value = "ipv6";

        /// <summary> ipv4. </summary>
        public static IpAddressVersion Ipv4 { get; } = new IpAddressVersion(Ipv4Value);
        /// <summary> ipv6. </summary>
        public static IpAddressVersion Ipv6 { get; } = new IpAddressVersion(Ipv6Value);
        /// <summary> Determines if two <see cref="IpAddressVersion"/> values are the same. </summary>
        public static bool operator ==(IpAddressVersion left, IpAddressVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpAddressVersion"/> values are not the same. </summary>
        public static bool operator !=(IpAddressVersion left, IpAddressVersion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IpAddressVersion"/>. </summary>
        public static implicit operator IpAddressVersion(string value) => new IpAddressVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpAddressVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpAddressVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
