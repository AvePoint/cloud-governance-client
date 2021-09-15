#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ElectionContact<PSCustomObject>
#>

function New-ElectionContact {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IdentityName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ElectionContact' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "DisplayName" = ${DisplayName}
            "IdentityName" = ${IdentityName}
        }

        return $PSO
    }
}

<#
ElectionContact<PSCustomObject>
#>
function ConvertFrom-JsonToElectionContact {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ElectionContact' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ElectionContact
        $AllProperties = $("DisplayName", "IdentityName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IdentityName"))) { #optional property not found
            $IdentityName = $null
        } else {
            $IdentityName = $JsonParameters.PSobject.Properties["IdentityName"].value
        }

        $PSO = [PSCustomObject]@{
            "DisplayName" = ${DisplayName}
            "IdentityName" = ${IdentityName}
        }

        return $PSO
    }

}

