#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionModel<PSCustomObject>
#>

function New-GrantPermissionModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionDurationSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WelcomeEmailSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PermissionDurationSettings" = ${PermissionDurationSettings}
            "WelcomeEmailSettings" = ${WelcomeEmailSettings}
        }

        return $PSO
    }
}

<#
GrantPermissionModel<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionModel
        $AllProperties = $("PermissionDurationSettings", "WelcomeEmailSettings")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionDurationSettings"))) { #optional property not found
            $PermissionDurationSettings = $null
        } else {
            $PermissionDurationSettings = $JsonParameters.PSobject.Properties["PermissionDurationSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailSettings"))) { #optional property not found
            $WelcomeEmailSettings = $null
        } else {
            $WelcomeEmailSettings = $JsonParameters.PSobject.Properties["WelcomeEmailSettings"].value
        }

        $PSO = [PSCustomObject]@{
            "PermissionDurationSettings" = ${PermissionDurationSettings}
            "WelcomeEmailSettings" = ${WelcomeEmailSettings}
        }

        return $PSO
    }

}

