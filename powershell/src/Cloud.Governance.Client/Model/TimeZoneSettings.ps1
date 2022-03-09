#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TimeZoneSettings<PSCustomObject>
#>

function New-TimeZoneSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TimeZone} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TimeZoneSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "TimeZone" = ${TimeZone}
        }

        return $PSO
    }
}

<#
TimeZoneSettings<PSCustomObject>
#>
function ConvertFrom-JsonToTimeZoneSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TimeZoneSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TimeZoneSettings
        $AllProperties = $("Enabled", "TimeZone")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZone"))) { #optional property not found
            $TimeZone = $null
        } else {
            $TimeZone = $JsonParameters.PSobject.Properties["TimeZone"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "TimeZone" = ${TimeZone}
        }

        return $PSO
    }

}

