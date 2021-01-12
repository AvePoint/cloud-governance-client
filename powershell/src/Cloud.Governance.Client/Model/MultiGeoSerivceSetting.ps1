#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
MultiGeoSerivceSetting<PSCustomObject>
#>

function New-MultiGeoSerivceSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMultiGeoTenant},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllLocations},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ControlMode},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedLocations},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LocationAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserRoleForLocation}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => MultiGeoSerivceSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsMultiGeoTenant" = ${IsMultiGeoTenant}
            "AllLocations" = ${AllLocations}
            "IsEnabled" = ${IsEnabled}
            "ControlMode" = ${ControlMode}
            "DefaultLocation" = ${DefaultLocation}
            "SelectedLocations" = ${SelectedLocations}
            "LocationAssignBy" = ${LocationAssignBy}
            "UserRoleForLocation" = ${UserRoleForLocation}
        }

        return $PSO
    }
}

<#
MultiGeoSerivceSetting<PSCustomObject>
#>
function ConvertFrom-JsonToMultiGeoSerivceSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => MultiGeoSerivceSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in MultiGeoSerivceSetting
        $AllProperties = $("IsMultiGeoTenant", "AllLocations", "IsEnabled", "ControlMode", "DefaultLocation", "SelectedLocations", "LocationAssignBy", "UserRoleForLocation")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMultiGeoTenant"))) { #optional property not found
            $IsMultiGeoTenant = $null
        } else {
            $IsMultiGeoTenant = $JsonParameters.PSobject.Properties["IsMultiGeoTenant"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllLocations"))) { #optional property not found
            $AllLocations = $null
        } else {
            $AllLocations = $JsonParameters.PSobject.Properties["AllLocations"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabled"))) { #optional property not found
            $IsEnabled = $null
        } else {
            $IsEnabled = $JsonParameters.PSobject.Properties["IsEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ControlMode"))) { #optional property not found
            $ControlMode = $null
        } else {
            $ControlMode = $JsonParameters.PSobject.Properties["ControlMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultLocation"))) { #optional property not found
            $DefaultLocation = $null
        } else {
            $DefaultLocation = $JsonParameters.PSobject.Properties["DefaultLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedLocations"))) { #optional property not found
            $SelectedLocations = $null
        } else {
            $SelectedLocations = $JsonParameters.PSobject.Properties["SelectedLocations"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LocationAssignBy"))) { #optional property not found
            $LocationAssignBy = $null
        } else {
            $LocationAssignBy = $JsonParameters.PSobject.Properties["LocationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserRoleForLocation"))) { #optional property not found
            $UserRoleForLocation = $null
        } else {
            $UserRoleForLocation = $JsonParameters.PSobject.Properties["UserRoleForLocation"].value
        }

        $PSO = [PSCustomObject]@{
            "IsMultiGeoTenant" = ${IsMultiGeoTenant}
            "AllLocations" = ${AllLocations}
            "IsEnabled" = ${IsEnabled}
            "ControlMode" = ${ControlMode}
            "DefaultLocation" = ${DefaultLocation}
            "SelectedLocations" = ${SelectedLocations}
            "LocationAssignBy" = ${LocationAssignBy}
            "UserRoleForLocation" = ${UserRoleForLocation}
        }

        return $PSO
    }

}

