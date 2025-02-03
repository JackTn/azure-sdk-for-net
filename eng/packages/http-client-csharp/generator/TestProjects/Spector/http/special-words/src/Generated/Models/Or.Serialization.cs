// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace SpecialWords.Models
{
    public partial class Or : IJsonModel<Or>
    {
        void IJsonModel<Or>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Or IJsonModel<Or>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Or JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Or>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Or IPersistableModel<Or>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Or PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Or>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="or"> The <see cref="Or"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Or @or) => throw null;

        public static explicit operator Or(Response result) => throw null;
    }
}
