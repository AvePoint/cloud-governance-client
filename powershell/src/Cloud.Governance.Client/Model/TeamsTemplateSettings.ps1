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
        ${EnableCreateTeamFromScratch} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromExistTeam} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromTeamTemplate} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SelectedTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SelectedMSTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TeamTemplates},
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
        ${EnableCloneTeamClassification} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TeamsTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "EnableCreateTeamFromTeamTemplate" = ${EnableCreateTeamFromTeamTemplate}
            "SelectedTemplate" = ${SelectedTemplate}
            "SelectedMSTemplate" = ${SelectedMSTemplate}
            "TeamTemplates" = ${TeamTemplates}
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
        $AllProperties = $("EnableCreateTeamFromScratch", "EnableCreateTeamFromExistTeam", "EnableCreateTeamFromTeamTemplate", "SelectedTemplate", "SelectedMSTemplate", "TeamTemplates", "EnableCloneChannels", "EnableCloneApps", "EnableCloneTabs", "EnableCloneMembers", "EnableCloneTeamSetting", "EnableCloneTeamPrivacy", "EnableCloneTeamClassification")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedTemplate"))) { #optional property not found
            $SelectedTemplate = $null
        } else {
            $SelectedTemplate = $JsonParameters.PSobject.Properties["SelectedTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedMSTemplate"))) { #optional property not found
            $SelectedMSTemplate = $null
        } else {
            $SelectedMSTemplate = $JsonParameters.PSobject.Properties["SelectedMSTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamTemplates"))) { #optional property not found
            $TeamTemplates = $null
        } else {
            $TeamTemplates = $JsonParameters.PSobject.Properties["TeamTemplates"].value
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
            "EnableCreateTeamFromTeamTemplate" = ${EnableCreateTeamFromTeamTemplate}
            "SelectedTemplate" = ${SelectedTemplate}
            "SelectedMSTemplate" = ${SelectedMSTemplate}
            "TeamTemplates" = ${TeamTemplates}
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

