// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> DataflowEndpoint Kafka Partition Strategy properties. </summary>
    public readonly partial struct DataflowEndpointKafkaPartitionStrategy : IEquatable<DataflowEndpointKafkaPartitionStrategy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointKafkaPartitionStrategy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataflowEndpointKafkaPartitionStrategy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string StaticValue = "Static";
        private const string TopicValue = "Topic";
        private const string PropertyValue = "Property";

        /// <summary> Default: Assigns messages to random partitions, using a round-robin algorithm. </summary>
        public static DataflowEndpointKafkaPartitionStrategy Default { get; } = new DataflowEndpointKafkaPartitionStrategy(DefaultValue);
        /// <summary> Static: Assigns messages to a fixed partition number that's derived from the instance ID of the dataflow. </summary>
        public static DataflowEndpointKafkaPartitionStrategy Static { get; } = new DataflowEndpointKafkaPartitionStrategy(StaticValue);
        /// <summary> TOPIC Option. </summary>
        public static DataflowEndpointKafkaPartitionStrategy Topic { get; } = new DataflowEndpointKafkaPartitionStrategy(TopicValue);
        /// <summary> PROPERTY Option. </summary>
        public static DataflowEndpointKafkaPartitionStrategy Property { get; } = new DataflowEndpointKafkaPartitionStrategy(PropertyValue);
        /// <summary> Determines if two <see cref="DataflowEndpointKafkaPartitionStrategy"/> values are the same. </summary>
        public static bool operator ==(DataflowEndpointKafkaPartitionStrategy left, DataflowEndpointKafkaPartitionStrategy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataflowEndpointKafkaPartitionStrategy"/> values are not the same. </summary>
        public static bool operator !=(DataflowEndpointKafkaPartitionStrategy left, DataflowEndpointKafkaPartitionStrategy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataflowEndpointKafkaPartitionStrategy"/>. </summary>
        public static implicit operator DataflowEndpointKafkaPartitionStrategy(string value) => new DataflowEndpointKafkaPartitionStrategy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataflowEndpointKafkaPartitionStrategy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataflowEndpointKafkaPartitionStrategy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
