#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AutoGenerateUrlSetting<PSCustomObject>
#>

function New-AutoGenerateUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GenerateUrlType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SequentialNumberingSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RandomStringSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AutoGenerateUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GenerateUrlType" = ${GenerateUrlType}
            "SequentialNumberingSettings" = ${SequentialNumberingSettings}
            "RandomStringSettings" = ${RandomStringSettings}
        }

        return $PSO
    }
}

<#
AutoGenerateUrlSetting<PSCustomObject>
#>
function ConvertFrom-JsonToAutoGenerateUrlSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AutoGenerateUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AutoGenerateUrlSetting
        $AllProperties = $("GenerateUrlType", "SequentialNumberingSettings", "RandomStringSettings")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GenerateUrlType"))) { #optional property not found
            $GenerateUrlType = $null
        } else {
            $GenerateUrlType = $JsonParameters.PSobject.Properties["GenerateUrlType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SequentialNumberingSettings"))) { #optional property not found
            $SequentialNumberingSettings = $null
        } else {
            $SequentialNumberingSettings = $JsonParameters.PSobject.Properties["SequentialNumberingSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RandomStringSettings"))) { #optional property not found
            $RandomStringSettings = $null
        } else {
            $RandomStringSettings = $JsonParameters.PSobject.Properties["RandomStringSettings"].value
        }

        $PSO = [PSCustomObject]@{
            "GenerateUrlType" = ${GenerateUrlType}
            "SequentialNumberingSettings" = ${SequentialNumberingSettings}
            "RandomStringSettings" = ${RandomStringSettings}
        }

        return $PSO
    }

}

