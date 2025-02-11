// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Kubernetes Service Types supported by Listener. </summary>
    public readonly partial struct BlockerListenerServiceType : IEquatable<BlockerListenerServiceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlockerListenerServiceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlockerListenerServiceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClusterIPValue = "ClusterIp";
        private const string LoadBalancerValue = "LoadBalancer";
        private const string NodePortValue = "NodePort";

        /// <summary> Cluster IP Service. </summary>
        public static BlockerListenerServiceType ClusterIP { get; } = new BlockerListenerServiceType(ClusterIPValue);
        /// <summary> Load Balancer Service. </summary>
        public static BlockerListenerServiceType LoadBalancer { get; } = new BlockerListenerServiceType(LoadBalancerValue);
        /// <summary> Node Port Service. </summary>
        public static BlockerListenerServiceType NodePort { get; } = new BlockerListenerServiceType(NodePortValue);
        /// <summary> Determines if two <see cref="BlockerListenerServiceType"/> values are the same. </summary>
        public static bool operator ==(BlockerListenerServiceType left, BlockerListenerServiceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlockerListenerServiceType"/> values are not the same. </summary>
        public static bool operator !=(BlockerListenerServiceType left, BlockerListenerServiceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlockerListenerServiceType"/>. </summary>
        public static implicit operator BlockerListenerServiceType(string value) => new BlockerListenerServiceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlockerListenerServiceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlockerListenerServiceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
