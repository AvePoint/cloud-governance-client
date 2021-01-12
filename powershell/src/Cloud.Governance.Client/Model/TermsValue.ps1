#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TermsValue<PSCustomObject>
#>

function New-TermsValue {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Value}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TermsValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
        }

        return $PSO
    }
}

<#
TermsValue<PSCustomObject>
#>
function ConvertFrom-JsonToTermsValue {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TermsValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TermsValue
        $AllProperties = $("TermStore", "TermGroup", "TermSet", "Value")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermStore"))) { #optional property not found
            $TermStore = $null
        } else {
            $TermStore = $JsonParameters.PSobject.Properties["TermStore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermGroup"))) { #optional property not found
            $TermGroup = $null
        } else {
            $TermGroup = $JsonParameters.PSobject.Properties["TermGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermSet"))) { #optional property not found
            $TermSet = $null
        } else {
            $TermSet = $JsonParameters.PSobject.Properties["TermSet"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        $PSO = [PSCustomObject]@{
            "TermStore" = ${TermStore}
            "TermGroup" = ${TermGroup}
            "TermSet" = ${TermSet}
            "Value" = ${Value}
        }

        return $PSO
    }

}

