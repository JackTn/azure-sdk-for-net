﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;

namespace System.ClientModel.Primitives;

internal abstract class CollectionWriter
{
    internal static CollectionWriter GetCollectionWriter(IEnumerable enumerable, ModelReaderWriterOptions options)
    {
        if (options.Format != "J" && options.Format != "W")
        {
            throw new InvalidOperationException($"Format '{options.Format}' is not supported only 'J' or 'W' format can be written as collections");
        }

        if (options.Format == "J")
        {
            return new JsonCollectionWriter();
        }
        else // W format
        {
            var persistableModel = GetIPersistableModel(enumerable);
            var wireFormat = persistableModel.GetFormatFromOptions(options);
            if (wireFormat == "J" && persistableModel is IJsonModel<object>)
            {
                return new JsonCollectionWriter();
            }
            throw new InvalidOperationException($"{persistableModel.GetType().FullName} has a wire format of '{wireFormat}' it must be 'J' to be written as a collection");
        }
    }

    private static IPersistableModel<object> GetIPersistableModel(IEnumerable enumerable)
    {
        var enumerator = enumerable.GetEnumerator();
        if (enumerator.MoveNext())
        {
            object first = enumerable is IDictionary dictionary ? dictionary[enumerator.Current]! : enumerator.Current;

            if (first is IEnumerable nextEnumerable)
            {
                return GetIPersistableModel(nextEnumerable);
            }
            else if (first is IPersistableModel<object> persistableModel)
            {
                return persistableModel;
            }
            else
            {
                throw new InvalidOperationException($"Unable to write {enumerable.GetType().FullName} can only write collections of IPersistableModel");
            }
        }
        else
        {
            throw new InvalidOperationException($"Can't use format 'W' format on an empty collection please specify a concrete format");
        }
    }

    internal abstract BinaryData Write(IEnumerable enumerable, ModelReaderWriterOptions options);
}
