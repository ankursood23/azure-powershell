
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
Creates a Virtual Instance for SAP solutions (VIS) resource
.Description
Creates a Virtual Instance for SAP solutions (VIS) resource
.Example
New-AzWorkloadsSapVirtualInstance -ResourceGroupName 'PowerShell-CLI-TestRG' -Name L46 -Location eastus -Environment 'NonProd' -SapProduct 'S4HANA' -Configuration .\CreatePayload.json -Tag @{k1 = "v1"; k2 = "v2"} -IdentityType 'UserAssigned' -ManagedResourceGroupName "L46-rg" -UserAssignedIdentity @{'/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/SAP-E2ETest-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/E2E-RBAC-MSI'= @{}}
.Example
New-AzWorkloadsSapVirtualInstance -ResourceGroupName 'PowerShell-CLI-TestRG' -Name L46 -Location eastus -Environment 'NonProd' -SapProduct 'S4HANA' -Configuration .\InstallPayload.json -Tag @{k1 = "v1"; k2 = "v2"} -IdentityType 'UserAssigned' -ManagedResourceGroupName "L46-rg" -UserAssignedIdentity @{'/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/SAP-E2ETest-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/E2E-RBAC-MSI'= @{}}
.Example
 New-AzWorkloadsSapVirtualInstance -ResourceGroupName 'PowerShell-CLI-TestRG' -Name SK1 -Location eastus -Environment 'NonProd' -SapProduct 'S4HANA' -Configuration .\CreatePayloadHACustomNames.json -IdentityType 'UserAssigned' -ManagedResourceGroupName "acss-mrg1" -UserAssignedIdentity @{'/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/SAP-E2ETest-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/E2E-RBAC-MSI'= @{}}
.Example
New-AzWorkloadsSapVirtualInstance -ResourceGroupName 'PowerShell-CLI-TestRG' -Name SK1 -Location eastus -Environment 'NonProd' -SapProduct 'S4HANA' -Configuration .\CreatePayloadHACustomNamesInstall.json -IdentityType 'UserAssigned' -ManagedResourceGroupName "acss-mrg1" -UserAssignedIdentity @{'/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/SAP-E2ETest-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/E2E-RBAC-MSI'= @{}}
.Example
New-AzWorkloadsSapVirtualInstance -ResourceGroupName 'TestRG' -Name L46 -Location eastus -Environment 'NonProd' -SapProduct 'S4HANA' -CentralServerVmId '/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/powershell-cli-testrg/providers/microsoft.compute/virtualmachines/l46ascsvm' -Tag @{k1 = "v1"; k2 = "v2"} -ManagedResourceGroupName "L46-rg" -ManagedRgStorageAccountName 'acssstoragel46' -IdentityType 'UserAssigned' -UserAssignedIdentity @{'/subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourcegroups/SAP-E2ETest-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/E2E-RBAC-MSI'= @{}}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstance
.Link
https://learn.microsoft.com/powershell/module/az.workloads/new-azworkloadssapvirtualinstance
#>
function New-AzWorkloadsSapVirtualInstance {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapVirtualInstance])]
[CmdletBinding(DefaultParameterSetName='CreateWithDiscovery', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('SapVirtualInstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [System.String]
    # The name of the Virtual Instances for SAP solutions resource
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapEnvironmentType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapEnvironmentType]
    # Defines the environment type - Production/Non Production.
    ${Environment},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapProductType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapProductType]
    # Defines the SAP Product type.
    ${SapProduct},

    [Parameter(ParameterSetName='CreateWithDiscovery', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # The virtual machine ID of the Central Server
    ${CentralServerVmId},

    [Parameter(ParameterSetName='CreateWithDiscovery')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # The custom storage account name for the storage account created by the service in the managed resource group created as part of VIS deployment.
    # 
    # Refer to the storage account naming rules [here](https://learn.microsoft.com/azure/azure-resource-manager/management/resource-name-rules#microsoftstorage).
    # 
    # If not provided, the service will create the storage account with a random name
    ${ManagedRgStorageAccountName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.ManagedServiceIdentityType]
    # Type of manage identity
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # Managed resource group name
    ${ManagedResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api30.IUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # User assigned identities dictionary
    ${UserAssignedIdentity},

    [Parameter(ParameterSetName='CreateWithJsonTemplatePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # Configuration json path.
    ${Configuration},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.Workloads.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateWithDiscovery = 'Az.Workloads.custom\New-AzWorkloadsSapVirtualInstance';
            CreateWithJsonTemplatePath = 'Az.Workloads.custom\New-AzWorkloadsSapVirtualInstance_CreateWithJsonTemplatePath';
        }
        if (('CreateWithDiscovery', 'CreateWithJsonTemplatePath') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Workloads.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
