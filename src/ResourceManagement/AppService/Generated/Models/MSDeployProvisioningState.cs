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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MSDeployProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MSDeployProvisioningState
    {
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "canceled")]
        Canceled
    }
    internal static class MSDeployProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this MSDeployProvisioningState? value)
        {
            return value == null ? null : ((MSDeployProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MSDeployProvisioningState value)
        {
            switch( value )
            {
                case MSDeployProvisioningState.Accepted:
                    return "accepted";
                case MSDeployProvisioningState.Running:
                    return "running";
                case MSDeployProvisioningState.Succeeded:
                    return "succeeded";
                case MSDeployProvisioningState.Failed:
                    return "failed";
                case MSDeployProvisioningState.Canceled:
                    return "canceled";
            }
            return null;
        }

        internal static MSDeployProvisioningState? ParseMSDeployProvisioningState(this string value)
        {
            switch( value )
            {
                case "accepted":
                    return MSDeployProvisioningState.Accepted;
                case "running":
                    return MSDeployProvisioningState.Running;
                case "succeeded":
                    return MSDeployProvisioningState.Succeeded;
                case "failed":
                    return MSDeployProvisioningState.Failed;
                case "canceled":
                    return MSDeployProvisioningState.Canceled;
            }
            return null;
        }
    }
}
