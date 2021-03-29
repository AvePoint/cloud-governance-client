#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ServiceGroupWithPermissions<PSCustomObject>
#>

function New-ServiceGroupWithPermissions {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UsersAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwnerAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowChangePermissionLevel} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Removable} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Users},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PermissionLevels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwner},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwnerType} = "SpoGroup",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BuildInGroupType} = "None"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ServiceGroupWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "UsersAssignBy" = ${UsersAssignBy}
            "GroupOwnerAssignBy" = ${GroupOwnerAssignBy}
            "AllowChangePermissionLevel" = ${AllowChangePermissionLevel}
            "Removable" = ${Removable}
            "Name" = ${Name}
            "Description" = ${Description}
            "Users" = ${Users}
            "PermissionLevels" = ${PermissionLevels}
            "GroupOwner" = ${GroupOwner}
            "GroupOwnerType" = ${GroupOwnerType}
            "BuildInGroupType" = ${BuildInGroupType}
        }

        return $PSO
    }
}

<#
ServiceGroupWithPermissions<PSCustomObject>
#>
function ConvertFrom-JsonToServiceGroupWithPermissions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ServiceGroupWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ServiceGroupWithPermissions
        $AllProperties = $("UsersAssignBy", "GroupOwnerAssignBy", "AllowChangePermissionLevel", "Removable", "Name", "Description", "Users", "PermissionLevels", "GroupOwner", "GroupOwnerType", "BuildInGroupType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsersAssignBy"))) { #optional property not found
            $UsersAssignBy = $null
        } else {
            $UsersAssignBy = $JsonParameters.PSobject.Properties["UsersAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwnerAssignBy"))) { #optional property not found
            $GroupOwnerAssignBy = $null
        } else {
            $GroupOwnerAssignBy = $JsonParameters.PSobject.Properties["GroupOwnerAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowChangePermissionLevel"))) { #optional property not found
            $AllowChangePermissionLevel = $null
        } else {
            $AllowChangePermissionLevel = $JsonParameters.PSobject.Properties["AllowChangePermissionLevel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Removable"))) { #optional property not found
            $Removable = $null
        } else {
            $Removable = $JsonParameters.PSobject.Properties["Removable"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Users"))) { #optional property not found
            $Users = $null
        } else {
            $Users = $JsonParameters.PSobject.Properties["Users"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionLevels"))) { #optional property not found
            $PermissionLevels = $null
        } else {
            $PermissionLevels = $JsonParameters.PSobject.Properties["PermissionLevels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwner"))) { #optional property not found
            $GroupOwner = $null
        } else {
            $GroupOwner = $JsonParameters.PSobject.Properties["GroupOwner"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwnerType"))) { #optional property not found
            $GroupOwnerType = $null
        } else {
            $GroupOwnerType = $JsonParameters.PSobject.Properties["GroupOwnerType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BuildInGroupType"))) { #optional property not found
            $BuildInGroupType = $null
        } else {
            $BuildInGroupType = $JsonParameters.PSobject.Properties["BuildInGroupType"].value
        }

        $PSO = [PSCustomObject]@{
            "UsersAssignBy" = ${UsersAssignBy}
            "GroupOwnerAssignBy" = ${GroupOwnerAssignBy}
            "AllowChangePermissionLevel" = ${AllowChangePermissionLevel}
            "Removable" = ${Removable}
            "Name" = ${Name}
            "Description" = ${Description}
            "Users" = ${Users}
            "PermissionLevels" = ${PermissionLevels}
            "GroupOwner" = ${GroupOwner}
            "GroupOwnerType" = ${GroupOwnerType}
            "BuildInGroupType" = ${BuildInGroupType}
        }

        return $PSO
    }

}

