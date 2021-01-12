#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApiCredential<PSCustomObject>
#>

function New-ApiCredential {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ClientSecret},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserPrincipalName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApiCredential' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ClientSecret" = ${ClientSecret}
            "UserPrincipalName" = ${UserPrincipalName}
        }

        return $PSO
    }
}

<#
ApiCredential<PSCustomObject>
#>
function ConvertFrom-JsonToApiCredential {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApiCredential' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApiCredential
        $AllProperties = $("ClientSecret", "UserPrincipalName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClientSecret"))) { #optional property not found
            $ClientSecret = $null
        } else {
            $ClientSecret = $JsonParameters.PSobject.Properties["ClientSecret"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPrincipalName"))) { #optional property not found
            $UserPrincipalName = $null
        } else {
            $UserPrincipalName = $JsonParameters.PSobject.Properties["UserPrincipalName"].value
        }

        $PSO = [PSCustomObject]@{
            "ClientSecret" = ${ClientSecret}
            "UserPrincipalName" = ${UserPrincipalName}
        }

        return $PSO
    }

}

