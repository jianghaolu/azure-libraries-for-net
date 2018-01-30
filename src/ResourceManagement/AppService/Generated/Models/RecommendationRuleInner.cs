// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a recommendation rule that the recommendation engine can
    /// perform.
    /// </summary>
    public partial class RecommendationRuleInner
    {
        /// <summary>
        /// Initializes a new instance of the RecommendationRuleInner class.
        /// </summary>
        public RecommendationRuleInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendationRuleInner class.
        /// </summary>
        /// <param name="name">Unique name of the rule.</param>
        /// <param name="displayName">UI friendly name of the rule.</param>
        /// <param name="message">Localized name of the rule (Good for
        /// UI).</param>
        /// <param name="recommendationId">Recommendation ID of an associated
        /// recommendation object tied to the rule, if exists.
        /// If such an object doesn't exist, it is set to null.</param>
        /// <param name="description">Localized detailed description of the
        /// rule.</param>
        /// <param name="actionName">Name of action that is recommended by this
        /// rule in string.</param>
        /// <param name="level">Level of impact indicating how critical this
        /// rule is. Possible values include: 'Critical', 'Warning',
        /// 'Information', 'NonUrgentSuggestion'</param>
        /// <param name="channels">List of available channels that this rule
        /// applies. Possible values include: 'Notification', 'Api', 'Email',
        /// 'Webhook', 'All'</param>
        /// <param name="tags">An array of category tags that the rule
        /// contains.</param>
        /// <param name="isDynamic">True if this is associated with a
        /// dynamically added rule</param>
        /// <param name="extensionName">Extension name of the portal if exists.
        /// Applicable to dynamic rule only.</param>
        /// <param name="bladeName">Deep link to a blade on the portal.
        /// Applicable to dynamic rule only.</param>
        /// <param name="forwardLink">Forward link to an external document
        /// associated with the rule. Applicable to dynamic rule only.</param>
        public RecommendationRuleInner(string name = default(string), string displayName = default(string), string message = default(string), System.Guid? recommendationId = default(System.Guid?), string description = default(string), string actionName = default(string), NotificationLevel? level = default(NotificationLevel?), Channels? channels = default(Channels?), IList<string> tags = default(IList<string>), bool? isDynamic = default(bool?), string extensionName = default(string), string bladeName = default(string), string forwardLink = default(string))
        {
            Name = name;
            DisplayName = displayName;
            Message = message;
            RecommendationId = recommendationId;
            Description = description;
            ActionName = actionName;
            Level = level;
            Channels = channels;
            Tags = tags;
            IsDynamic = isDynamic;
            ExtensionName = extensionName;
            BladeName = bladeName;
            ForwardLink = forwardLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets UI friendly name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized name of the rule (Good for UI).
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets recommendation ID of an associated recommendation
        /// object tied to the rule, if exists.
        /// If such an object doesn't exist, it is set to null.
        /// </summary>
        [JsonProperty(PropertyName = "recommendationId")]
        public System.Guid? RecommendationId { get; set; }

        /// <summary>
        /// Gets or sets localized detailed description of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of action that is recommended by this rule in
        /// string.
        /// </summary>
        [JsonProperty(PropertyName = "actionName")]
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or sets level of impact indicating how critical this rule is.
        /// Possible values include: 'Critical', 'Warning', 'Information',
        /// 'NonUrgentSuggestion'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public NotificationLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets list of available channels that this rule applies.
        /// Possible values include: 'Notification', 'Api', 'Email', 'Webhook',
        /// 'All'
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public Channels? Channels { get; set; }

        /// <summary>
        /// Gets or sets an array of category tags that the rule contains.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets true if this is associated with a dynamically added
        /// rule
        /// </summary>
        [JsonProperty(PropertyName = "isDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// Gets or sets extension name of the portal if exists. Applicable to
        /// dynamic rule only.
        /// </summary>
        [JsonProperty(PropertyName = "extensionName")]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets deep link to a blade on the portal. Applicable to
        /// dynamic rule only.
        /// </summary>
        [JsonProperty(PropertyName = "bladeName")]
        public string BladeName { get; set; }

        /// <summary>
        /// Gets or sets forward link to an external document associated with
        /// the rule. Applicable to dynamic rule only.
        /// </summary>
        [JsonProperty(PropertyName = "forwardLink")]
        public string ForwardLink { get; set; }

    }
}
