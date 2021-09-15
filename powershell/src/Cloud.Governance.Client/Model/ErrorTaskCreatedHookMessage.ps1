#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ErrorTaskCreatedHookMessage<PSCustomObject>
#>

function New-ErrorTaskCreatedHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Message},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeIdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${RequestId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequestGuid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterIdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceTypeEnum} = "None",
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
        'Creating PSCustomObject: Cloud.Governance.Client => ErrorTaskCreatedHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Message" = ${Message}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
            "TaskId" = ${TaskId}
            "TaskLink" = ${TaskLink}
            "RequestId" = ${RequestId}
            "RequestGuid" = ${RequestGuid}
            "RequesterIdentityName" = ${RequesterIdentityName}
            "Requester" = ${Requester}
            "ServiceType" = ${ServiceType}
            "ServiceTypeEnum" = ${ServiceTypeEnum}
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
ErrorTaskCreatedHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToErrorTaskCreatedHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ErrorTaskCreatedHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ErrorTaskCreatedHookMessage
        $AllProperties = $("Message", "AssigneeDisplayName", "AssigneeIdentityName", "TaskId", "TaskLink", "RequestId", "RequestGuid", "RequesterIdentityName", "Requester", "ServiceType", "ServiceTypeEnum", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Message"))) { #optional property not found
            $Message = $null
        } else {
            $Message = $JsonParameters.PSobject.Properties["Message"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskId"))) { #optional property not found
            $TaskId = $null
        } else {
            $TaskId = $JsonParameters.PSobject.Properties["TaskId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskLink"))) { #optional property not found
            $TaskLink = $null
        } else {
            $TaskLink = $JsonParameters.PSobject.Properties["TaskLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestId"))) { #optional property not found
            $RequestId = $null
        } else {
            $RequestId = $JsonParameters.PSobject.Properties["RequestId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestGuid"))) { #optional property not found
            $RequestGuid = $null
        } else {
            $RequestGuid = $JsonParameters.PSobject.Properties["RequestGuid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterIdentityName"))) { #optional property not found
            $RequesterIdentityName = $null
        } else {
            $RequesterIdentityName = $JsonParameters.PSobject.Properties["RequesterIdentityName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeEnum"))) { #optional property not found
            $ServiceTypeEnum = $null
        } else {
            $ServiceTypeEnum = $JsonParameters.PSobject.Properties["ServiceTypeEnum"].value
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
            "Message" = ${Message}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
            "AssigneeIdentityName" = ${AssigneeIdentityName}
            "TaskId" = ${TaskId}
            "TaskLink" = ${TaskLink}
            "RequestId" = ${RequestId}
            "RequestGuid" = ${RequestGuid}
            "RequesterIdentityName" = ${RequesterIdentityName}
            "Requester" = ${Requester}
            "ServiceType" = ${ServiceType}
            "ServiceTypeEnum" = ${ServiceTypeEnum}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }

}

