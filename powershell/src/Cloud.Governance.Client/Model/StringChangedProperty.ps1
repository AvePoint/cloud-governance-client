#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
StringChangedProperty<PSCustomObject>
#>

function New-StringChangedProperty {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ChangeValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => StringChangedProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ChangeValue" = ${ChangeValue}
            "OriginalValue" = ${OriginalValue}
        }

        return $PSO
    }
}

<#
StringChangedProperty<PSCustomObject>
#>
function ConvertFrom-JsonToStringChangedProperty {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => StringChangedProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in StringChangedProperty
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

