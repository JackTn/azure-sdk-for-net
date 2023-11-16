// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Represents the capacity a job in this channel will consume from a worker. </summary>
    public partial class RouterChannel
    {
        /// <summary> Initializes a new instance of RouterChannel. </summary>
        /// <param name="channelId"> Id of a channel. </param>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        internal RouterChannel(string channelId, int capacityCostPerJob, int? maxNumberOfJobs)
        {
            ChannelId = channelId;
            CapacityCostPerJob = capacityCostPerJob;
            MaxNumberOfJobs = maxNumberOfJobs;
        }

        /// <summary> Id of a channel. </summary>
        public string ChannelId { get; }
        /// <summary> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </summary>
        public int CapacityCostPerJob { get; }
    }
}
