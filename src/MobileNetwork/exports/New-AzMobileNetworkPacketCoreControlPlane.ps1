
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a packet core control plane.
.Description
Creates or updates a packet core control plane.
.Example
$siteResourceId = New-AzMobileNetworkSiteResourceIdObject -Id /subscriptions/{subId}/resourceGroups/azps_test_group/providers/Microsoft.MobileNetwork/mobileNetworks/azps-mn/sites/azps-mn-site

New-AzMobileNetworkPacketCoreControlPlane -Name azps-mn-pccp -ResourceGroupName azps_test_group -LocalDiagnosticAccessAuthenticationType Password -Location eastus -PlatformType AKS-HCI -Site $siteResourceId -Sku G0 -ControlPlaneAccessInterfaceIpv4Address 192.168.1.10 -ControlPlaneAccessInterfaceIpv4Gateway 192.168.1.1 -ControlPlaneAccessInterfaceIpv4Subnet 192.168.1.0/24 -ControlPlaneAccessInterfaceName N2 -CoreNetworkTechnology 5GC

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlane
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

SITE <ISiteResourceId[]>: Site(s) under which this packet core control plane should be deployed. The sites must be in the same location as the packet core control plane.
  Id <String>: Site resource ID.
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/new-azmobilenetworkpacketcorecontrolplane
#>
function New-AzMobileNetworkPacketCoreControlPlane {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlane])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('PacketCoreControlPlaneName')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the packet core control plane.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.AuthenticationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.AuthenticationType]
    # How to authenticate users who access local diagnostics APIs.
    ${LocalDiagnosticAccessAuthenticationType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PlatformType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PlatformType]
    # The platform type where packet core is deployed.
    ${PlatformType},

    [Parameter(Mandatory)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISiteResourceId[]]
    # Site(s) under which this packet core control plane should be deployed.
    # The sites must be in the same location as the packet core control plane.
    # To construct, see NOTES section for SITE properties and create a hash table.
    ${Site},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.BillingSku])]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.BillingSku]
    # The SKU defining the throughput and SIM allowances for this packet core control plane deployment.
    ${Sku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Azure Stack Edge device resource ID.
    ${AzureStackEdgeDeviceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Azure Stack HCI cluster resource ID.
    ${AzureStackHciClusterId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Azure Arc connected cluster resource ID.
    ${ConnectedClusterId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The IPv4 address.
    ${ControlPlaneAccessInterfaceIpv4Address},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The default IPv4 gateway (router).
    ${ControlPlaneAccessInterfaceIpv4Gateway},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The IPv4 subnet.
    ${ControlPlaneAccessInterfaceIpv4Subnet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The logical name for this interface.
    # This should match one of the interfaces configured on your Azure Stack Edge device.
    ${ControlPlaneAccessInterfaceName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CoreNetworkType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.CoreNetworkType]
    # The core network technology generation (5G core or EPC / 4G core).
    ${CoreNetworkTechnology},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # Azure Arc custom location resource ID.
    ${CustomLocationId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The certificate URL, unversioned.
    # For example: https://contosovault.vault.azure.net/certificates/ingress.
    ${HttpsServerCertificateUrl},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ManagedServiceIdentityType]
    # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.IUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The set of user assigned identities associated with the resource.
    # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    # The dictionary values can be empty objects ({}) in requests.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPacketCoreControlPlanePropertiesFormatInteropSettings]))]
    [System.Collections.Hashtable]
    # Settings to allow interoperability with third party components e.g.
    # RANs and UEs.
    ${InteropSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.Int32]
    # The MTU (in bytes) signaled to the UE.
    # The same MTU is set on the user plane data links for all data networks.
    # The MTU set on the user plane access link is calculated to be 60 bytes greater than this value to allow for GTP encapsulation.
    ${UeMtu},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # The version of the packet core software that is deployed.
    ${Version},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.MobileNetwork.private\New-AzMobileNetworkPacketCoreControlPlane_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
