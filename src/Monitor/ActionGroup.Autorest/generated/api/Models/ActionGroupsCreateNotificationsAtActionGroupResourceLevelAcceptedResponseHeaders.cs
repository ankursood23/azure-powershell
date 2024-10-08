// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.Extensions;

    public partial class ActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>
        /// Creates an new <see cref="ActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeaders" /> instance.
        /// </summary>
        public ActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }
    }
    public partial interface IActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface IActionGroupsCreateNotificationsAtActionGroupResourceLevelAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}