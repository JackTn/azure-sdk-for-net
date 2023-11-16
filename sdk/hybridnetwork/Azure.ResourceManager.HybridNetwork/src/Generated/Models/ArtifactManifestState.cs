// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The artifact manifest state. </summary>
    public readonly partial struct ArtifactManifestState : IEquatable<ArtifactManifestState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArtifactManifestState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UploadingValue = "Uploading";
        private const string UploadedValue = "Uploaded";
        private const string ValidatingValue = "Validating";
        private const string ValidationFailedValue = "ValidationFailed";
        private const string SucceededValue = "Succeeded";

        /// <summary> Unknown. </summary>
        public static ArtifactManifestState Unknown { get; } = new ArtifactManifestState(UnknownValue);
        /// <summary> Uploading. </summary>
        public static ArtifactManifestState Uploading { get; } = new ArtifactManifestState(UploadingValue);
        /// <summary> Uploaded. </summary>
        public static ArtifactManifestState Uploaded { get; } = new ArtifactManifestState(UploadedValue);
        /// <summary> Validating. </summary>
        public static ArtifactManifestState Validating { get; } = new ArtifactManifestState(ValidatingValue);
        /// <summary> ValidationFailed. </summary>
        public static ArtifactManifestState ValidationFailed { get; } = new ArtifactManifestState(ValidationFailedValue);
        /// <summary> Succeeded. </summary>
        public static ArtifactManifestState Succeeded { get; } = new ArtifactManifestState(SucceededValue);
        /// <summary> Determines if two <see cref="ArtifactManifestState"/> values are the same. </summary>
        public static bool operator ==(ArtifactManifestState left, ArtifactManifestState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArtifactManifestState"/> values are not the same. </summary>
        public static bool operator !=(ArtifactManifestState left, ArtifactManifestState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArtifactManifestState"/>. </summary>
        public static implicit operator ArtifactManifestState(string value) => new ArtifactManifestState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArtifactManifestState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArtifactManifestState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
