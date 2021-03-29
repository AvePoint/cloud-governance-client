#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChoiceMetadataSettings<PSCustomObject>
#>

function New-ChoiceMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Choices},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChoiceType} = "DropDown"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChoiceMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Choices" = ${Choices}
            "Value" = ${Value}
            "ChoiceType" = ${ChoiceType}
        }

        return $PSO
    }
}

<#
ChoiceMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToChoiceMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChoiceMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChoiceMetadataSettings
        $AllProperties = $("Choices", "Value", "ChoiceType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Choices"))) { #optional property not found
            $Choices = $null
        } else {
            $Choices = $JsonParameters.PSobject.Properties["Choices"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChoiceType"))) { #optional property not found
            $ChoiceType = $null
        } else {
            $ChoiceType = $JsonParameters.PSobject.Properties["ChoiceType"].value
        }

        $PSO = [PSCustomObject]@{
            "Choices" = ${Choices}
            "Value" = ${Value}
            "ChoiceType" = ${ChoiceType}
        }

        return $PSO
    }

}

