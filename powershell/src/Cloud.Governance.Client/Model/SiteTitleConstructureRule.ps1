#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteTitleConstructureRule<PSCustomObject>
#>

function New-SiteTitleConstructureRule {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Text",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteTitleConstructureRule' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Type" = ${Type}
            "Value" = ${Value}
        }

        return $PSO
    }
}

<#
SiteTitleConstructureRule<PSCustomObject>
#>
function ConvertFrom-JsonToSiteTitleConstructureRule {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteTitleConstructureRule' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteTitleConstructureRule
        $AllProperties = $("Type", "Value")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        $PSO = [PSCustomObject]@{
            "Type" = ${Type}
            "Value" = ${Value}
        }

        return $PSO
    }

}

