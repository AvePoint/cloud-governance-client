#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApiError<PSCustomObject>
#>

function New-ApiError {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Code},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Message},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequestId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${Date}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApiError' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Code" = ${Code}
            "Message" = ${Message}
            "RequestId" = ${RequestId}
            "Date" = ${Date}
        }

        return $PSO
    }
}

<#
ApiError<PSCustomObject>
#>
function ConvertFrom-JsonToApiError {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApiError' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApiError
        $AllProperties = $("Code", "Message", "RequestId", "Date")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Code"))) { #optional property not found
            $Code = $null
        } else {
            $Code = $JsonParameters.PSobject.Properties["Code"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Message"))) { #optional property not found
            $Message = $null
        } else {
            $Message = $JsonParameters.PSobject.Properties["Message"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestId"))) { #optional property not found
            $RequestId = $null
        } else {
            $RequestId = $JsonParameters.PSobject.Properties["RequestId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Date"))) { #optional property not found
            $Date = $null
        } else {
            $Date = $JsonParameters.PSobject.Properties["Date"].value
        }

        $PSO = [PSCustomObject]@{
            "Code" = ${Code}
            "Message" = ${Message}
            "RequestId" = ${RequestId}
            "Date" = ${Date}
        }

        return $PSO
    }

}

