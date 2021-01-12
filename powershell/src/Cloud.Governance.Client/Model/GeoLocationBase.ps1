#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GeoLocationBase<PSCustomObject>
#>

function New-GeoLocationBase {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GeoLocationBase' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
        }

        return $PSO
    }
}

<#
GeoLocationBase<PSCustomObject>
#>
function ConvertFrom-JsonToGeoLocationBase {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GeoLocationBase' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GeoLocationBase
        $AllProperties = $("Name", "DisplayName")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        $PSO = [PSCustomObject]@{
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
        }

        return $PSO
    }

}

