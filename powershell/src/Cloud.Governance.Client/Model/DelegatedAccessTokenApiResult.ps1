#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DelegatedAccessTokenApiResult<PSCustomObject>
#>

function New-DelegatedAccessTokenApiResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSuccess} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMsg}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DelegatedAccessTokenApiResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "IsSuccess" = ${IsSuccess}
            "ErrorMsg" = ${ErrorMsg}
        }

        return $PSO
    }
}

<#
DelegatedAccessTokenApiResult<PSCustomObject>
#>
function ConvertFrom-JsonToDelegatedAccessTokenApiResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DelegatedAccessTokenApiResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DelegatedAccessTokenApiResult
        $AllProperties = $("Value", "IsSuccess", "ErrorMsg")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSuccess"))) { #optional property not found
            $IsSuccess = $null
        } else {
            $IsSuccess = $JsonParameters.PSobject.Properties["IsSuccess"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMsg"))) { #optional property not found
            $ErrorMsg = $null
        } else {
            $ErrorMsg = $JsonParameters.PSobject.Properties["ErrorMsg"].value
        }

        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "IsSuccess" = ${IsSuccess}
            "ErrorMsg" = ${ErrorMsg}
        }

        return $PSO
    }

}

