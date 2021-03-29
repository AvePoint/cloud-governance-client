#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionUserSetting<PSCustomObject>
#>

function New-ManagePermissionUserSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserLevelRestrictionType} = "AnyUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserManagementSourceType} = "User",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableShowAADGroupMembers} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionUserSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "UserLevelRestrictionType" = ${UserLevelRestrictionType}
            "UserManagementSourceType" = ${UserManagementSourceType}
            "IsEnableShowAADGroupMembers" = ${IsEnableShowAADGroupMembers}
        }

        return $PSO
    }
}

<#
ManagePermissionUserSetting<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionUserSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionUserSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionUserSetting
        $AllProperties = $("UserLevelRestrictionType", "UserManagementSourceType", "IsEnableShowAADGroupMembers")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserLevelRestrictionType"))) { #optional property not found
            $UserLevelRestrictionType = $null
        } else {
            $UserLevelRestrictionType = $JsonParameters.PSobject.Properties["UserLevelRestrictionType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserManagementSourceType"))) { #optional property not found
            $UserManagementSourceType = $null
        } else {
            $UserManagementSourceType = $JsonParameters.PSobject.Properties["UserManagementSourceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableShowAADGroupMembers"))) { #optional property not found
            $IsEnableShowAADGroupMembers = $null
        } else {
            $IsEnableShowAADGroupMembers = $JsonParameters.PSobject.Properties["IsEnableShowAADGroupMembers"].value
        }

        $PSO = [PSCustomObject]@{
            "UserLevelRestrictionType" = ${UserLevelRestrictionType}
            "UserManagementSourceType" = ${UserManagementSourceType}
            "IsEnableShowAADGroupMembers" = ${IsEnableShowAADGroupMembers}
        }

        return $PSO
    }

}

