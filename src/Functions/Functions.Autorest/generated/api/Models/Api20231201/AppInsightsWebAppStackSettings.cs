// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>App Insights Web App stack settings.</summary>
    public partial class AppInsightsWebAppStackSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal
    {

        /// <summary>Backing field for <see cref="IsDefaultOff" /> property.</summary>
        private bool? _isDefaultOff;

        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsDefaultOff { get => this._isDefaultOff; }

        /// <summary>Backing field for <see cref="IsSupported" /> property.</summary>
        private bool? _isSupported;

        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsSupported { get => this._isSupported; }

        /// <summary>Internal Acessors for IsDefaultOff</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal.IsDefaultOff { get => this._isDefaultOff; set { {_isDefaultOff = value;} } }

        /// <summary>Internal Acessors for IsSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal.IsSupported { get => this._isSupported; set { {_isSupported = value;} } }

        /// <summary>Creates an new <see cref="AppInsightsWebAppStackSettings" /> instance.</summary>
        public AppInsightsWebAppStackSettings()
        {

        }
    }
    /// App Insights Web App stack settings.
    public partial interface IAppInsightsWebAppStackSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.",
        SerializedName = @"isDefaultOff",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultOff { get;  }
        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.",
        SerializedName = @"isSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSupported { get;  }

    }
    /// App Insights Web App stack settings.
    internal partial interface IAppInsightsWebAppStackSettingsInternal

    {
        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? IsDefaultOff { get; set; }
        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? IsSupported { get; set; }

    }
}