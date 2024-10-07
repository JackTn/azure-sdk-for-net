// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Roles;

/// <summary>
/// FederatedIdentityCredential.
/// </summary>
public partial class FederatedIdentityCredential : Resource
{
    /// <summary>
    /// The name of the federated identity credential resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The list of audiences that can appear in the issued token.
    /// </summary>
    public BicepList<string> Audiences { get => _audiences; set => _audiences.Assign(value); }
    private readonly BicepList<string> _audiences;

    /// <summary>
    /// The URL of the issuer to be trusted.
    /// </summary>
    public BicepValue<Uri> IssuerUri { get => _issuerUri; set => _issuerUri.Assign(value); }
    private readonly BicepValue<Uri> _issuerUri;

    /// <summary>
    /// The identifier of the external identity.
    /// </summary>
    public BicepValue<string> Subject { get => _subject; set => _subject.Assign(value); }
    private readonly BicepValue<string> _subject;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent UserAssignedIdentity.
    /// </summary>
    public UserAssignedIdentity? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<UserAssignedIdentity> _parent;

    /// <summary>
    /// Creates a new FederatedIdentityCredential.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the FederatedIdentityCredential
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FederatedIdentityCredential.</param>
    public FederatedIdentityCredential(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.ManagedIdentity/userAssignedIdentities/federatedIdentityCredentials", resourceVersion ?? "2023-01-31")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _audiences = BicepList<string>.DefineProperty(this, "Audiences", ["properties", "audiences"]);
        _issuerUri = BicepValue<Uri>.DefineProperty(this, "IssuerUri", ["properties", "issuer"]);
        _subject = BicepValue<string>.DefineProperty(this, "Subject", ["properties", "subject"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<UserAssignedIdentity>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported FederatedIdentityCredential resource versions.
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
    }

    /// <summary>
    /// Creates a reference to an existing FederatedIdentityCredential.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the FederatedIdentityCredential
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FederatedIdentityCredential.</param>
    /// <returns>The existing FederatedIdentityCredential resource.</returns>
    public static FederatedIdentityCredential FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
