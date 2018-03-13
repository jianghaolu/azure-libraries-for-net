// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="name">The plan ID.</param>
        /// <param name="publisher">The publisher ID.</param>
        /// <param name="product">The offer ID.</param>
        /// <param name="promotionCode">The promotion code.</param>
        /// <param name="version">The plan's version.</param>
        public Plan(string name = default(string), string publisher = default(string), string product = default(string), string promotionCode = default(string), string version = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the offer ID.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the promotion code.
        /// </summary>
        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Gets or sets the plan's version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
