#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TeamsTemplateServiceSettings<PSCustomObject>
#>

function New-TeamsTemplateServiceSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromScratch} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromExistTeam} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromTeamTemplate} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromIT} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromOwned} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneChannels} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneApps} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTabs} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneMembers} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamSetting} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamPrivacy} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCloneTeamClassification} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CloneTeamTemplateSettingValueAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TemplateTeams},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TeamTemplates},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Hidden} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TeamsTemplateServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "EnableCreateTeamFromTeamTemplate" = ${EnableCreateTeamFromTeamTemplate}
            "EnableCreateTeamFromIT" = ${EnableCreateTeamFromIT}
            "EnableCreateTeamFromOwned" = ${EnableCreateTeamFromOwned}
            "EnableCloneChannels" = ${EnableCloneChannels}
            "EnableCloneApps" = ${EnableCloneApps}
            "EnableCloneTabs" = ${EnableCloneTabs}
            "EnableCloneMembers" = ${EnableCloneMembers}
            "EnableCloneTeamSetting" = ${EnableCloneTeamSetting}
            "EnableCloneTeamPrivacy" = ${EnableCloneTeamPrivacy}
            "EnableCloneTeamClassification" = ${EnableCloneTeamClassification}
            "CloneTeamTemplateSettingValueAssignBy" = ${CloneTeamTemplateSettingValueAssignBy}
            "TemplateTeams" = ${TemplateTeams}
            "TeamTemplates" = ${TeamTemplates}
            "Hidden" = ${Hidden}
        }

        return $PSO
    }
}

<#
TeamsTemplateServiceSettings<PSCustomObject>
#>
function ConvertFrom-JsonToTeamsTemplateServiceSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TeamsTemplateServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TeamsTemplateServiceSettings
        $AllProperties = $("EnableCreateTeamFromScratch", "EnableCreateTeamFromExistTeam", "EnableCreateTeamFromTeamTemplate", "EnableCreateTeamFromIT", "EnableCreateTeamFromOwned", "EnableCloneChannels", "EnableCloneApps", "EnableCloneTabs", "EnableCloneMembers", "EnableCloneTeamSetting", "EnableCloneTeamPrivacy", "EnableCloneTeamClassification", "CloneTeamTemplateSettingValueAssignBy", "TemplateTeams", "TeamTemplates", "Hidden")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCreateTeamFromTeamTemplate"))) { #optional property not found
            $EnableCreateTeamFromTeamTemplate = $null
        } else {
            $EnableCreateTeamFromTeamTemplate = $JsonParameters.PSobject.Properties["EnableCreateTeamFromTeamTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCreateTeamFromIT"))) { #optional property not found
            $EnableCreateTeamFromIT = $null
        } else {
            $EnableCreateTeamFromIT = $JsonParameters.PSobject.Properties["EnableCreateTeamFromIT"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCreateTeamFromOwned"))) { #optional property not found
            $EnableCreateTeamFromOwned = $null
        } else {
            $EnableCreateTeamFromOwned = $JsonParameters.PSobject.Properties["EnableCreateTeamFromOwned"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CloneTeamTemplateSettingValueAssignBy"))) { #optional property not found
            $CloneTeamTemplateSettingValueAssignBy = $null
        } else {
            $CloneTeamTemplateSettingValueAssignBy = $JsonParameters.PSobject.Properties["CloneTeamTemplateSettingValueAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateTeams"))) { #optional property not found
            $TemplateTeams = $null
        } else {
            $TemplateTeams = $JsonParameters.PSobject.Properties["TemplateTeams"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamTemplates"))) { #optional property not found
            $TeamTemplates = $null
        } else {
            $TeamTemplates = $JsonParameters.PSobject.Properties["TeamTemplates"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Hidden"))) { #optional property not found
            $Hidden = $null
        } else {
            $Hidden = $JsonParameters.PSobject.Properties["Hidden"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "EnableCreateTeamFromTeamTemplate" = ${EnableCreateTeamFromTeamTemplate}
            "EnableCreateTeamFromIT" = ${EnableCreateTeamFromIT}
            "EnableCreateTeamFromOwned" = ${EnableCreateTeamFromOwned}
            "EnableCloneChannels" = ${EnableCloneChannels}
            "EnableCloneApps" = ${EnableCloneApps}
            "EnableCloneTabs" = ${EnableCloneTabs}
            "EnableCloneMembers" = ${EnableCloneMembers}
            "EnableCloneTeamSetting" = ${EnableCloneTeamSetting}
            "EnableCloneTeamPrivacy" = ${EnableCloneTeamPrivacy}
            "EnableCloneTeamClassification" = ${EnableCloneTeamClassification}
            "CloneTeamTemplateSettingValueAssignBy" = ${CloneTeamTemplateSettingValueAssignBy}
            "TemplateTeams" = ${TemplateTeams}
            "TeamTemplates" = ${TeamTemplates}
            "Hidden" = ${Hidden}
        }

        return $PSO
    }

}

