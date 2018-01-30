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
    /// ARM resource for a domain.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DomainPatchResourceInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DomainPatchResourceInner class.
        /// </summary>
        public DomainPatchResourceInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainPatchResourceInner class.
        /// </summary>
        /// <param name="contactAdmin">Administrative contact.</param>
        /// <param name="contactBilling">Billing contact.</param>
        /// <param name="contactRegistrant">Registrant contact.</param>
        /// <param name="contactTech">Technical contact.</param>
        /// <param name="consent">Legal agreement consent.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="registrationStatus">Domain registration status.
        /// Possible values include: 'Active', 'Awaiting', 'Cancelled',
        /// 'Confiscated', 'Disabled', 'Excluded', 'Expired', 'Failed', 'Held',
        /// 'Locked', 'Parked', 'Pending', 'Reserved', 'Reverted', 'Suspended',
        /// 'Transferred', 'Unknown', 'Unlocked', 'Unparked', 'Updated',
        /// 'JsonConverterFailed'</param>
        /// <param name="provisioningState">Domain provisioning state. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'InProgress',
        /// 'Deleting'</param>
        /// <param name="nameServers">Name servers.</param>
        /// <param name="privacy">&lt;code&gt;true&lt;/code&gt; if domain
        /// privacy is enabled for this domain; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="createdTime">Domain creation timestamp.</param>
        /// <param name="expirationTime">Domain expiration timestamp.</param>
        /// <param name="lastRenewedTime">Timestamp when the domain was renewed
        /// last time.</param>
        /// <param name="autoRenew">&lt;code&gt;true&lt;/code&gt; if the domain
        /// should be automatically renewed; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param
        /// name="readyForDnsRecordManagement">&lt;code&gt;true&lt;/code&gt; if
        /// Azure can assign this domain to App Service apps; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;. This value will be
        /// &lt;code&gt;true&lt;/code&gt; if domain registration status is
        /// active and
        /// it is hosted on name servers Azure has programmatic access
        /// to.</param>
        /// <param name="managedHostNames">All hostnames derived from the
        /// domain and assigned to Azure resources.</param>
        /// <param name="domainNotRenewableReasons">Reasons why domain is not
        /// renewable.</param>
        /// <param name="dnsType">Current DNS type. Possible values include:
        /// 'AzureDns', 'DefaultDomainRegistrarDns'</param>
        /// <param name="dnsZoneId">Azure DNS Zone to use</param>
        /// <param name="targetDnsType">Target DNS type (would be used for
        /// migration). Possible values include: 'AzureDns',
        /// 'DefaultDomainRegistrarDns'</param>
        public DomainPatchResourceInner(Contact contactAdmin, Contact contactBilling, Contact contactRegistrant, Contact contactTech, DomainPurchaseConsent consent, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), DomainStatus? registrationStatus = default(DomainStatus?), ProvisioningState? provisioningState = default(ProvisioningState?), IList<string> nameServers = default(IList<string>), bool? privacy = default(bool?), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), System.DateTime? lastRenewedTime = default(System.DateTime?), bool? autoRenew = default(bool?), bool? readyForDnsRecordManagement = default(bool?), IList<HostName> managedHostNames = default(IList<HostName>), IList<string> domainNotRenewableReasons = default(IList<string>), DnsType? dnsType = default(DnsType?), string dnsZoneId = default(string), DnsType? targetDnsType = default(DnsType?), string authCode = default(string))
            : base(id, name, kind, type)
        {
            ContactAdmin = contactAdmin;
            ContactBilling = contactBilling;
            ContactRegistrant = contactRegistrant;
            ContactTech = contactTech;
            RegistrationStatus = registrationStatus;
            ProvisioningState = provisioningState;
            NameServers = nameServers;
            Privacy = privacy;
            CreatedTime = createdTime;
            ExpirationTime = expirationTime;
            LastRenewedTime = lastRenewedTime;
            AutoRenew = autoRenew;
            ReadyForDnsRecordManagement = readyForDnsRecordManagement;
            ManagedHostNames = managedHostNames;
            Consent = consent;
            DomainNotRenewableReasons = domainNotRenewableReasons;
            DnsType = dnsType;
            DnsZoneId = dnsZoneId;
            TargetDnsType = targetDnsType;
            AuthCode = authCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets administrative contact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactAdmin")]
        public Contact ContactAdmin { get; set; }

        /// <summary>
        /// Gets or sets billing contact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactBilling")]
        public Contact ContactBilling { get; set; }

        /// <summary>
        /// Gets or sets registrant contact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactRegistrant")]
        public Contact ContactRegistrant { get; set; }

        /// <summary>
        /// Gets or sets technical contact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactTech")]
        public Contact ContactTech { get; set; }

        /// <summary>
        /// Gets domain registration status. Possible values include: 'Active',
        /// 'Awaiting', 'Cancelled', 'Confiscated', 'Disabled', 'Excluded',
        /// 'Expired', 'Failed', 'Held', 'Locked', 'Parked', 'Pending',
        /// 'Reserved', 'Reverted', 'Suspended', 'Transferred', 'Unknown',
        /// 'Unlocked', 'Unparked', 'Updated', 'JsonConverterFailed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationStatus")]
        public DomainStatus? RegistrationStatus { get; private set; }

        /// <summary>
        /// Gets domain provisioning state. Possible values include:
        /// 'Succeeded', 'Failed', 'Canceled', 'InProgress', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets name servers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nameServers")]
        public IList<string> NameServers { get; private set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// domain privacy is enabled for this domain; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacy")]
        public bool? Privacy { get; set; }

        /// <summary>
        /// Gets domain creation timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets domain expiration timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets timestamp when the domain was renewed last time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastRenewedTime")]
        public System.DateTime? LastRenewedTime { get; private set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the
        /// domain should be automatically renewed; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoRenew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if Azure can
        /// assign this domain to App Service apps; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;. This value will be
        /// &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if domain
        /// registration status is active and
        /// it is hosted on name servers Azure has programmatic access to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readyForDnsRecordManagement")]
        public bool? ReadyForDnsRecordManagement { get; private set; }

        /// <summary>
        /// Gets all hostnames derived from the domain and assigned to Azure
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedHostNames")]
        public IList<HostName> ManagedHostNames { get; private set; }

        /// <summary>
        /// Gets or sets legal agreement consent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consent")]
        public DomainPurchaseConsent Consent { get; set; }

        /// <summary>
        /// Gets reasons why domain is not renewable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainNotRenewableReasons")]
        public IList<string> DomainNotRenewableReasons { get; private set; }

        /// <summary>
        /// Gets or sets current DNS type. Possible values include: 'AzureDns',
        /// 'DefaultDomainRegistrarDns'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsType")]
        public DnsType? DnsType { get; set; }

        /// <summary>
        /// Gets or sets azure DNS Zone to use
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsZoneId")]
        public string DnsZoneId { get; set; }

        /// <summary>
        /// Gets or sets target DNS type (would be used for migration).
        /// Possible values include: 'AzureDns', 'DefaultDomainRegistrarDns'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetDnsType")]
        public DnsType? TargetDnsType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.authCode")]
        public string AuthCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContactAdmin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactAdmin");
            }
            if (ContactBilling == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactBilling");
            }
            if (ContactRegistrant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactRegistrant");
            }
            if (ContactTech == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactTech");
            }
            if (Consent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Consent");
            }
            if (ContactAdmin != null)
            {
                ContactAdmin.Validate();
            }
            if (ContactBilling != null)
            {
                ContactBilling.Validate();
            }
            if (ContactRegistrant != null)
            {
                ContactRegistrant.Validate();
            }
            if (ContactTech != null)
            {
                ContactTech.Validate();
            }
        }
    }
}
