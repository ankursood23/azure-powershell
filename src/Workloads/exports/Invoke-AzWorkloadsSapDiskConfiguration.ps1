
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
Get the SAP Disk Configuration Layout prod/non-prod SAP System.
.Description
Get the SAP Disk Configuration Layout prod/non-prod SAP System.
.Example
Invoke-AzWorkloadsSapDiskConfiguration -Location eastus -AppLocation eastus -DatabaseType HANA -DbVMSku Standard_M32ts -DeploymentType SingleServer -Environment NonProd -SapProduct S4HANA

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.IWorkloadsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapDiskConfigurationsResultVolumeConfigurations
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IWorkloadsIdentity>: Identity Parameter
  [ApplicationInstanceName <String>]: The name of SAP Application Server instance resource.
  [CentralInstanceName <String>]: Central Services Instance resource name string modeled as parameter for auto generation to work correctly.
  [DatabaseInstanceName <String>]: Database resource name string modeled as parameter for auto generation to work correctly.
  [Id <String>]: Resource identity path
  [Location <String>]: The name of Azure region.
  [MonitorName <String>]: Name of the SAP monitor resource.
  [ProviderInstanceName <String>]: Name of the provider instance.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SapVirtualInstanceName <String>]: The name of the Virtual Instances for SAP solutions resource
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://learn.microsoft.com/powershell/module/az.workloads/invoke-azworkloadssapdiskconfiguration
#>
function Invoke-AzWorkloadsSapDiskConfiguration {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapDiskConfigurationsResultVolumeConfigurations])]
[CmdletBinding(DefaultParameterSetName='SapExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='SapExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [System.String]
    # The name of Azure region.
    ${Location},

    [Parameter(ParameterSetName='SapExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='SapViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.IWorkloadsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # The geo-location where the SAP resources will be created.
    ${AppLocation},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDatabaseType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDatabaseType]
    # The database type.
    # Eg: HANA, DB2, etc
    ${DatabaseType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [System.String]
    # The VM SKU for database instance.
    ${DbVMSku},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapDeploymentType]
    # The deployment type.
    # Eg: SingleServer/ThreeTier
    ${DeploymentType},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapEnvironmentType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapEnvironmentType]
    # Defines the environment type - Production/Non Production.
    ${Environment},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapProductType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapProductType]
    # Defines the SAP Product type.
    ${SapProduct},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

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
            SapExpanded = 'Az.Workloads.private\Invoke-AzWorkloadsSapDiskConfiguration_SapExpanded';
            SapViaIdentityExpanded = 'Az.Workloads.private\Invoke-AzWorkloadsSapDiskConfiguration_SapViaIdentityExpanded';
        }
        if (('SapExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
