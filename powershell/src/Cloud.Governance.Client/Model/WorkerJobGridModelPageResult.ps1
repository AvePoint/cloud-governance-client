#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkerJobGridModelPageResult<PSCustomObject>
#>

function New-WorkerJobGridModelPageResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NextLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NextToken}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkerJobGridModelPageResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "NextLink" = ${NextLink}
            "NextToken" = ${NextToken}
        }

        return $PSO
    }
}

<#
WorkerJobGridModelPageResult<PSCustomObject>
#>
function ConvertFrom-JsonToWorkerJobGridModelPageResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkerJobGridModelPageResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkerJobGridModelPageResult
        $AllProperties = $("Value", "NextLink", "NextToken")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextLink"))) { #optional property not found
            $NextLink = $null
        } else {
            $NextLink = $JsonParameters.PSobject.Properties["NextLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextToken"))) { #optional property not found
            $NextToken = $null
        } else {
            $NextToken = $JsonParameters.PSobject.Properties["NextToken"].value
        }

        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "NextLink" = ${NextLink}
            "NextToken" = ${NextToken}
        }

        return $PSO
    }

}

