// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>The ssl configuration for scoring</summary>
    public partial class SslConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISslConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISslConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Cert" /> property.</summary>
        private string _cert;

        /// <summary>Cert data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Cert { get => this._cert; set => this._cert = value; }

        /// <summary>Backing field for <see cref="Cname" /> property.</summary>
        private string _cname;

        /// <summary>CNAME of the cert</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Cname { get => this._cname; set => this._cname = value; }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>Key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="LeafDomainLabel" /> property.</summary>
        private string _leafDomainLabel;

        /// <summary>Leaf domain label of public endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string LeafDomainLabel { get => this._leafDomainLabel; set => this._leafDomainLabel = value; }

        /// <summary>Backing field for <see cref="OverwriteExistingDomain" /> property.</summary>
        private bool? _overwriteExistingDomain;

        /// <summary>Indicates whether to overwrite existing domain label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public bool? OverwriteExistingDomain { get => this._overwriteExistingDomain; set => this._overwriteExistingDomain = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus? _status;

        /// <summary>Enable or disable ssl for scoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="SslConfiguration" /> instance.</summary>
        public SslConfiguration()
        {

        }
    }
    /// The ssl configuration for scoring
    public partial interface ISslConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Cert data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cert data",
        SerializedName = @"cert",
        PossibleTypes = new [] { typeof(string) })]
        string Cert { get; set; }
        /// <summary>CNAME of the cert</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CNAME of the cert",
        SerializedName = @"cname",
        PossibleTypes = new [] { typeof(string) })]
        string Cname { get; set; }
        /// <summary>Key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key data",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }
        /// <summary>Leaf domain label of public endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Leaf domain label of public endpoint",
        SerializedName = @"leafDomainLabel",
        PossibleTypes = new [] { typeof(string) })]
        string LeafDomainLabel { get; set; }
        /// <summary>Indicates whether to overwrite existing domain label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether to overwrite existing domain label.",
        SerializedName = @"overwriteExistingDomain",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OverwriteExistingDomain { get; set; }
        /// <summary>Enable or disable ssl for scoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable ssl for scoring",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus? Status { get; set; }

    }
    /// The ssl configuration for scoring
    internal partial interface ISslConfigurationInternal

    {
        /// <summary>Cert data</summary>
        string Cert { get; set; }
        /// <summary>CNAME of the cert</summary>
        string Cname { get; set; }
        /// <summary>Key data</summary>
        string Key { get; set; }
        /// <summary>Leaf domain label of public endpoint</summary>
        string LeafDomainLabel { get; set; }
        /// <summary>Indicates whether to overwrite existing domain label.</summary>
        bool? OverwriteExistingDomain { get; set; }
        /// <summary>Enable or disable ssl for scoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus? Status { get; set; }

    }
}