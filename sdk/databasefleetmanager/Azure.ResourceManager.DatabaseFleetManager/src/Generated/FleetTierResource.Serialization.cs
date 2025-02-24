// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DatabaseFleetManager
{
    public partial class FleetTierResource : IJsonModel<FleetTierData>
    {
        void IJsonModel<FleetTierData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FleetTierData>)Data).Write(writer, options);

        FleetTierData IJsonModel<FleetTierData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FleetTierData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FleetTierData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FleetTierData IPersistableModel<FleetTierData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FleetTierData>(data, options);

        string IPersistableModel<FleetTierData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FleetTierData>)Data).GetFormatFromOptions(options);
    }
}
