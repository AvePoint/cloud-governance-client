#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestUserWithPermissions<PSCustomObject>
#>

function New-RequestUserWithPermissions {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${User},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PermissionLevels}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RequestUserWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "User" = ${User}
            "PermissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }
}

<#
RequestUserWithPermissions<PSCustomObject>
#>
function ConvertFrom-JsonToRequestUserWithPermissions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestUserWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestUserWithPermissions
        $AllProperties = $("User", "PermissionLevels")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "User"))) { #optional property not found
            $User = $null
        } else {
            $User = $JsonParameters.PSobject.Properties["User"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionLevels"))) { #optional property not found
            $PermissionLevels = $null
        } else {
            $PermissionLevels = $JsonParameters.PSobject.Properties["PermissionLevels"].value
        }

        $PSO = [PSCustomObject]@{
            "User" = ${User}
            "PermissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }

}

