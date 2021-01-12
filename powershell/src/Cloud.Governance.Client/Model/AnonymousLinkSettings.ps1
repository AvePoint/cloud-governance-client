#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AnonymousLinkSettings<PSCustomObject>
#>

function New-AnonymousLinkSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Permisssion},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ExpirationDate}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AnonymousLinkSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Permisssion" = ${Permisssion}
            "ExpirationDate" = ${ExpirationDate}
        }

        return $PSO
    }
}

<#
AnonymousLinkSettings<PSCustomObject>
#>
function ConvertFrom-JsonToAnonymousLinkSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AnonymousLinkSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AnonymousLinkSettings
        $AllProperties = $("Permisssion", "ExpirationDate")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Permisssion"))) { #optional property not found
            $Permisssion = $null
        } else {
            $Permisssion = $JsonParameters.PSobject.Properties["Permisssion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpirationDate"))) { #optional property not found
            $ExpirationDate = $null
        } else {
            $ExpirationDate = $JsonParameters.PSobject.Properties["ExpirationDate"].value
        }

        $PSO = [PSCustomObject]@{
            "Permisssion" = ${Permisssion}
            "ExpirationDate" = ${ExpirationDate}
        }

        return $PSO
    }

}

