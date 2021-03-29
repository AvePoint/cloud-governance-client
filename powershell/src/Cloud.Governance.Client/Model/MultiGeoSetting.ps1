#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
MultiGeoSetting<PSCustomObject>
#>

function New-MultiGeoSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ControlMode} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedLocations},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LocationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserRoleForLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllLocations}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => MultiGeoSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "ControlMode" = ${ControlMode}
            "DefaultLocation" = ${DefaultLocation}
            "SelectedLocations" = ${SelectedLocations}
            "LocationAssignBy" = ${LocationAssignBy}
            "UserRoleForLocation" = ${UserRoleForLocation}
            "AllLocations" = ${AllLocations}
        }

        return $PSO
    }
}

<#
MultiGeoSetting<PSCustomObject>
#>
function ConvertFrom-JsonToMultiGeoSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => MultiGeoSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in MultiGeoSetting
        $AllProperties = $("IsEnabled", "ControlMode", "DefaultLocation", "SelectedLocations", "LocationAssignBy", "UserRoleForLocation", "AllLocations")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllLocations"))) { #optional property not found
            $AllLocations = $null
        } else {
            $AllLocations = $JsonParameters.PSobject.Properties["AllLocations"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "ControlMode" = ${ControlMode}
            "DefaultLocation" = ${DefaultLocation}
            "SelectedLocations" = ${SelectedLocations}
            "LocationAssignBy" = ${LocationAssignBy}
            "UserRoleForLocation" = ${UserRoleForLocation}
            "AllLocations" = ${AllLocations}
        }

        return $PSO
    }

}

