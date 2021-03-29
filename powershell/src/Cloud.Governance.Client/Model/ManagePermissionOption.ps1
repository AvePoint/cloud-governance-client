#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionOption<PSCustomObject>
#>

function New-ManagePermissionOption {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GrantPermissionSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableEditPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableRemovePermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableStopInheritPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableDeleteUniquePermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableExcludePermissionLevel} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsHideExcludePermissionItem} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ExcludedPermissionLevles}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GrantPermissionSetting" = ${GrantPermissionSetting}
            "IsEnableEditPermission" = ${IsEnableEditPermission}
            "IsEnableRemovePermission" = ${IsEnableRemovePermission}
            "IsEnableStopInheritPermission" = ${IsEnableStopInheritPermission}
            "IsEnableDeleteUniquePermission" = ${IsEnableDeleteUniquePermission}
            "IsEnableExcludePermissionLevel" = ${IsEnableExcludePermissionLevel}
            "IsHideExcludePermissionItem" = ${IsHideExcludePermissionItem}
            "ExcludedPermissionLevles" = ${ExcludedPermissionLevles}
        }

        return $PSO
    }
}

<#
ManagePermissionOption<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionOption {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionOption
        $AllProperties = $("GrantPermissionSetting", "IsEnableEditPermission", "IsEnableRemovePermission", "IsEnableStopInheritPermission", "IsEnableDeleteUniquePermission", "IsEnableExcludePermissionLevel", "IsHideExcludePermissionItem", "ExcludedPermissionLevles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GrantPermissionSetting"))) { #optional property not found
            $GrantPermissionSetting = $null
        } else {
            $GrantPermissionSetting = $JsonParameters.PSobject.Properties["GrantPermissionSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableEditPermission"))) { #optional property not found
            $IsEnableEditPermission = $null
        } else {
            $IsEnableEditPermission = $JsonParameters.PSobject.Properties["IsEnableEditPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableRemovePermission"))) { #optional property not found
            $IsEnableRemovePermission = $null
        } else {
            $IsEnableRemovePermission = $JsonParameters.PSobject.Properties["IsEnableRemovePermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableStopInheritPermission"))) { #optional property not found
            $IsEnableStopInheritPermission = $null
        } else {
            $IsEnableStopInheritPermission = $JsonParameters.PSobject.Properties["IsEnableStopInheritPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableDeleteUniquePermission"))) { #optional property not found
            $IsEnableDeleteUniquePermission = $null
        } else {
            $IsEnableDeleteUniquePermission = $JsonParameters.PSobject.Properties["IsEnableDeleteUniquePermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableExcludePermissionLevel"))) { #optional property not found
            $IsEnableExcludePermissionLevel = $null
        } else {
            $IsEnableExcludePermissionLevel = $JsonParameters.PSobject.Properties["IsEnableExcludePermissionLevel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsHideExcludePermissionItem"))) { #optional property not found
            $IsHideExcludePermissionItem = $null
        } else {
            $IsHideExcludePermissionItem = $JsonParameters.PSobject.Properties["IsHideExcludePermissionItem"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExcludedPermissionLevles"))) { #optional property not found
            $ExcludedPermissionLevles = $null
        } else {
            $ExcludedPermissionLevles = $JsonParameters.PSobject.Properties["ExcludedPermissionLevles"].value
        }

        $PSO = [PSCustomObject]@{
            "GrantPermissionSetting" = ${GrantPermissionSetting}
            "IsEnableEditPermission" = ${IsEnableEditPermission}
            "IsEnableRemovePermission" = ${IsEnableRemovePermission}
            "IsEnableStopInheritPermission" = ${IsEnableStopInheritPermission}
            "IsEnableDeleteUniquePermission" = ${IsEnableDeleteUniquePermission}
            "IsEnableExcludePermissionLevel" = ${IsEnableExcludePermissionLevel}
            "IsHideExcludePermissionItem" = ${IsHideExcludePermissionItem}
            "ExcludedPermissionLevles" = ${ExcludedPermissionLevles}
        }

        return $PSO
    }

}

