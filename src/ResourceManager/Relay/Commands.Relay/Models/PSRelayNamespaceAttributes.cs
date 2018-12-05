// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Commands.Relay.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using Azure.Management.Relay.Models;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Description of a Namespace resource.
    /// </summary>
    public partial class PSRelayNamespaceAttributes : PSTrackedResourceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the RelayNamespace class.
        /// </summary>
        public PSRelayNamespaceAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelayNamespace class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Provisioning state of the
        /// namespace.</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// Service Bus operations.</param>
        /// <param name="metricId">Identifier for Azure Insights
        /// metrics</param>
        public PSRelayNamespaceAttributes(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string metricId = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
        }

        public PSRelayNamespaceAttributes(RelayNamespace relaynamespace)
        {
            Location = relaynamespace.Location;
            Id = relaynamespace.Id;
            Name = relaynamespace.Name;
            Type = relaynamespace.Type;
            Tags = relaynamespace.Tags;
            ProvisioningState = relaynamespace.ProvisioningState.ToString();
            CreatedAt = relaynamespace.CreatedAt;
            UpdatedAt = relaynamespace.UpdatedAt;
            ServiceBusEndpoint = relaynamespace.ServiceBusEndpoint;
            MetricId = relaynamespace.MetricId;
            ResourceGroup = Regex.Split(relaynamespace.Id, @"/")[4];
        }


        /// <summary>
        /// Gets the resourcegroup name
        /// </summary>
        public string ResourceGroup { get; }

        /// <summary>
        /// Static constructor for RelayNamespaceAttributes class.
        /// </summary>
        static PSRelayNamespaceAttributes()
        {
            Sku = new PSSkuAttributes();
        }

        /// <summary>
        /// Gets provisioning state of the namespace.
        /// </summary>
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets the time the namespace was created.
        /// </summary>
        public System.DateTime? CreatedAt { get; protected set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        public System.DateTime? UpdatedAt { get; protected set; }

        /// <summary>
        /// Gets endpoint you can use to perform Service Bus operations.
        /// </summary>
        public string ServiceBusEndpoint { get; protected set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; protected set; }

        /// <summary>
        /// Sku of the Namespace.
        /// </summary>
        public static PSSkuAttributes Sku { get; private set; }
        
    }
}

