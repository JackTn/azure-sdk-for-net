// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The call locator kind. </summary>
    internal readonly partial struct CallLocatorKindInternal : IEquatable<CallLocatorKindInternal>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CallLocatorKindInternal"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CallLocatorKindInternal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GroupCallLocatorValue = "groupCallLocator";
        private const string ServerCallLocatorValue = "serverCallLocator";
        private const string RoomCallLocatorValue = "roomCallLocator";

        /// <summary> groupCallLocator. </summary>
        public static CallLocatorKindInternal GroupCallLocator { get; } = new CallLocatorKindInternal(GroupCallLocatorValue);
        /// <summary> serverCallLocator. </summary>
        public static CallLocatorKindInternal ServerCallLocator { get; } = new CallLocatorKindInternal(ServerCallLocatorValue);
        /// <summary> roomCallLocator. </summary>
        public static CallLocatorKindInternal RoomCallLocator { get; } = new CallLocatorKindInternal(RoomCallLocatorValue);
        /// <summary> Determines if two <see cref="CallLocatorKindInternal"/> values are the same. </summary>
        public static bool operator ==(CallLocatorKindInternal left, CallLocatorKindInternal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CallLocatorKindInternal"/> values are not the same. </summary>
        public static bool operator !=(CallLocatorKindInternal left, CallLocatorKindInternal right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CallLocatorKindInternal"/>. </summary>
        public static implicit operator CallLocatorKindInternal(string value) => new CallLocatorKindInternal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CallLocatorKindInternal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CallLocatorKindInternal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
