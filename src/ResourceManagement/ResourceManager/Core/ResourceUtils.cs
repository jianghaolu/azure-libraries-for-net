﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using System;
using System.Linq;

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Core
{
    public static class ResourceUtils
    {
        public static string GroupFromResourceId(string id)
        {
            return (!string.IsNullOrWhiteSpace(id)) ? ResourceId.FromString(id).ResourceGroupName : null;
        }

        public static string SubscriptionFromResourceId(string id)
        {
            return (id != null) ? ResourceId.FromString(id).SubscriptionId : null;
        }

        public static string ResourceProviderFromResourceId(string id)
        {
            return (!string.IsNullOrWhiteSpace(id)) ? ResourceId.FromString(id).ProviderNamespace : null;
        }

        public static string ResourceTypeFromResourceId(string id)
        {
            return (!string.IsNullOrWhiteSpace(id)) ? ResourceId.FromString(id).ResourceType : null;
        }

        public static string NameFromResourceId(string id)
        {
            return (!string.IsNullOrWhiteSpace(id)) ? ResourceId.FromString(id).Name : null;
        }

        public static string ParentResourcePathFromResourceId(string id)
        {
            return (!string.IsNullOrWhiteSpace(id)) ? ResourceId.FromString(id)?.Parent?.Id : null;
        }

        /// <summary>
        /// Extracts parent resource path from a resource ID string.
        /// </summary>
        /// <example>
        /// "subscriptions/SSS/resourcegroups/RRR/foos/foo/bars/bar" will return "foos/foo".
        /// </example>
        /// <param name="id">a resource ID</param>
        /// <returns>relative parent path</returns>
        public static string ParentRelativePathFromResourceId(string id)
        {
            if (id == null)
            {
                return null;
            }

            ResourceId parent = ResourceId.FromString(id).Parent;
            if (parent != null)
            {
                return parent.ResourceType + "/" + parent.Name;
            }

            return "";
        }

        public static string ConstructResourceId(
            string subscriptionId,
            string resourceGroupName,
            string resourceProviderNamespace,
            string resourceType,
            string resourceName,
            string parentResourcePath)
        {
            string prefixedParentPath = parentResourcePath;
            if (!string.IsNullOrEmpty(parentResourcePath))
            {
                prefixedParentPath = "/" + parentResourcePath;
            }
            return string.Format(
                    "/subscriptions/{0}/resourcegroups/{1}/providers/{2}{3}/{4}/{5}",
                    subscriptionId,
                    resourceGroupName,
                    resourceProviderNamespace,
                    prefixedParentPath,
                    resourceType,
                    resourceName);
        }

        public static string CreateODataFilterForTags(string tagName, string tagValue)
        {
            if (tagName == null)
            {
                return null;
            }

            else if (tagValue == null)
            {
                return $"tagname eq '{tagName.Trim('\'')}'";
            }
            else
            {
                return $"tagname eq '{tagName.Trim('\'')}' and tagvalue eq '{tagValue.Trim('\'')}'";
            }
        }


        /**
         * Try to guess the environment the client is authenticated to based
         * on the information on the rest client.
         * @param restClient the RestClient instance
         * @return the non-null AzureEnvironment
         */
        public static AzureEnvironment GuessAzureEnvironment(RestClient restClient)
        {
            AzureEnvironment environment = null;
            if (restClient.Credentials is AzureCredentials)
            {
                environment = restClient.Credentials.Environment;
            }
            else
            {
                string baseUrl = restClient.BaseUri;
                if (AzureEnvironment.AzureGlobalCloud.ResourceManagerEndpoint.ToLower().Contains(baseUrl.ToLower()))
                {
                    environment = AzureEnvironment.AzureGlobalCloud;
                }
                else if (AzureEnvironment.AzureChinaCloud.ResourceManagerEndpoint.ToLower().Contains(baseUrl.ToLower()))
                {
                    environment = AzureEnvironment.AzureChinaCloud;
                }
                else if (AzureEnvironment.AzureGermanCloud.ResourceManagerEndpoint.ToLower().Contains(baseUrl.ToLower()))
                {
                    environment = AzureEnvironment.AzureGermanCloud;
                }
                else if (AzureEnvironment.AzureUSGovernment.ResourceManagerEndpoint.ToLower().Contains(baseUrl.ToLower()))
                {
                    environment = AzureEnvironment.AzureUSGovernment;
                }
                if (environment == null)
                {
                    throw new NotSupportedException("Unknown resource manager endpoint " + baseUrl);
                }
            }
            return environment;
        }

    }
}
