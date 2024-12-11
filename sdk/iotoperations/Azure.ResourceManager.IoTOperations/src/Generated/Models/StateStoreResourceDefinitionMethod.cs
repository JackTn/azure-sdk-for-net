// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> StateStoreResourceDefinitionMethods methods allowed. </summary>
    public readonly partial struct StateStoreResourceDefinitionMethod : IEquatable<StateStoreResourceDefinitionMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StateStoreResourceDefinitionMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StateStoreResourceDefinitionMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadValue = "Read";
        private const string WriteValue = "Write";
        private const string ReadWriteValue = "ReadWrite";

        /// <summary> Get/KeyNotify from Store. </summary>
        public static StateStoreResourceDefinitionMethod Read { get; } = new StateStoreResourceDefinitionMethod(ReadValue);
        /// <summary> Set/Delete in Store. </summary>
        public static StateStoreResourceDefinitionMethod Write { get; } = new StateStoreResourceDefinitionMethod(WriteValue);
        /// <summary> Allowed all operations on Store - Get/KeyNotify/Set/Delete. </summary>
        public static StateStoreResourceDefinitionMethod ReadWrite { get; } = new StateStoreResourceDefinitionMethod(ReadWriteValue);
        /// <summary> Determines if two <see cref="StateStoreResourceDefinitionMethod"/> values are the same. </summary>
        public static bool operator ==(StateStoreResourceDefinitionMethod left, StateStoreResourceDefinitionMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StateStoreResourceDefinitionMethod"/> values are not the same. </summary>
        public static bool operator !=(StateStoreResourceDefinitionMethod left, StateStoreResourceDefinitionMethod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StateStoreResourceDefinitionMethod"/>. </summary>
        public static implicit operator StateStoreResourceDefinitionMethod(string value) => new StateStoreResourceDefinitionMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StateStoreResourceDefinitionMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StateStoreResourceDefinitionMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
