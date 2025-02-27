﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.ClientModel.Primitives;

internal class ReflectionContext : IActivatorFactory
{
    public ModelInfo GetModelInfo(Type type)
    {
        return new ReflectionModelInfo(type);
    }
}
