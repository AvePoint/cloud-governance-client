#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UnlockSiteSetting<PSCustomObject>
#>

function New-UnlockSiteSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsExpired} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsExtendEnabled} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UnlockSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsExpired" = ${IsExpired}
            "IsExtendEnabled" = ${IsExtendEnabled}
        }

        return $PSO
    }
}

<#
UnlockSiteSetting<PSCustomObject>
#>
function ConvertFrom-JsonToUnlockSiteSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UnlockSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UnlockSiteSetting
        $AllProperties = $("IsExpired", "IsExtendEnabled")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsExpired"))) { #optional property not found
            $IsExpired = $null
        } else {
            $IsExpired = $JsonParameters.PSobject.Properties["IsExpired"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsExtendEnabled"))) { #optional property not found
            $IsExtendEnabled = $null
        } else {
            $IsExtendEnabled = $JsonParameters.PSobject.Properties["IsExtendEnabled"].value
        }

        $PSO = [PSCustomObject]@{
            "IsExpired" = ${IsExpired}
            "IsExtendEnabled" = ${IsExtendEnabled}
        }

        return $PSO
    }

}

