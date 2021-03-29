#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DelegatedAccessToken<PSCustomObject>
#>

function New-DelegatedAccessToken {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AccessToken},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RefreshToken},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Duration} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DelegatedAccessToken' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AccessToken" = ${AccessToken}
            "RefreshToken" = ${RefreshToken}
            "Duration" = ${Duration}
        }

        return $PSO
    }
}

<#
DelegatedAccessToken<PSCustomObject>
#>
function ConvertFrom-JsonToDelegatedAccessToken {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DelegatedAccessToken' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DelegatedAccessToken
        $AllProperties = $("AccessToken", "RefreshToken", "Duration")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AccessToken"))) { #optional property not found
            $AccessToken = $null
        } else {
            $AccessToken = $JsonParameters.PSobject.Properties["AccessToken"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RefreshToken"))) { #optional property not found
            $RefreshToken = $null
        } else {
            $RefreshToken = $JsonParameters.PSobject.Properties["RefreshToken"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Duration"))) { #optional property not found
            $Duration = $null
        } else {
            $Duration = $JsonParameters.PSobject.Properties["Duration"].value
        }

        $PSO = [PSCustomObject]@{
            "AccessToken" = ${AccessToken}
            "RefreshToken" = ${RefreshToken}
            "Duration" = ${Duration}
        }

        return $PSO
    }

}

