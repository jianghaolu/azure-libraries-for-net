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
    using System.Linq;

    /// <summary>
    /// Triggered Web Job Run Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TriggeredJobRun : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the TriggeredJobRun class.
        /// </summary>
        public TriggeredJobRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggeredJobRun class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="triggeredJobRunId">Job ID.</param>
        /// <param name="triggeredJobRunName">Job name.</param>
        /// <param name="status">Job status. Possible values include:
        /// 'Success', 'Failed', 'Error'</param>
        /// <param name="startTime">Start time.</param>
        /// <param name="endTime">End time.</param>
        /// <param name="duration">Job duration.</param>
        /// <param name="outputUrl">Output URL.</param>
        /// <param name="errorUrl">Error URL.</param>
        /// <param name="url">Job URL.</param>
        /// <param name="jobName">Job name.</param>
        /// <param name="trigger">Job trigger.</param>
        public TriggeredJobRun(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string triggeredJobRunId = default(string), string triggeredJobRunName = default(string), TriggeredWebJobStatus? status = default(TriggeredWebJobStatus?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string duration = default(string), string outputUrl = default(string), string errorUrl = default(string), string url = default(string), string jobName = default(string), string trigger = default(string))
            : base(id, name, kind, type)
        {
            TriggeredJobRunId = triggeredJobRunId;
            TriggeredJobRunName = triggeredJobRunName;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            OutputUrl = outputUrl;
            ErrorUrl = errorUrl;
            Url = url;
            JobName = jobName;
            Trigger = trigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets job ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string TriggeredJobRunId { get; set; }

        /// <summary>
        /// Gets job name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string TriggeredJobRunName { get; private set; }

        /// <summary>
        /// Gets or sets job status. Possible values include: 'Success',
        /// 'Failed', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public TriggeredWebJobStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets job duration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets output URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputUrl")]
        public string OutputUrl { get; set; }

        /// <summary>
        /// Gets or sets error URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorUrl")]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Gets or sets job URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets job name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobName")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets job trigger.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trigger")]
        public string Trigger { get; set; }

    }
}
