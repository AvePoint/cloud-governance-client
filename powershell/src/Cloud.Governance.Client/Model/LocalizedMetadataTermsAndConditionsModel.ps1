#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LocalizedMetadataTermsAndConditionsModel<PSCustomObject>
#>

function New-LocalizedMetadataTermsAndConditionsModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Term},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableCustomValue} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TrueValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FalseValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LocalizedMetadataTermsAndConditionsModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Term" = ${Term}
            "LanguageId" = ${LanguageId}
            "IsEnabled" = ${IsEnabled}
            "IsEnableCustomValue" = ${IsEnableCustomValue}
            "TrueValue" = ${TrueValue}
            "FalseValue" = ${FalseValue}
        }

        return $PSO
    }
}

<#
LocalizedMetadataTermsAndConditionsModel<PSCustomObject>
#>
function ConvertFrom-JsonToLocalizedMetadataTermsAndConditionsModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LocalizedMetadataTermsAndConditionsModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LocalizedMetadataTermsAndConditionsModel
        $AllProperties = $("Term", "LanguageId", "IsEnabled", "IsEnableCustomValue", "TrueValue", "FalseValue")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Term"))) { #optional property not found
            $Term = $null
        } else {
            $Term = $JsonParameters.PSobject.Properties["Term"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabled"))) { #optional property not found
            $IsEnabled = $null
        } else {
            $IsEnabled = $JsonParameters.PSobject.Properties["IsEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableCustomValue"))) { #optional property not found
            $IsEnableCustomValue = $null
        } else {
            $IsEnableCustomValue = $JsonParameters.PSobject.Properties["IsEnableCustomValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TrueValue"))) { #optional property not found
            $TrueValue = $null
        } else {
            $TrueValue = $JsonParameters.PSobject.Properties["TrueValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FalseValue"))) { #optional property not found
            $FalseValue = $null
        } else {
            $FalseValue = $JsonParameters.PSobject.Properties["FalseValue"].value
        }

        $PSO = [PSCustomObject]@{
            "Term" = ${Term}
            "LanguageId" = ${LanguageId}
            "IsEnabled" = ${IsEnabled}
            "IsEnableCustomValue" = ${IsEnableCustomValue}
            "TrueValue" = ${TrueValue}
            "FalseValue" = ${FalseValue}
        }

        return $PSO
    }

}

