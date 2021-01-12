#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LockSiteSetting<PSCustomObject>
#>

function New-LockSiteSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableLockAsNoAccess},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableLockAsReadonly}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LockSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableLockAsNoAccess" = ${EnableLockAsNoAccess}
            "EnableLockAsReadonly" = ${EnableLockAsReadonly}
        }

        return $PSO
    }
}

<#
LockSiteSetting<PSCustomObject>
#>
function ConvertFrom-JsonToLockSiteSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LockSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LockSiteSetting
        $AllProperties = $("EnableLockAsNoAccess", "EnableLockAsReadonly")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableLockAsNoAccess"))) { #optional property not found
            $EnableLockAsNoAccess = $null
        } else {
            $EnableLockAsNoAccess = $JsonParameters.PSobject.Properties["EnableLockAsNoAccess"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableLockAsReadonly"))) { #optional property not found
            $EnableLockAsReadonly = $null
        } else {
            $EnableLockAsReadonly = $JsonParameters.PSobject.Properties["EnableLockAsReadonly"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableLockAsNoAccess" = ${EnableLockAsNoAccess}
            "EnableLockAsReadonly" = ${EnableLockAsReadonly}
        }

        return $PSO
    }

}

