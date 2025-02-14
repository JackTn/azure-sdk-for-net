// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Model.Inheritance.Recursive.Models
{
    public partial class Element : IJsonModel<Element>
    {
        void IJsonModel<Element>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Element IJsonModel<Element>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Element JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Element>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Element IPersistableModel<Element>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Element PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Element>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="element"> The <see cref="Element"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Element element) => throw null;

        public static explicit operator Element(Response result) => throw null;
    }
}
