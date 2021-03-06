#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestMetadataListChangedProperty<PSCustomObject>
#>

function New-RequestMetadataListChangedProperty {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ChangeValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${OriginalValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RequestMetadataListChangedProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ChangeValue" = ${ChangeValue}
            "OriginalValue" = ${OriginalValue}
        }

        return $PSO
    }
}

<#
RequestMetadataListChangedProperty<PSCustomObject>
#>
function ConvertFrom-JsonToRequestMetadataListChangedProperty {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestMetadataListChangedProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestMetadataListChangedProperty
        $AllProperties = $("ChangeValue", "OriginalValue")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangeValue"))) { #optional property not found
            $ChangeValue = $null
        } else {
            $ChangeValue = $JsonParameters.PSobject.Properties["ChangeValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalValue"))) { #optional property not found
            $OriginalValue = $null
        } else {
            $OriginalValue = $JsonParameters.PSobject.Properties["OriginalValue"].value
        }

        $PSO = [PSCustomObject]@{
            "ChangeValue" = ${ChangeValue}
            "OriginalValue" = ${OriginalValue}
        }

        return $PSO
    }

}

