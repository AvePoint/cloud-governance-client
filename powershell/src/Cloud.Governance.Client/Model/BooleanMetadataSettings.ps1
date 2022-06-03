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
        ${EnableTerms} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Value} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TermsAndConditions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TrueDisplayValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FalseDisplayValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TermsAndConditionsContent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DefaultTermLanguageId} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => BooleanMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableTerms" = ${EnableTerms}
            "Value" = ${Value}
            "TermsAndConditions" = ${TermsAndConditions}
            "TrueDisplayValue" = ${TrueDisplayValue}
            "FalseDisplayValue" = ${FalseDisplayValue}
            "TermsAndConditionsContent" = ${TermsAndConditionsContent}
            "DefaultTermLanguageId" = ${DefaultTermLanguageId}
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
        $AllProperties = $("EnableTerms", "Value", "TermsAndConditions", "TrueDisplayValue", "FalseDisplayValue", "TermsAndConditionsContent", "DefaultTermLanguageId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TrueDisplayValue"))) { #optional property not found
            $TrueDisplayValue = $null
        } else {
            $TrueDisplayValue = $JsonParameters.PSobject.Properties["TrueDisplayValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FalseDisplayValue"))) { #optional property not found
            $FalseDisplayValue = $null
        } else {
            $FalseDisplayValue = $JsonParameters.PSobject.Properties["FalseDisplayValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermsAndConditionsContent"))) { #optional property not found
            $TermsAndConditionsContent = $null
        } else {
            $TermsAndConditionsContent = $JsonParameters.PSobject.Properties["TermsAndConditionsContent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTermLanguageId"))) { #optional property not found
            $DefaultTermLanguageId = $null
        } else {
            $DefaultTermLanguageId = $JsonParameters.PSobject.Properties["DefaultTermLanguageId"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableTerms" = ${EnableTerms}
            "Value" = ${Value}
            "TermsAndConditions" = ${TermsAndConditions}
            "TrueDisplayValue" = ${TrueDisplayValue}
            "FalseDisplayValue" = ${FalseDisplayValue}
            "TermsAndConditionsContent" = ${TermsAndConditionsContent}
            "DefaultTermLanguageId" = ${DefaultTermLanguageId}
        }

        return $PSO
    }

}

