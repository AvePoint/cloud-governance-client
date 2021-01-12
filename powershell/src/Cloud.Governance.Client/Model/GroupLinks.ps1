#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupLinks<PSCustomObject>
#>

function New-GroupLinks {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupSiteLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupPlannerLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupFilesLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupConversationsLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupNotebookLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${YammerGroupLink}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupLinks' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupSiteLink" = ${GroupSiteLink}
            "GroupPlannerLink" = ${GroupPlannerLink}
            "GroupFilesLink" = ${GroupFilesLink}
            "GroupConversationsLink" = ${GroupConversationsLink}
            "GroupNotebookLink" = ${GroupNotebookLink}
            "YammerGroupLink" = ${YammerGroupLink}
        }

        return $PSO
    }
}

<#
GroupLinks<PSCustomObject>
#>
function ConvertFrom-JsonToGroupLinks {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupLinks' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupLinks
        $AllProperties = $("GroupSiteLink", "GroupPlannerLink", "GroupFilesLink", "GroupConversationsLink", "GroupNotebookLink", "YammerGroupLink")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupSiteLink"))) { #optional property not found
            $GroupSiteLink = $null
        } else {
            $GroupSiteLink = $JsonParameters.PSobject.Properties["GroupSiteLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupPlannerLink"))) { #optional property not found
            $GroupPlannerLink = $null
        } else {
            $GroupPlannerLink = $JsonParameters.PSobject.Properties["GroupPlannerLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupFilesLink"))) { #optional property not found
            $GroupFilesLink = $null
        } else {
            $GroupFilesLink = $JsonParameters.PSobject.Properties["GroupFilesLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupConversationsLink"))) { #optional property not found
            $GroupConversationsLink = $null
        } else {
            $GroupConversationsLink = $JsonParameters.PSobject.Properties["GroupConversationsLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupNotebookLink"))) { #optional property not found
            $GroupNotebookLink = $null
        } else {
            $GroupNotebookLink = $JsonParameters.PSobject.Properties["GroupNotebookLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupLink"))) { #optional property not found
            $YammerGroupLink = $null
        } else {
            $YammerGroupLink = $JsonParameters.PSobject.Properties["YammerGroupLink"].value
        }

        $PSO = [PSCustomObject]@{
            "GroupSiteLink" = ${GroupSiteLink}
            "GroupPlannerLink" = ${GroupPlannerLink}
            "GroupFilesLink" = ${GroupFilesLink}
            "GroupConversationsLink" = ${GroupConversationsLink}
            "GroupNotebookLink" = ${GroupNotebookLink}
            "YammerGroupLink" = ${YammerGroupLink}
        }

        return $PSO
    }

}

