#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserGroupPermissions<PSCustomObject>
#>

function New-UserGroupPermissions {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupPermissions}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserGroupPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
        }

        return $PSO
    }
}

<#
UserGroupPermissions<PSCustomObject>
#>
function ConvertFrom-JsonToUserGroupPermissions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserGroupPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserGroupPermissions
        $AllProperties = $("UserPermissions", "GroupPermissions")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPermissions"))) { #optional property not found
            $UserPermissions = $null
        } else {
            $UserPermissions = $JsonParameters.PSobject.Properties["UserPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupPermissions"))) { #optional property not found
            $GroupPermissions = $null
        } else {
            $GroupPermissions = $JsonParameters.PSobject.Properties["GroupPermissions"].value
        }

        $PSO = [PSCustomObject]@{
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
        }

        return $PSO
    }

}

