#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ExternalUserSharingSettings<PSCustomObject>
#>

function New-ExternalUserSharingSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SharingType} = "RequireSignIn",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AnonymousLinkSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ExternalUserSharingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "SharingType" = ${SharingType}
            "AnonymousLinkSettings" = ${AnonymousLinkSettings}
        }

        return $PSO
    }
}

<#
ExternalUserSharingSettings<PSCustomObject>
#>
function ConvertFrom-JsonToExternalUserSharingSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ExternalUserSharingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ExternalUserSharingSettings
        $AllProperties = $("Enabled", "SharingType", "AnonymousLinkSettings")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SharingType"))) { #optional property not found
            $SharingType = $null
        } else {
            $SharingType = $JsonParameters.PSobject.Properties["SharingType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AnonymousLinkSettings"))) { #optional property not found
            $AnonymousLinkSettings = $null
        } else {
            $AnonymousLinkSettings = $JsonParameters.PSobject.Properties["AnonymousLinkSettings"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "SharingType" = ${SharingType}
            "AnonymousLinkSettings" = ${AnonymousLinkSettings}
        }

        return $PSO
    }

}

