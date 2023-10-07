// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Labeling data configuration definition. </summary>
    public partial class LabelingDataConfiguration
    {
        /// <summary> Initializes a new instance of LabelingDataConfiguration. </summary>
        public LabelingDataConfiguration()
        {
        }

        /// <summary> Initializes a new instance of LabelingDataConfiguration. </summary>
        /// <param name="dataId"> Resource Id of the data asset to perform labeling. </param>
        /// <param name="incrementalDataRefresh"> Indicates whether to enable incremental data refresh. </param>
        internal LabelingDataConfiguration(string dataId, IncrementalDataRefresh? incrementalDataRefresh)
        {
            DataId = dataId;
            IncrementalDataRefresh = incrementalDataRefresh;
        }

        /// <summary> Resource Id of the data asset to perform labeling. </summary>
        public string DataId { get; set; }
        /// <summary> Indicates whether to enable incremental data refresh. </summary>
        public IncrementalDataRefresh? IncrementalDataRefresh { get; set; }
    }
}
