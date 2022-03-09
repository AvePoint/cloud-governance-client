#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LocaleSettings<PSCustomObject>
#>

function New-LocaleSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Locale} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LocaleSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Locale" = ${Locale}
        }

        return $PSO
    }
}

<#
LocaleSettings<PSCustomObject>
#>
function ConvertFrom-JsonToLocaleSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LocaleSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LocaleSettings
        $AllProperties = $("Enabled", "Locale")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Locale"))) { #optional property not found
            $Locale = $null
        } else {
            $Locale = $JsonParameters.PSobject.Properties["Locale"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Locale" = ${Locale}
        }

        return $PSO
    }

}

