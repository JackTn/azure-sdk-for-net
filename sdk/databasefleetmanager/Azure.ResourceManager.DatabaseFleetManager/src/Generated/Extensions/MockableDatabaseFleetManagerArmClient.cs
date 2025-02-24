// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDatabaseFleetManagerArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDatabaseFleetManagerArmClient"/> class for mocking. </summary>
        protected MockableDatabaseFleetManagerArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDatabaseFleetManagerArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDatabaseFleetManagerArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDatabaseFleetManagerArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetDatabaseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="FleetDatabaseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetDatabaseResource"/> object. </returns>
        public virtual FleetDatabaseResource GetFleetDatabaseResource(ResourceIdentifier id)
        {
            FleetDatabaseResource.ValidateResourceId(id);
            return new FleetDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetspaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetspaceResource.CreateResourceIdentifier" /> to create a <see cref="FleetspaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetspaceResource"/> object. </returns>
        public virtual FleetspaceResource GetFleetspaceResource(ResourceIdentifier id)
        {
            FleetspaceResource.ValidateResourceId(id);
            return new FleetspaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetResource.CreateResourceIdentifier" /> to create a <see cref="FleetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetResource"/> object. </returns>
        public virtual FleetResource GetFleetResource(ResourceIdentifier id)
        {
            FleetResource.ValidateResourceId(id);
            return new FleetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirewallRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="FirewallRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirewallRuleResource"/> object. </returns>
        public virtual FirewallRuleResource GetFirewallRuleResource(ResourceIdentifier id)
        {
            FirewallRuleResource.ValidateResourceId(id);
            return new FirewallRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FleetTierResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FleetTierResource.CreateResourceIdentifier" /> to create a <see cref="FleetTierResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FleetTierResource"/> object. </returns>
        public virtual FleetTierResource GetFleetTierResource(ResourceIdentifier id)
        {
            FleetTierResource.ValidateResourceId(id);
            return new FleetTierResource(Client, id);
        }
    }
}
