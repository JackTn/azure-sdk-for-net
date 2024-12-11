// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.IoTOperations
{
    public partial class InstanceResource : IJsonModel<InstanceResourceData>
    {
        void IJsonModel<InstanceResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<InstanceResourceData>)Data).Write(writer, options);

        InstanceResourceData IJsonModel<InstanceResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<InstanceResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<InstanceResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        InstanceResourceData IPersistableModel<InstanceResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<InstanceResourceData>(data, options);

        string IPersistableModel<InstanceResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<InstanceResourceData>)Data).GetFormatFromOptions(options);
    }
}
