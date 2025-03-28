// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The blob service properties for change feed events.
/// </summary>
public partial class BlobServiceChangeFeed : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether change feed event logging is enabled for the Blob
    /// service.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Indicates the duration of changeFeed retention in days. Minimum value
    /// is 1 day and maximum value is 146000 days (400 years). A null value
    /// indicates an infinite retention of the change feed.
    /// </summary>
    public BicepValue<int> RetentionInDays 
    {
        get { Initialize(); return _retentionInDays!; }
        set { Initialize(); _retentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionInDays;

    /// <summary>
    /// Creates a new BlobServiceChangeFeed.
    /// </summary>
    public BlobServiceChangeFeed()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of BlobServiceChangeFeed.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _retentionInDays = DefineProperty<int>("RetentionInDays", ["retentionInDays"]);
    }
}
