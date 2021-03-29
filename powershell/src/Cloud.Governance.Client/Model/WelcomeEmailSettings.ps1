#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WelcomeEmailSettings<PSCustomObject>
#>

function New-WelcomeEmailSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Subject},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PersonalMessage}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WelcomeEmailSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Subject" = ${Subject}
            "PersonalMessage" = ${PersonalMessage}
        }

        return $PSO
    }
}

<#
WelcomeEmailSettings<PSCustomObject>
#>
function ConvertFrom-JsonToWelcomeEmailSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WelcomeEmailSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WelcomeEmailSettings
        $AllProperties = $("Enabled", "Subject", "PersonalMessage")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Subject"))) { #optional property not found
            $Subject = $null
        } else {
            $Subject = $JsonParameters.PSobject.Properties["Subject"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PersonalMessage"))) { #optional property not found
            $PersonalMessage = $null
        } else {
            $PersonalMessage = $JsonParameters.PSobject.Properties["PersonalMessage"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Subject" = ${Subject}
            "PersonalMessage" = ${PersonalMessage}
        }

        return $PSO
    }

}

