#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DistinctResult<PSCustomObject>
#>

function New-DistinctResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DistinctResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "DisplayValue" = ${DisplayValue}
        }

        return $PSO
    }
}

<#
DistinctResult<PSCustomObject>
#>
function ConvertFrom-JsonToDistinctResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DistinctResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DistinctResult
        $AllProperties = $("Value", "DisplayValue")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayValue"))) { #optional property not found
            $DisplayValue = $null
        } else {
            $DisplayValue = $JsonParameters.PSobject.Properties["DisplayValue"].value
        }

        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "DisplayValue" = ${DisplayValue}
        }

        return $PSO
    }

}

