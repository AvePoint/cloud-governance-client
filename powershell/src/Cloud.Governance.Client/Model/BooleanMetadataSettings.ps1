#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
BooleanMetadataSettings<PSCustomObject>
#>

function New-BooleanMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTerms},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TermsAndConditions}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => BooleanMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableTerms" = ${EnableTerms}
            "Value" = ${Value}
            "TermsAndConditions" = ${TermsAndConditions}
        }

        return $PSO
    }
}

<#
BooleanMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToBooleanMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => BooleanMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in BooleanMetadataSettings
        $AllProperties = $("EnableTerms", "Value", "TermsAndConditions")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTerms"))) { #optional property not found
            $EnableTerms = $null
        } else {
            $EnableTerms = $JsonParameters.PSobject.Properties["EnableTerms"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermsAndConditions"))) { #optional property not found
            $TermsAndConditions = $null
        } else {
            $TermsAndConditions = $JsonParameters.PSobject.Properties["TermsAndConditions"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableTerms" = ${EnableTerms}
            "Value" = ${Value}
            "TermsAndConditions" = ${TermsAndConditions}
        }

        return $PSO
    }

}

