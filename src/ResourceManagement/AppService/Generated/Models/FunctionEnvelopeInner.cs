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
    /// Web Job Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FunctionEnvelopeInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the FunctionEnvelopeInner class.
        /// </summary>
        public FunctionEnvelopeInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionEnvelopeInner class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="functionEnvelopeName">Function name.</param>
        /// <param name="functionAppId">Function App ID.</param>
        /// <param name="scriptRootPathHref">Script root path URI.</param>
        /// <param name="scriptHref">Script URI.</param>
        /// <param name="configHref">Config URI.</param>
        /// <param name="secretsFileHref">Secrets file URI.</param>
        /// <param name="href">Function URI.</param>
        /// <param name="config">Config information.</param>
        /// <param name="files">File list.</param>
        /// <param name="testData">Test data used when testing via the Azure
        /// Portal.</param>
        public FunctionEnvelopeInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string functionEnvelopeName = default(string), string functionAppId = default(string), string scriptRootPathHref = default(string), string scriptHref = default(string), string configHref = default(string), string secretsFileHref = default(string), string href = default(string), object config = default(object), IDictionary<string, string> files = default(IDictionary<string, string>), string testData = default(string))
            : base(id, name, kind, type)
        {
            FunctionEnvelopeName = functionEnvelopeName;
            FunctionAppId = functionAppId;
            ScriptRootPathHref = scriptRootPathHref;
            ScriptHref = scriptHref;
            ConfigHref = configHref;
            SecretsFileHref = secretsFileHref;
            Href = href;
            Config = config;
            Files = files;
            TestData = testData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets function name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string FunctionEnvelopeName { get; private set; }

        /// <summary>
        /// Gets function App ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.functionAppId")]
        public string FunctionAppId { get; private set; }

        /// <summary>
        /// Gets or sets script root path URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptRootPathHref")]
        public string ScriptRootPathHref { get; set; }

        /// <summary>
        /// Gets or sets script URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptHref")]
        public string ScriptHref { get; set; }

        /// <summary>
        /// Gets or sets config URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configHref")]
        public string ConfigHref { get; set; }

        /// <summary>
        /// Gets or sets secrets file URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secretsFileHref")]
        public string SecretsFileHref { get; set; }

        /// <summary>
        /// Gets or sets function URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets config information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.config")]
        public object Config { get; set; }

        /// <summary>
        /// Gets or sets file list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.files")]
        public IDictionary<string, string> Files { get; set; }

        /// <summary>
        /// Gets or sets test data used when testing via the Azure Portal.
        /// </summary>
        [JsonProperty(PropertyName = "properties.testData")]
        public string TestData { get; set; }

    }
}
