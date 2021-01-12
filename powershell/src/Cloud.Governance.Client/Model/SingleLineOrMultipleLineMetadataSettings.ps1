#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SingleLineOrMultipleLineMetadataSettings<PSCustomObject>
#>

function New-SingleLineOrMultipleLineMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SingleLineOrMultipleLineMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
        }

        return $PSO
    }
}

<#
SingleLineOrMultipleLineMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToSingleLineOrMultipleLineMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SingleLineOrMultipleLineMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SingleLineOrMultipleLineMetadataSettings
        $AllProperties = $("Value")
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

        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
        }

        return $PSO
    }

}

