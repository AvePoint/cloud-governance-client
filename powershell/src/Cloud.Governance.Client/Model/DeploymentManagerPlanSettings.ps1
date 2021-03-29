#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DeploymentManagerPlanSettings<PSCustomObject>
#>

function New-DeploymentManagerPlanSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Plans},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Default}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DeploymentManagerPlanSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Plans" = ${Plans}
            "AssignBy" = ${AssignBy}
            "Default" = ${Default}
        }

        return $PSO
    }
}

<#
DeploymentManagerPlanSettings<PSCustomObject>
#>
function ConvertFrom-JsonToDeploymentManagerPlanSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DeploymentManagerPlanSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DeploymentManagerPlanSettings
        $AllProperties = $("Enabled", "Plans", "AssignBy", "Default")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Plans"))) { #optional property not found
            $Plans = $null
        } else {
            $Plans = $JsonParameters.PSobject.Properties["Plans"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Default"))) { #optional property not found
            $Default = $null
        } else {
            $Default = $JsonParameters.PSobject.Properties["Default"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Plans" = ${Plans}
            "AssignBy" = ${AssignBy}
            "Default" = ${Default}
        }

        return $PSO
    }

}

