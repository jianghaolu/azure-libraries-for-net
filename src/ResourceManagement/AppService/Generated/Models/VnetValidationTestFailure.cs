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
    /// A class that describes a test that failed during NSG and UDR
    /// validation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetValidationTestFailure : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetValidationTestFailure class.
        /// </summary>
        public VnetValidationTestFailure()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetValidationTestFailure class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="testName">The name of the test that failed.</param>
        /// <param name="details">The details of what caused the failure, e.g.
        /// the blocking rule name, etc.</param>
        public VnetValidationTestFailure(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string testName = default(string), string details = default(string))
            : base(id, name, kind, type)
        {
            TestName = testName;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the test that failed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.testName")]
        public string TestName { get; set; }

        /// <summary>
        /// Gets or sets the details of what caused the failure, e.g. the
        /// blocking rule name, etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public string Details { get; set; }

    }
}
