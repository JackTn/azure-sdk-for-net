// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Roles;

/// <summary>
/// UserAssignedIdentity.
/// </summary>
public partial class UserAssignedIdentity : Resource
{
    /// <summary>
    /// The name of the identity resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The id of the app associated with the identity. This is a random
    /// generated UUID by MSI.
    /// </summary>
    public BicepValue<Guid> ClientId { get => _clientId; }
    private readonly BicepValue<Guid> _clientId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The id of the service principal object associated with the created
    /// identity.
    /// </summary>
    public BicepValue<Guid> PrincipalId { get => _principalId; }
    private readonly BicepValue<Guid> _principalId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The id of the tenant which the identity belongs to.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Creates a new UserAssignedIdentity.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the UserAssignedIdentity resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the UserAssignedIdentity.</param>
    public UserAssignedIdentity(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.ManagedIdentity/userAssignedIdentities", resourceVersion ?? "2023-01-31")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _clientId = BicepValue<Guid>.DefineProperty(this, "ClientId", ["properties", "clientId"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _principalId = BicepValue<Guid>.DefineProperty(this, "PrincipalId", ["properties", "principalId"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["properties", "tenantId"], isOutput: true);
    }

    /// <summary>
    /// Supported UserAssignedIdentity resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-31-PREVIEW.
        /// </summary>
        public static readonly string V2023_07_31_PREVIEW = "2023-07-31-PREVIEW";

        /// <summary>
        /// 2023-01-31.
        /// </summary>
        public static readonly string V2023_01_31 = "2023-01-31";

        /// <summary>
        /// 2022-01-31-PREVIEW.
        /// </summary>
        public static readonly string V2022_01_31_PREVIEW = "2022-01-31-PREVIEW";

        /// <summary>
        /// 2021-09-30-PREVIEW.
        /// </summary>
        public static readonly string V2021_09_30_PREVIEW = "2021-09-30-PREVIEW";

        /// <summary>
        /// 2018-11-30.
        /// </summary>
        public static readonly string V2018_11_30 = "2018-11-30";

        /// <summary>
        /// 2015-08-31-PREVIEW.
        /// </summary>
        public static readonly string V2015_08_31_PREVIEW = "2015-08-31-PREVIEW";
    }

    /// <summary>
    /// Creates a reference to an existing UserAssignedIdentity.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the UserAssignedIdentity resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the UserAssignedIdentity.</param>
    /// <returns>The existing UserAssignedIdentity resource.</returns>
    public static UserAssignedIdentity FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this UserAssignedIdentity resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore);
}
