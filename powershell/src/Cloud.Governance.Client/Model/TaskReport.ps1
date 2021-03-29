#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TaskReport<PSCustomObject>
#>

function New-TaskReport {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterLoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${RequestTicketNumber} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${DueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DueDateType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskType} = "ApprovalTask",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Running",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsApproveTask} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Assignee},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeLoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssigneeDisplayName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TaskReport' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequesterLoginName" = ${RequesterLoginName}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "IsApproveTask" = ${IsApproveTask}
            "Assignee" = ${Assignee}
            "AssigneeLoginName" = ${AssigneeLoginName}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
        }

        return $PSO
    }
}

<#
TaskReport<PSCustomObject>
#>
function ConvertFrom-JsonToTaskReport {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TaskReport' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TaskReport
        $AllProperties = $("Id", "Title", "Requester", "RequesterLoginName", "RequesterDisplayName", "RequestTicketNumber", "DueDate", "DueDateType", "ServiceType", "ServiceTypeDescription", "CreatedTime", "TaskType", "Status", "StatusDescription", "IsApproveTask", "Assignee", "AssigneeLoginName", "AssigneeDisplayName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterLoginName"))) { #optional property not found
            $RequesterLoginName = $null
        } else {
            $RequesterLoginName = $JsonParameters.PSobject.Properties["RequesterLoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterDisplayName"))) { #optional property not found
            $RequesterDisplayName = $null
        } else {
            $RequesterDisplayName = $JsonParameters.PSobject.Properties["RequesterDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTicketNumber"))) { #optional property not found
            $RequestTicketNumber = $null
        } else {
            $RequestTicketNumber = $JsonParameters.PSobject.Properties["RequestTicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DueDate"))) { #optional property not found
            $DueDate = $null
        } else {
            $DueDate = $JsonParameters.PSobject.Properties["DueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DueDateType"))) { #optional property not found
            $DueDateType = $null
        } else {
            $DueDateType = $JsonParameters.PSobject.Properties["DueDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeDescription"))) { #optional property not found
            $ServiceTypeDescription = $null
        } else {
            $ServiceTypeDescription = $JsonParameters.PSobject.Properties["ServiceTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskType"))) { #optional property not found
            $TaskType = $null
        } else {
            $TaskType = $JsonParameters.PSobject.Properties["TaskType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsApproveTask"))) { #optional property not found
            $IsApproveTask = $null
        } else {
            $IsApproveTask = $JsonParameters.PSobject.Properties["IsApproveTask"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Assignee"))) { #optional property not found
            $Assignee = $null
        } else {
            $Assignee = $JsonParameters.PSobject.Properties["Assignee"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssigneeLoginName"))) { #optional property not found
            $AssigneeLoginName = $null
        } else {
            $AssigneeLoginName = $JsonParameters.PSobject.Properties["AssigneeLoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssigneeDisplayName"))) { #optional property not found
            $AssigneeDisplayName = $null
        } else {
            $AssigneeDisplayName = $JsonParameters.PSobject.Properties["AssigneeDisplayName"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequesterLoginName" = ${RequesterLoginName}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "IsApproveTask" = ${IsApproveTask}
            "Assignee" = ${Assignee}
            "AssigneeLoginName" = ${AssigneeLoginName}
            "AssigneeDisplayName" = ${AssigneeDisplayName}
        }

        return $PSO
    }

}

