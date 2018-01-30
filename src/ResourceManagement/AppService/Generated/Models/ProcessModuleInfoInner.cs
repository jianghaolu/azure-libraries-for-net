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
    /// Process Module Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProcessModuleInfoInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the ProcessModuleInfoInner class.
        /// </summary>
        public ProcessModuleInfoInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessModuleInfoInner class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="baseAddress">Base address. Used as module identifier
        /// in ARM resource URI.</param>
        /// <param name="fileName">File name.</param>
        /// <param name="href">HRef URI.</param>
        /// <param name="filePath">File path.</param>
        /// <param name="moduleMemorySize">Module memory size.</param>
        /// <param name="fileVersion">File version.</param>
        /// <param name="fileDescription">File description.</param>
        /// <param name="product">Product name.</param>
        /// <param name="productVersion">Product version.</param>
        /// <param name="isDebug">Is debug?</param>
        /// <param name="language">Module language (locale).</param>
        public ProcessModuleInfoInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string baseAddress = default(string), string fileName = default(string), string href = default(string), string filePath = default(string), int? moduleMemorySize = default(int?), string fileVersion = default(string), string fileDescription = default(string), string product = default(string), string productVersion = default(string), bool? isDebug = default(bool?), string language = default(string))
            : base(id, name, kind, type)
        {
            BaseAddress = baseAddress;
            FileName = fileName;
            Href = href;
            FilePath = filePath;
            ModuleMemorySize = moduleMemorySize;
            FileVersion = fileVersion;
            FileDescription = fileDescription;
            Product = product;
            ProductVersion = productVersion;
            IsDebug = isDebug;
            Language = language;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base address. Used as module identifier in ARM
        /// resource URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.baseAddress")]
        public string BaseAddress { get; set; }

        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets hRef URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets file path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets module memory size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.moduleMemorySize")]
        public int? ModuleMemorySize { get; set; }

        /// <summary>
        /// Gets or sets file version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileVersion")]
        public string FileVersion { get; set; }

        /// <summary>
        /// Gets or sets file description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileDescription")]
        public string FileDescription { get; set; }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets product version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productVersion")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// Gets or sets is debug?
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDebug")]
        public bool? IsDebug { get; set; }

        /// <summary>
        /// Gets or sets module language (locale).
        /// </summary>
        [JsonProperty(PropertyName = "properties.language")]
        public string Language { get; set; }

    }
}
