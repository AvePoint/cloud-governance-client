#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LifecycleHookMessage<PSCustomObject>
#>

function New-LifecycleHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ReachedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeIdentityName},
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
        [PSCustomObject]
        ${ObjectTypeEnum} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TriggerType} = "None",
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
        'Creating PSCustomObject: Cloud.Governance.Client => LifecycleHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PolicyId" = ${PolicyId}
            "PolicyName" = ${PolicyName}
            "TaskType" = ${TaskType}
            "ReachedTime" = ${ReachedTime}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
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
LifecycleHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToLifecycleHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LifecycleHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LifecycleHookMessage
        $AllProperties = $("PolicyId", "PolicyName", "TaskType", "ReachedTime", "AssigneeDisplayName", "AssigneeIdentityName", "TaskLink", "ObjectTitle", "ObjectType", "ObjectTypeEnum", "GroupEmail", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskType"))) { #optional property not found
            $TaskType = $null
        } else {
            $TaskType = $JsonParameters.PSobject.Properties["TaskType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReachedTime"))) { #optional property not found
            $ReachedTime = $null
        } else {
            $ReachedTime = $JsonParameters.PSobject.Properties["ReachedTime"].value
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
            "PolicyId" = ${PolicyId}
            "PolicyName" = ${PolicyName}
            "TaskType" = ${TaskType}
            "ReachedTime" = ${ReachedTime}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
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

