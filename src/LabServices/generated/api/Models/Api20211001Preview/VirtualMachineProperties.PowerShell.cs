// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.PowerShell;

    /// <summary>Virtual machine resource properties</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachinePropertiesTypeConverter))]
    public partial class VirtualMachineProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConnectionProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfile = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineConnectionProfile) content.GetValueForProperty("ConnectionProfile",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfile, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineConnectionProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineState.CreateFrom);
            }
            if (content.Contains("ClaimedByUserId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ClaimedByUserId = (string) content.GetValueForProperty("ClaimedByUserId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ClaimedByUserId, global::System.Convert.ToString);
            }
            if (content.Contains("VMType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).VMType = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineType?) content.GetValueForProperty("VMType",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).VMType, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineType.CreateFrom);
            }
            if (content.Contains("ConnectionProfilePrivateIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfilePrivateIPAddress = (string) content.GetValueForProperty("ConnectionProfilePrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfilePrivateIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileSshAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshAuthority = (string) content.GetValueForProperty("ConnectionProfileSshAuthority",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshAuthority, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileSshInBrowserUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshInBrowserUrl = (string) content.GetValueForProperty("ConnectionProfileSshInBrowserUrl",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshInBrowserUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileRdpAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpAuthority = (string) content.GetValueForProperty("ConnectionProfileRdpAuthority",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpAuthority, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileRdpInBrowserUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpInBrowserUrl = (string) content.GetValueForProperty("ConnectionProfileRdpInBrowserUrl",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpInBrowserUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileAdminUsername = (string) content.GetValueForProperty("ConnectionProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileNonAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileNonAdminUsername = (string) content.GetValueForProperty("ConnectionProfileNonAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileNonAdminUsername, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConnectionProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfile = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineConnectionProfile) content.GetValueForProperty("ConnectionProfile",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfile, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineConnectionProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineState.CreateFrom);
            }
            if (content.Contains("ClaimedByUserId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ClaimedByUserId = (string) content.GetValueForProperty("ClaimedByUserId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ClaimedByUserId, global::System.Convert.ToString);
            }
            if (content.Contains("VMType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).VMType = (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineType?) content.GetValueForProperty("VMType",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).VMType, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.VirtualMachineType.CreateFrom);
            }
            if (content.Contains("ConnectionProfilePrivateIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfilePrivateIPAddress = (string) content.GetValueForProperty("ConnectionProfilePrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfilePrivateIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileSshAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshAuthority = (string) content.GetValueForProperty("ConnectionProfileSshAuthority",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshAuthority, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileSshInBrowserUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshInBrowserUrl = (string) content.GetValueForProperty("ConnectionProfileSshInBrowserUrl",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileSshInBrowserUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileRdpAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpAuthority = (string) content.GetValueForProperty("ConnectionProfileRdpAuthority",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpAuthority, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileRdpInBrowserUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpInBrowserUrl = (string) content.GetValueForProperty("ConnectionProfileRdpInBrowserUrl",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileRdpInBrowserUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileAdminUsername = (string) content.GetValueForProperty("ConnectionProfileAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileAdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionProfileNonAdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileNonAdminUsername = (string) content.GetValueForProperty("ConnectionProfileNonAdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachinePropertiesInternal)this).ConnectionProfileNonAdminUsername, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Virtual machine resource properties
    [System.ComponentModel.TypeConverter(typeof(VirtualMachinePropertiesTypeConverter))]
    public partial interface IVirtualMachineProperties

    {

    }
}