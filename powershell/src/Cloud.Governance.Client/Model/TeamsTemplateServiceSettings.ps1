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
        ${EnableCreateTeamFromScratch},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromExistTeam},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromIT},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCreateTeamFromOwned},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TemplateTeams}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TeamsTemplateServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "EnableCreateTeamFromIT" = ${EnableCreateTeamFromIT}
            "EnableCreateTeamFromOwned" = ${EnableCreateTeamFromOwned}
            "TemplateTeams" = ${TemplateTeams}
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
        $AllProperties = $("EnableCreateTeamFromScratch", "EnableCreateTeamFromExistTeam", "EnableCreateTeamFromIT", "EnableCreateTeamFromOwned", "TemplateTeams")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateTeams"))) { #optional property not found
            $TemplateTeams = $null
        } else {
            $TemplateTeams = $JsonParameters.PSobject.Properties["TemplateTeams"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableCreateTeamFromScratch" = ${EnableCreateTeamFromScratch}
            "EnableCreateTeamFromExistTeam" = ${EnableCreateTeamFromExistTeam}
            "EnableCreateTeamFromIT" = ${EnableCreateTeamFromIT}
            "EnableCreateTeamFromOwned" = ${EnableCreateTeamFromOwned}
            "TemplateTeams" = ${TemplateTeams}
        }

        return $PSO
    }

}

