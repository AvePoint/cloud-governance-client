#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApplyGroupPolicyModel<PSCustomObject>
#>

function New-ApplyGroupPolicyModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SubType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplyAllSetting} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplyQuota} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplySharing} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplyQuotaThreshold} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplyDeactivatedElection} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApplyLifecycle} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LifecycleRenewalSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VarFilter},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SelectedObjects},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasOngoingTasks} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApplyGroupPolicyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SubType" = ${SubType}
            "PolicyId" = ${PolicyId}
            "IsApplyAllSetting" = ${IsApplyAllSetting}
            "IsApplyQuota" = ${IsApplyQuota}
            "IsApplySharing" = ${IsApplySharing}
            "IsApplyQuotaThreshold" = ${IsApplyQuotaThreshold}
            "IsApplyDeactivatedElection" = ${IsApplyDeactivatedElection}
            "IsApplyLifecycle" = ${IsApplyLifecycle}
            "LifecycleRenewalSetting" = ${LifecycleRenewalSetting}
            "VarFilter" = ${VarFilter}
            "SelectedObjects" = ${SelectedObjects}
            "HasOngoingTasks" = ${HasOngoingTasks}
        }

        return $PSO
    }
}

<#
ApplyGroupPolicyModel<PSCustomObject>
#>
function ConvertFrom-JsonToApplyGroupPolicyModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApplyGroupPolicyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApplyGroupPolicyModel
        $AllProperties = $("SubType", "PolicyId", "IsApplyAllSetting", "IsApplyQuota", "IsApplySharing", "IsApplyQuotaThreshold", "IsApplyDeactivatedElection", "IsApplyLifecycle", "LifecycleRenewalSetting", "VarFilter", "SelectedObjects", "HasOngoingTasks")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SubType"))) { #optional property not found
            $SubType = $null
        } else {
            $SubType = $JsonParameters.PSobject.Properties["SubType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplyAllSetting"))) { #optional property not found
            $IsApplyAllSetting = $null
        } else {
            $IsApplyAllSetting = $JsonParameters.PSobject.Properties["IsApplyAllSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplyQuota"))) { #optional property not found
            $IsApplyQuota = $null
        } else {
            $IsApplyQuota = $JsonParameters.PSobject.Properties["IsApplyQuota"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplySharing"))) { #optional property not found
            $IsApplySharing = $null
        } else {
            $IsApplySharing = $JsonParameters.PSobject.Properties["IsApplySharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplyQuotaThreshold"))) { #optional property not found
            $IsApplyQuotaThreshold = $null
        } else {
            $IsApplyQuotaThreshold = $JsonParameters.PSobject.Properties["IsApplyQuotaThreshold"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplyDeactivatedElection"))) { #optional property not found
            $IsApplyDeactivatedElection = $null
        } else {
            $IsApplyDeactivatedElection = $JsonParameters.PSobject.Properties["IsApplyDeactivatedElection"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApplyLifecycle"))) { #optional property not found
            $IsApplyLifecycle = $null
        } else {
            $IsApplyLifecycle = $JsonParameters.PSobject.Properties["IsApplyLifecycle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LifecycleRenewalSetting"))) { #optional property not found
            $LifecycleRenewalSetting = $null
        } else {
            $LifecycleRenewalSetting = $JsonParameters.PSobject.Properties["LifecycleRenewalSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VarFilter"))) { #optional property not found
            $VarFilter = $null
        } else {
            $VarFilter = $JsonParameters.PSobject.Properties["VarFilter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedObjects"))) { #optional property not found
            $SelectedObjects = $null
        } else {
            $SelectedObjects = $JsonParameters.PSobject.Properties["SelectedObjects"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasOngoingTasks"))) { #optional property not found
            $HasOngoingTasks = $null
        } else {
            $HasOngoingTasks = $JsonParameters.PSobject.Properties["HasOngoingTasks"].value
        }

        $PSO = [PSCustomObject]@{
            "SubType" = ${SubType}
            "PolicyId" = ${PolicyId}
            "IsApplyAllSetting" = ${IsApplyAllSetting}
            "IsApplyQuota" = ${IsApplyQuota}
            "IsApplySharing" = ${IsApplySharing}
            "IsApplyQuotaThreshold" = ${IsApplyQuotaThreshold}
            "IsApplyDeactivatedElection" = ${IsApplyDeactivatedElection}
            "IsApplyLifecycle" = ${IsApplyLifecycle}
            "LifecycleRenewalSetting" = ${LifecycleRenewalSetting}
            "VarFilter" = ${VarFilter}
            "SelectedObjects" = ${SelectedObjects}
            "HasOngoingTasks" = ${HasOngoingTasks}
        }

        return $PSO
    }

}

