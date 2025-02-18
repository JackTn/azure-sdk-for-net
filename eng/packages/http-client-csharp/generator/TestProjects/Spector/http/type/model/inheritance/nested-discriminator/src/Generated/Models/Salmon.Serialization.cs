// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Model.Inheritance.NestedDiscriminator.Models
{
    public partial class Salmon : IJsonModel<Salmon>
    {
        void IJsonModel<Salmon>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Salmon IJsonModel<Salmon>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected override Fish JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Salmon>.Write(ModelReaderWriterOptions options) => throw null;

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Salmon IPersistableModel<Salmon>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected override Fish PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Salmon>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="salmon"> The <see cref="Salmon"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Salmon salmon) => throw null;

        public static explicit operator Salmon(Response result) => throw null;
    }
}
