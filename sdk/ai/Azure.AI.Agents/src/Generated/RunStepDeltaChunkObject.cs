// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents
{
    /// <summary> The RunStepDeltaChunk_object. </summary>
    public readonly partial struct RunStepDeltaChunkObject : IEquatable<RunStepDeltaChunkObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaChunkObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepDeltaChunkObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadRunStepDeltaValue = "thread.run.step.delta";

        /// <summary> thread.run.step.delta. </summary>
        public static RunStepDeltaChunkObject ThreadRunStepDelta { get; } = new RunStepDeltaChunkObject(ThreadRunStepDeltaValue);
        /// <summary> Determines if two <see cref="RunStepDeltaChunkObject"/> values are the same. </summary>
        public static bool operator ==(RunStepDeltaChunkObject left, RunStepDeltaChunkObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepDeltaChunkObject"/> values are not the same. </summary>
        public static bool operator !=(RunStepDeltaChunkObject left, RunStepDeltaChunkObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RunStepDeltaChunkObject"/>. </summary>
        public static implicit operator RunStepDeltaChunkObject(string value) => new RunStepDeltaChunkObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepDeltaChunkObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepDeltaChunkObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
