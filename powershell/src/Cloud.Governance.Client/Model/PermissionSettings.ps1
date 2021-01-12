#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PermissionSettings<PSCustomObject>
#>

function New-PermissionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowGrantUserPermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${PreventGrantSpecificPermissionLevels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PreventPermissionLevles}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AllowGrantUserPermission" = ${AllowGrantUserPermission}
            "PreventGrantSpecificPermissionLevels" = ${PreventGrantSpecificPermissionLevels}
            "PreventPermissionLevles" = ${PreventPermissionLevles}
        }

        return $PSO
    }
}

<#
PermissionSettings<PSCustomObject>
#>
function ConvertFrom-JsonToPermissionSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PermissionSettings
        $AllProperties = $("AllowGrantUserPermission", "PreventGrantSpecificPermissionLevels", "PreventPermissionLevles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowGrantUserPermission"))) { #optional property not found
            $AllowGrantUserPermission = $null
        } else {
            $AllowGrantUserPermission = $JsonParameters.PSobject.Properties["AllowGrantUserPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreventGrantSpecificPermissionLevels"))) { #optional property not found
            $PreventGrantSpecificPermissionLevels = $null
        } else {
            $PreventGrantSpecificPermissionLevels = $JsonParameters.PSobject.Properties["PreventGrantSpecificPermissionLevels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreventPermissionLevles"))) { #optional property not found
            $PreventPermissionLevles = $null
        } else {
            $PreventPermissionLevles = $JsonParameters.PSobject.Properties["PreventPermissionLevles"].value
        }

        $PSO = [PSCustomObject]@{
            "AllowGrantUserPermission" = ${AllowGrantUserPermission}
            "PreventGrantSpecificPermissionLevels" = ${PreventGrantSpecificPermissionLevels}
            "PreventPermissionLevles" = ${PreventPermissionLevles}
        }

        return $PSO
    }

}

