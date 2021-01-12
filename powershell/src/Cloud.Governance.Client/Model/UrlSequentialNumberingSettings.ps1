#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UrlSequentialNumberingSettings<PSCustomObject>
#>

function New-UrlSequentialNumberingSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Prefix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Delimiter},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SequenceNumber}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UrlSequentialNumberingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Prefix" = ${Prefix}
            "Delimiter" = ${Delimiter}
            "SequenceNumber" = ${SequenceNumber}
        }

        return $PSO
    }
}

<#
UrlSequentialNumberingSettings<PSCustomObject>
#>
function ConvertFrom-JsonToUrlSequentialNumberingSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UrlSequentialNumberingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UrlSequentialNumberingSettings
        $AllProperties = $("Prefix", "Delimiter", "SequenceNumber")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Prefix"))) { #optional property not found
            $Prefix = $null
        } else {
            $Prefix = $JsonParameters.PSobject.Properties["Prefix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Delimiter"))) { #optional property not found
            $Delimiter = $null
        } else {
            $Delimiter = $JsonParameters.PSobject.Properties["Delimiter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SequenceNumber"))) { #optional property not found
            $SequenceNumber = $null
        } else {
            $SequenceNumber = $JsonParameters.PSobject.Properties["SequenceNumber"].value
        }

        $PSO = [PSCustomObject]@{
            "Prefix" = ${Prefix}
            "Delimiter" = ${Delimiter}
            "SequenceNumber" = ${SequenceNumber}
        }

        return $PSO
    }

}

