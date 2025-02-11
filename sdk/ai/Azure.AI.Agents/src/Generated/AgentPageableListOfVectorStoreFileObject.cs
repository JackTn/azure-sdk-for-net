// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents
{
    /// <summary> The OpenAIPageableListOfVectorStoreFile_object. </summary>
    public readonly partial struct AgentPageableListOfVectorStoreFileObject : IEquatable<AgentPageableListOfVectorStoreFileObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentPageableListOfVectorStoreFileObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentPageableListOfVectorStoreFileObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static AgentPageableListOfVectorStoreFileObject List { get; } = new AgentPageableListOfVectorStoreFileObject(ListValue);
        /// <summary> Determines if two <see cref="AgentPageableListOfVectorStoreFileObject"/> values are the same. </summary>
        public static bool operator ==(AgentPageableListOfVectorStoreFileObject left, AgentPageableListOfVectorStoreFileObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentPageableListOfVectorStoreFileObject"/> values are not the same. </summary>
        public static bool operator !=(AgentPageableListOfVectorStoreFileObject left, AgentPageableListOfVectorStoreFileObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgentPageableListOfVectorStoreFileObject"/>. </summary>
        public static implicit operator AgentPageableListOfVectorStoreFileObject(string value) => new AgentPageableListOfVectorStoreFileObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentPageableListOfVectorStoreFileObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentPageableListOfVectorStoreFileObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
