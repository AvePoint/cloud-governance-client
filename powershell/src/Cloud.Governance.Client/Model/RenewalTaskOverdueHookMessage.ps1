#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RenewalTaskOverdueHookMessage<PSCustomObject>
#>

function New-RenewalTaskOverdueHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${DueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeIdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RenewalProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectTypeEnum},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TriggerType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${TriggerTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RenewalTaskOverdueHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "DueDate" = ${DueDate}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalProfileName" = ${RenewalProfileName}
            "TaskLink" = ${TaskLink}
            "ObjectTitle" = ${ObjectTitle}
            "ObjectType" = ${ObjectType}
            "ObjectTypeEnum" = ${ObjectTypeEnum}
            "GroupEmail" = ${GroupEmail}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }
}

<#
RenewalTaskOverdueHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToRenewalTaskOverdueHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RenewalTaskOverdueHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RenewalTaskOverdueHookMessage
        $AllProperties = $("DueDate", "AssigneeDisplayName", "AssigneeIdentityName", "PhaseStartTime", "RenewalProfileName", "TaskLink", "ObjectTitle", "ObjectType", "ObjectTypeEnum", "GroupEmail", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DueDate"))) { #optional property not found
            $DueDate = $null
        } else {
            $DueDate = $JsonParameters.PSobject.Properties["DueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssigneeDisplayName"))) { #optional property not found
            $AssigneeDisplayName = $null
        } else {
            $AssigneeDisplayName = $JsonParameters.PSobject.Properties["AssigneeDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssigneeIdentityName"))) { #optional property not found
            $AssigneeIdentityName = $null
        } else {
            $AssigneeIdentityName = $JsonParameters.PSobject.Properties["AssigneeIdentityName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseStartTime"))) { #optional property not found
            $PhaseStartTime = $null
        } else {
            $PhaseStartTime = $JsonParameters.PSobject.Properties["PhaseStartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalProfileName"))) { #optional property not found
            $RenewalProfileName = $null
        } else {
            $RenewalProfileName = $JsonParameters.PSobject.Properties["RenewalProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskLink"))) { #optional property not found
            $TaskLink = $null
        } else {
            $TaskLink = $JsonParameters.PSobject.Properties["TaskLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectTitle"))) { #optional property not found
            $ObjectTitle = $null
        } else {
            $ObjectTitle = $JsonParameters.PSobject.Properties["ObjectTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) { #optional property not found
            $ObjectType = $null
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectTypeEnum"))) { #optional property not found
            $ObjectTypeEnum = $null
        } else {
            $ObjectTypeEnum = $JsonParameters.PSobject.Properties["ObjectTypeEnum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TriggerType"))) { #optional property not found
            $TriggerType = $null
        } else {
            $TriggerType = $JsonParameters.PSobject.Properties["TriggerType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TriggerTime"))) { #optional property not found
            $TriggerTime = $null
        } else {
            $TriggerTime = $JsonParameters.PSobject.Properties["TriggerTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        $PSO = [PSCustomObject]@{
            "DueDate" = ${DueDate}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalProfileName" = ${RenewalProfileName}
            "TaskLink" = ${TaskLink}
            "ObjectTitle" = ${ObjectTitle}
            "ObjectType" = ${ObjectType}
            "ObjectTypeEnum" = ${ObjectTypeEnum}
            "GroupEmail" = ${GroupEmail}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }

}

