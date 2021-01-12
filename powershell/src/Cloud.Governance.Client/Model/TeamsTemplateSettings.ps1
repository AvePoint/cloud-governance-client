#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TeamsTemplateSettings<PSCustomObject>
#>

function New-TeamsTemplateSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromScratch},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromExistTeam},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SelectedTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneApps},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTabs},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamPrivacy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamClassification}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TeamsTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "SelectedTemplate" = ${SelectedTemplate}
            "EnableCloneChannels" = ${EnableCloneChannels}
            "EnableCloneApps" = ${EnableCloneApps}
            "EnableCloneTabs" = ${EnableCloneTabs}
            "EnableCloneMembers" = ${EnableCloneMembers}
            "EnableCloneTeamSetting" = ${EnableCloneTeamSetting}
            "EnableCloneTeamPrivacy" = ${EnableCloneTeamPrivacy}
            "EnableCloneTeamClassification" = ${EnableCloneTeamClassification}
        }

        return $PSO
    }
}

<#
TeamsTemplateSettings<PSCustomObject>
#>
function ConvertFrom-JsonToTeamsTemplateSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TeamsTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TeamsTemplateSettings
        $AllProperties = $("EnableCreateTeamFromScratch", "EnableCreateTeamFromExistTeam", "SelectedTemplate", "EnableCloneChannels", "EnableCloneApps", "EnableCloneTabs", "EnableCloneMembers", "EnableCloneTeamSetting", "EnableCloneTeamPrivacy", "EnableCloneTeamClassification")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCreateTeamFromScratch"))) { #optional property not found
            $EnableCreateTeamFromScratch = $null
        } else {
            $EnableCreateTeamFromScratch = $JsonParameters.PSobject.Properties["EnableCreateTeamFromScratch"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCreateTeamFromExistTeam"))) { #optional property not found
            $EnableCreateTeamFromExistTeam = $null
        } else {
            $EnableCreateTeamFromExistTeam = $JsonParameters.PSobject.Properties["EnableCreateTeamFromExistTeam"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedTemplate"))) { #optional property not found
            $SelectedTemplate = $null
        } else {
            $SelectedTemplate = $JsonParameters.PSobject.Properties["SelectedTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneChannels"))) { #optional property not found
            $EnableCloneChannels = $null
        } else {
            $EnableCloneChannels = $JsonParameters.PSobject.Properties["EnableCloneChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneApps"))) { #optional property not found
            $EnableCloneApps = $null
        } else {
            $EnableCloneApps = $JsonParameters.PSobject.Properties["EnableCloneApps"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneTabs"))) { #optional property not found
            $EnableCloneTabs = $null
        } else {
            $EnableCloneTabs = $JsonParameters.PSobject.Properties["EnableCloneTabs"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneMembers"))) { #optional property not found
            $EnableCloneMembers = $null
        } else {
            $EnableCloneMembers = $JsonParameters.PSobject.Properties["EnableCloneMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneTeamSetting"))) { #optional property not found
            $EnableCloneTeamSetting = $null
        } else {
            $EnableCloneTeamSetting = $JsonParameters.PSobject.Properties["EnableCloneTeamSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneTeamPrivacy"))) { #optional property not found
            $EnableCloneTeamPrivacy = $null
        } else {
            $EnableCloneTeamPrivacy = $JsonParameters.PSobject.Properties["EnableCloneTeamPrivacy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCloneTeamClassification"))) { #optional property not found
            $EnableCloneTeamClassification = $null
        } else {
            $EnableCloneTeamClassification = $JsonParameters.PSobject.Properties["EnableCloneTeamClassification"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "SelectedTemplate" = ${SelectedTemplate}
            "EnableCloneChannels" = ${EnableCloneChannels}
            "EnableCloneApps" = ${EnableCloneApps}
            "EnableCloneTabs" = ${EnableCloneTabs}
            "EnableCloneMembers" = ${EnableCloneMembers}
            "EnableCloneTeamSetting" = ${EnableCloneTeamSetting}
            "EnableCloneTeamPrivacy" = ${EnableCloneTeamPrivacy}
            "EnableCloneTeamClassification" = ${EnableCloneTeamClassification}
        }

        return $PSO
    }

}

