// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metadata for a metric.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MetricDefinitionInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinitionInner class.
        /// </summary>
        public MetricDefinitionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinitionInner class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="metricDefinitionName">Name of the metric.</param>
        /// <param name="unit">Unit of the metric.</param>
        /// <param name="primaryAggregationType">Primary aggregation
        /// type.</param>
        /// <param name="metricAvailabilities">List of time grains supported
        /// for the metric together with retention period.</param>
        /// <param name="displayName">Friendly name shown in the UI.</param>
        public MetricDefinitionInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string metricDefinitionName = default(string), string unit = default(string), string primaryAggregationType = default(string), IList<MetricAvailabilily> metricAvailabilities = default(IList<MetricAvailabilily>), string displayName = default(string))
            : base(id, name, kind, type)
        {
            MetricDefinitionName = metricDefinitionName;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string MetricDefinitionName { get; private set; }

        /// <summary>
        /// Gets unit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets primary aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAggregationType")]
        public string PrimaryAggregationType { get; private set; }

        /// <summary>
        /// Gets list of time grains supported for the metric together with
        /// retention period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricAvailabilities")]
        public IList<MetricAvailabilily> MetricAvailabilities { get; private set; }

        /// <summary>
        /// Gets friendly name shown in the UI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

    }
}
