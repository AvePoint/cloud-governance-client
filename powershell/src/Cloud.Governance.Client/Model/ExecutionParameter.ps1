#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ExecutionParameter<PSCustomObject>
#>

function New-ExecutionParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ExecutionParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Name" = ${Name}
            "Type" = ${Type}
            "Value" = ${Value}
        }

        return $PSO
    }
}

<#
ExecutionParameter<PSCustomObject>
#>
function ConvertFrom-JsonToExecutionParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ExecutionParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ExecutionParameter
        $AllProperties = $("Name", "Type", "Value")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
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
            "Name" = ${Name}
            "Type" = ${Type}
            "Value" = ${Value}
        }

        return $PSO
    }

}

