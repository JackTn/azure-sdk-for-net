// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the LoadBalancingRule data model.
    /// A load balancing rule for a load balancer.
    /// </summary>
    public partial class LoadBalancingRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancingRuleData"/>. </summary>
        public LoadBalancingRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancingRuleData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Properties of load balancer load balancing rule. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal LoadBalancingRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, LoadBalancingRuleProperties properties, ETag? etag) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            Properties = properties;
            ETag = etag;
        }

        /// <summary> Properties of load balancer load balancing rule. </summary>
        public LoadBalancingRuleProperties Properties { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
