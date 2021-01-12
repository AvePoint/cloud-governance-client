#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateListUrlSettings<PSCustomObject>
#>

function New-CreateListUrlSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableContructUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContructUrlSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableUrlValidation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TextValidationRule}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateListUrlSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableContructUrl" = ${EnableContructUrl}
            "ContructUrlSetting" = ${ContructUrlSetting}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "TextValidationRule" = ${TextValidationRule}
        }

        return $PSO
    }
}

<#
CreateListUrlSettings<PSCustomObject>
#>
function ConvertFrom-JsonToCreateListUrlSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateListUrlSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateListUrlSettings
        $AllProperties = $("EnableContructUrl", "ContructUrlSetting", "EnableUrlValidation", "TextValidationRule")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableContructUrl"))) { #optional property not found
            $EnableContructUrl = $null
        } else {
            $EnableContructUrl = $JsonParameters.PSobject.Properties["EnableContructUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContructUrlSetting"))) { #optional property not found
            $ContructUrlSetting = $null
        } else {
            $ContructUrlSetting = $JsonParameters.PSobject.Properties["ContructUrlSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableUrlValidation"))) { #optional property not found
            $EnableUrlValidation = $null
        } else {
            $EnableUrlValidation = $JsonParameters.PSobject.Properties["EnableUrlValidation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TextValidationRule"))) { #optional property not found
            $TextValidationRule = $null
        } else {
            $TextValidationRule = $JsonParameters.PSobject.Properties["TextValidationRule"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableContructUrl" = ${EnableContructUrl}
            "ContructUrlSetting" = ${ContructUrlSetting}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "TextValidationRule" = ${TextValidationRule}
        }

        return $PSO
    }

}

