// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceNetworking
{
    public partial class TrafficControllerFrontendResource : IJsonModel<TrafficControllerFrontendData>
    {
        void IJsonModel<TrafficControllerFrontendData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TrafficControllerFrontendData>)Data).Write(writer, options);

        TrafficControllerFrontendData IJsonModel<TrafficControllerFrontendData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TrafficControllerFrontendData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TrafficControllerFrontendData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TrafficControllerFrontendData IPersistableModel<TrafficControllerFrontendData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TrafficControllerFrontendData>(data, options);

        string IPersistableModel<TrafficControllerFrontendData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TrafficControllerFrontendData>)Data).GetFormatFromOptions(options);
    }
}
