#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserLevelControlSettings<PSCustomObject>
#>

function New-UserLevelControlSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserLevelControlMode},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSetRequesterAsDefaultEnabled}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserLevelControlSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "UserLevelControlMode" = ${UserLevelControlMode}
            "IsSetRequesterAsDefaultEnabled" = ${IsSetRequesterAsDefaultEnabled}
        }

        return $PSO
    }
}

<#
UserLevelControlSettings<PSCustomObject>
#>
function ConvertFrom-JsonToUserLevelControlSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserLevelControlSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserLevelControlSettings
        $AllProperties = $("UserLevelControlMode", "IsSetRequesterAsDefaultEnabled")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserLevelControlMode"))) { #optional property not found
            $UserLevelControlMode = $null
        } else {
            $UserLevelControlMode = $JsonParameters.PSobject.Properties["UserLevelControlMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSetRequesterAsDefaultEnabled"))) { #optional property not found
            $IsSetRequesterAsDefaultEnabled = $null
        } else {
            $IsSetRequesterAsDefaultEnabled = $JsonParameters.PSobject.Properties["IsSetRequesterAsDefaultEnabled"].value
        }

        $PSO = [PSCustomObject]@{
            "UserLevelControlMode" = ${UserLevelControlMode}
            "IsSetRequesterAsDefaultEnabled" = ${IsSetRequesterAsDefaultEnabled}
        }

        return $PSO
    }

}

