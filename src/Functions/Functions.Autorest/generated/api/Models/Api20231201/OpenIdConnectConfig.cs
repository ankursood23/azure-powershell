// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    /// </summary>
    public partial class OpenIdConnectConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOpenIdConnectConfig,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOpenIdConnectConfigInternal
    {

        /// <summary>Backing field for <see cref="AuthorizationEndpoint" /> property.</summary>
        private string _authorizationEndpoint;

        /// <summary>The endpoint to be used to make an authorization request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string AuthorizationEndpoint { get => this._authorizationEndpoint; set => this._authorizationEndpoint = value; }

        /// <summary>Backing field for <see cref="CertificationUri" /> property.</summary>
        private string _certificationUri;

        /// <summary>The endpoint that provides the keys necessary to validate the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string CertificationUri { get => this._certificationUri; set => this._certificationUri = value; }

        /// <summary>Backing field for <see cref="Issuer" /> property.</summary>
        private string _issuer;

        /// <summary>The endpoint that issues the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Issuer { get => this._issuer; set => this._issuer = value; }

        /// <summary>Backing field for <see cref="TokenEndpoint" /> property.</summary>
        private string _tokenEndpoint;

        /// <summary>The endpoint to be used to request a token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string TokenEndpoint { get => this._tokenEndpoint; set => this._tokenEndpoint = value; }

        /// <summary>Backing field for <see cref="WellKnownOpenIdConfiguration" /> property.</summary>
        private string _wellKnownOpenIdConfiguration;

        /// <summary>The endpoint that contains all the configuration endpoints for the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string WellKnownOpenIdConfiguration { get => this._wellKnownOpenIdConfiguration; set => this._wellKnownOpenIdConfiguration = value; }

        /// <summary>Creates an new <see cref="OpenIdConnectConfig" /> instance.</summary>
        public OpenIdConnectConfig()
        {

        }
    }
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    public partial interface IOpenIdConnectConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The endpoint to be used to make an authorization request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint to be used to make an authorization request.",
        SerializedName = @"authorizationEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorizationEndpoint { get; set; }
        /// <summary>The endpoint that provides the keys necessary to validate the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint that provides the keys necessary to validate the token.",
        SerializedName = @"certificationUri",
        PossibleTypes = new [] { typeof(string) })]
        string CertificationUri { get; set; }
        /// <summary>The endpoint that issues the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint that issues the token.",
        SerializedName = @"issuer",
        PossibleTypes = new [] { typeof(string) })]
        string Issuer { get; set; }
        /// <summary>The endpoint to be used to request a token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint to be used to request a token.",
        SerializedName = @"tokenEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string TokenEndpoint { get; set; }
        /// <summary>The endpoint that contains all the configuration endpoints for the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint that contains all the configuration endpoints for the provider.",
        SerializedName = @"wellKnownOpenIdConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string WellKnownOpenIdConfiguration { get; set; }

    }
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    internal partial interface IOpenIdConnectConfigInternal

    {
        /// <summary>The endpoint to be used to make an authorization request.</summary>
        string AuthorizationEndpoint { get; set; }
        /// <summary>The endpoint that provides the keys necessary to validate the token.</summary>
        string CertificationUri { get; set; }
        /// <summary>The endpoint that issues the token.</summary>
        string Issuer { get; set; }
        /// <summary>The endpoint to be used to request a token.</summary>
        string TokenEndpoint { get; set; }
        /// <summary>The endpoint that contains all the configuration endpoints for the provider.</summary>
        string WellKnownOpenIdConfiguration { get; set; }

    }
}