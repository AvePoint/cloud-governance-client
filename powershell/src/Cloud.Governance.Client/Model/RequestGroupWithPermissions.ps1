#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestGroupWithPermissions<PSCustomObject>
#>

function New-RequestGroupWithPermissions {
    [CmdletBinding()]
    Param (
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
        ${GroupOwnerType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BuildInGroupType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RequestGroupWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
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
RequestGroupWithPermissions<PSCustomObject>
#>
function ConvertFrom-JsonToRequestGroupWithPermissions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestGroupWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestGroupWithPermissions
        $AllProperties = $("Name", "Description", "Users", "PermissionLevels", "GroupOwner", "GroupOwnerType", "BuildInGroupType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

