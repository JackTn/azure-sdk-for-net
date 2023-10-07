// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The NumericalPredictionDriftMetricThreshold. </summary>
    public partial class NumericalPredictionDriftMetricThreshold : PredictionDriftMetricThresholdBase
    {
        /// <summary> Initializes a new instance of NumericalPredictionDriftMetricThreshold. </summary>
        /// <param name="metric"> [Required] The numerical prediction drift metric to calculate. </param>
        public NumericalPredictionDriftMetricThreshold(NumericalPredictionDriftMetric metric)
        {
            Metric = metric;
            DataType = MonitoringFeatureDataType.Numerical;
        }

        /// <summary> Initializes a new instance of NumericalPredictionDriftMetricThreshold. </summary>
        /// <param name="dataType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="metric"> [Required] The numerical prediction drift metric to calculate. </param>
        internal NumericalPredictionDriftMetricThreshold(MonitoringFeatureDataType dataType, MonitoringThreshold threshold, NumericalPredictionDriftMetric metric) : base(dataType, threshold)
        {
            Metric = metric;
            DataType = dataType;
        }

        /// <summary> [Required] The numerical prediction drift metric to calculate. </summary>
        public NumericalPredictionDriftMetric Metric { get; set; }
    }
}
