#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LookupListValue<PSCustomObject>
#>

function New-LookupListValue {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ColumnType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ColumnName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LookupListValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ColumnType" = ${ColumnType}
            "ColumnName" = ${ColumnName}
            "Value" = ${Value}
            "DisplayValue" = ${DisplayValue}
        }

        return $PSO
    }
}

<#
LookupListValue<PSCustomObject>
#>
function ConvertFrom-JsonToLookupListValue {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LookupListValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LookupListValue
        $AllProperties = $("ColumnType", "ColumnName", "Value", "DisplayValue")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ColumnType"))) { #optional property not found
            $ColumnType = $null
        } else {
            $ColumnType = $JsonParameters.PSobject.Properties["ColumnType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ColumnName"))) { #optional property not found
            $ColumnName = $null
        } else {
            $ColumnName = $JsonParameters.PSobject.Properties["ColumnName"].value
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
            "ColumnType" = ${ColumnType}
            "ColumnName" = ${ColumnName}
            "Value" = ${Value}
            "DisplayValue" = ${DisplayValue}
        }

        return $PSO
    }

}

