#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PermissionManagementModel<PSCustomObject>
#>

function New-PermissionManagementModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUniquePermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPermissionInheritanceChanged},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCopyPermissionsFromParent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InheritedSiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PermissionItems}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PermissionManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsUniquePermission" = ${IsUniquePermission}
            "IsPermissionInheritanceChanged" = ${IsPermissionInheritanceChanged}
            "IsCopyPermissionsFromParent" = ${IsCopyPermissionsFromParent}
            "InheritedSiteUrl" = ${InheritedSiteUrl}
            "PermissionItems" = ${PermissionItems}
        }

        return $PSO
    }
}

<#
PermissionManagementModel<PSCustomObject>
#>
function ConvertFrom-JsonToPermissionManagementModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PermissionManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PermissionManagementModel
        $AllProperties = $("IsUniquePermission", "IsPermissionInheritanceChanged", "IsCopyPermissionsFromParent", "InheritedSiteUrl", "PermissionItems")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsUniquePermission"))) { #optional property not found
            $IsUniquePermission = $null
        } else {
            $IsUniquePermission = $JsonParameters.PSobject.Properties["IsUniquePermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPermissionInheritanceChanged"))) { #optional property not found
            $IsPermissionInheritanceChanged = $null
        } else {
            $IsPermissionInheritanceChanged = $JsonParameters.PSobject.Properties["IsPermissionInheritanceChanged"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCopyPermissionsFromParent"))) { #optional property not found
            $IsCopyPermissionsFromParent = $null
        } else {
            $IsCopyPermissionsFromParent = $JsonParameters.PSobject.Properties["IsCopyPermissionsFromParent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InheritedSiteUrl"))) { #optional property not found
            $InheritedSiteUrl = $null
        } else {
            $InheritedSiteUrl = $JsonParameters.PSobject.Properties["InheritedSiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionItems"))) { #optional property not found
            $PermissionItems = $null
        } else {
            $PermissionItems = $JsonParameters.PSobject.Properties["PermissionItems"].value
        }

        $PSO = [PSCustomObject]@{
            "IsUniquePermission" = ${IsUniquePermission}
            "IsPermissionInheritanceChanged" = ${IsPermissionInheritanceChanged}
            "IsCopyPermissionsFromParent" = ${IsCopyPermissionsFromParent}
            "InheritedSiteUrl" = ${InheritedSiteUrl}
            "PermissionItems" = ${PermissionItems}
        }

        return $PSO
    }

}

