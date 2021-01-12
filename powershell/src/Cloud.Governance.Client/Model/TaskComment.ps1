#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TaskComment<PSCustomObject>
#>

function New-TaskComment {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CommentTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Content}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TaskComment' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "CommentTime" = ${CommentTime}
            "Content" = ${Content}
        }

        return $PSO
    }
}

<#
TaskComment<PSCustomObject>
#>
function ConvertFrom-JsonToTaskComment {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TaskComment' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TaskComment
        $AllProperties = $("AssigneeDisplayName", "CommentTime", "Content")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssigneeDisplayName"))) { #optional property not found
            $AssigneeDisplayName = $null
        } else {
            $AssigneeDisplayName = $JsonParameters.PSobject.Properties["AssigneeDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CommentTime"))) { #optional property not found
            $CommentTime = $null
        } else {
            $CommentTime = $JsonParameters.PSobject.Properties["CommentTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Content"))) { #optional property not found
            $Content = $null
        } else {
            $Content = $JsonParameters.PSobject.Properties["Content"].value
        }

        $PSO = [PSCustomObject]@{
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "CommentTime" = ${CommentTime}
            "Content" = ${Content}
        }

        return $PSO
    }

}

