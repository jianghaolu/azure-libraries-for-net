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
    /// Custom domain analysis.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomHostnameAnalysisResultInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the CustomHostnameAnalysisResultInner
        /// class.
        /// </summary>
        public CustomHostnameAnalysisResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomHostnameAnalysisResultInner
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param
        /// name="isHostnameAlreadyVerified">&lt;code&gt;true&lt;/code&gt; if
        /// hostname is already verified; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="customDomainVerificationTest">DNS verification test
        /// result. Possible values include: 'Passed', 'Failed',
        /// 'Skipped'</param>
        /// <param name="customDomainVerificationFailureInfo">Raw failure
        /// information if DNS verification fails.</param>
        /// <param name="hasConflictOnScaleUnit">&lt;code&gt;true&lt;/code&gt;
        /// if there is a conflict on a scale unit; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param
        /// name="hasConflictAcrossSubscription">&lt;code&gt;true&lt;/code&gt;
        /// if htere is a conflict across subscriptions; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="conflictingAppResourceId">Name of the conflicting app
        /// on scale unit if it's within the same subscription.</param>
        /// <param name="cNameRecords">CName records controller can see for
        /// this hostname.</param>
        /// <param name="txtRecords">TXT records controller can see for this
        /// hostname.</param>
        /// <param name="aRecords">A records controller can see for this
        /// hostname.</param>
        /// <param name="alternateCNameRecords">Alternate CName records
        /// controller can see for this hostname.</param>
        /// <param name="alternateTxtRecords">Alternate TXT records controller
        /// can see for this hostname.</param>
        public CustomHostnameAnalysisResultInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? isHostnameAlreadyVerified = default(bool?), DnsVerificationTestResult? customDomainVerificationTest = default(DnsVerificationTestResult?), ErrorEntity customDomainVerificationFailureInfo = default(ErrorEntity), bool? hasConflictOnScaleUnit = default(bool?), bool? hasConflictAcrossSubscription = default(bool?), string conflictingAppResourceId = default(string), IList<string> cNameRecords = default(IList<string>), IList<string> txtRecords = default(IList<string>), IList<string> aRecords = default(IList<string>), IList<string> alternateCNameRecords = default(IList<string>), IList<string> alternateTxtRecords = default(IList<string>))
            : base(id, name, kind, type)
        {
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnScaleUnit = hasConflictOnScaleUnit;
            HasConflictAcrossSubscription = hasConflictAcrossSubscription;
            ConflictingAppResourceId = conflictingAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if hostname is
        /// already verified; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHostnameAlreadyVerified")]
        public bool? IsHostnameAlreadyVerified { get; private set; }

        /// <summary>
        /// Gets DNS verification test result. Possible values include:
        /// 'Passed', 'Failed', 'Skipped'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomainVerificationTest")]
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; private set; }

        /// <summary>
        /// Gets raw failure information if DNS verification fails.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomainVerificationFailureInfo")]
        public ErrorEntity CustomDomainVerificationFailureInfo { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if there is a
        /// conflict on a scale unit; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasConflictOnScaleUnit")]
        public bool? HasConflictOnScaleUnit { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if htere is a
        /// conflict across subscriptions; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasConflictAcrossSubscription")]
        public bool? HasConflictAcrossSubscription { get; private set; }

        /// <summary>
        /// Gets name of the conflicting app on scale unit if it's within the
        /// same subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.conflictingAppResourceId")]
        public string ConflictingAppResourceId { get; private set; }

        /// <summary>
        /// Gets or sets cName records controller can see for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cNameRecords")]
        public IList<string> CNameRecords { get; set; }

        /// <summary>
        /// Gets or sets TXT records controller can see for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.txtRecords")]
        public IList<string> TxtRecords { get; set; }

        /// <summary>
        /// Gets or sets a records controller can see for this hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.aRecords")]
        public IList<string> ARecords { get; set; }

        /// <summary>
        /// Gets or sets alternate CName records controller can see for this
        /// hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateCNameRecords")]
        public IList<string> AlternateCNameRecords { get; set; }

        /// <summary>
        /// Gets or sets alternate TXT records controller can see for this
        /// hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateTxtRecords")]
        public IList<string> AlternateTxtRecords { get; set; }

    }
}
