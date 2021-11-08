#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TaskList<PSCustomObject>
#>

function New-TaskList {
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
        ${RequestId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${RequestTicketNumber} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterEmail},
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
        [String]
        ${TaskFullPath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastUpdated},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowEdit} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProgressStatus} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${BatchId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TaskList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequestId" = ${RequestId}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "RequesterEmail" = ${RequesterEmail}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "TaskFullPath" = ${TaskFullPath}
            "LastUpdated" = ${LastUpdated}
            "Category" = ${Category}
            "CategoryDisplayName" = ${CategoryDisplayName}
            "ServiceName" = ${ServiceName}
            "ObjectId" = ${ObjectId}
            "ProfileId" = ${ProfileId}
            "AllowEdit" = ${AllowEdit}
            "ProgressStatus" = ${ProgressStatus}
            "BatchId" = ${BatchId}
        }

        return $PSO
    }
}

<#
TaskList<PSCustomObject>
#>
function ConvertFrom-JsonToTaskList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TaskList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TaskList
        $AllProperties = $("Id", "Title", "Requester", "RequestId", "RequestTicketNumber", "RequesterDisplayName", "RequesterEmail", "DueDate", "DueDateType", "ServiceType", "ServiceTypeDescription", "CreatedTime", "TaskType", "Status", "StatusDescription", "TaskFullPath", "LastUpdated", "Category", "CategoryDisplayName", "ServiceName", "ObjectId", "ProfileId", "AllowEdit", "ProgressStatus", "BatchId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestId"))) { #optional property not found
            $RequestId = $null
        } else {
            $RequestId = $JsonParameters.PSobject.Properties["RequestId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTicketNumber"))) { #optional property not found
            $RequestTicketNumber = $null
        } else {
            $RequestTicketNumber = $JsonParameters.PSobject.Properties["RequestTicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterDisplayName"))) { #optional property not found
            $RequesterDisplayName = $null
        } else {
            $RequesterDisplayName = $JsonParameters.PSobject.Properties["RequesterDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterEmail"))) { #optional property not found
            $RequesterEmail = $null
        } else {
            $RequesterEmail = $JsonParameters.PSobject.Properties["RequesterEmail"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskFullPath"))) { #optional property not found
            $TaskFullPath = $null
        } else {
            $TaskFullPath = $JsonParameters.PSobject.Properties["TaskFullPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastUpdated"))) { #optional property not found
            $LastUpdated = $null
        } else {
            $LastUpdated = $JsonParameters.PSobject.Properties["LastUpdated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryDisplayName"))) { #optional property not found
            $CategoryDisplayName = $null
        } else {
            $CategoryDisplayName = $JsonParameters.PSobject.Properties["CategoryDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceName"))) { #optional property not found
            $ServiceName = $null
        } else {
            $ServiceName = $JsonParameters.PSobject.Properties["ServiceName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProfileId"))) { #optional property not found
            $ProfileId = $null
        } else {
            $ProfileId = $JsonParameters.PSobject.Properties["ProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowEdit"))) { #optional property not found
            $AllowEdit = $null
        } else {
            $AllowEdit = $JsonParameters.PSobject.Properties["AllowEdit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BatchId"))) { #optional property not found
            $BatchId = $null
        } else {
            $BatchId = $JsonParameters.PSobject.Properties["BatchId"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequestId" = ${RequestId}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "RequesterEmail" = ${RequesterEmail}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "TaskFullPath" = ${TaskFullPath}
            "LastUpdated" = ${LastUpdated}
            "Category" = ${Category}
            "CategoryDisplayName" = ${CategoryDisplayName}
            "ServiceName" = ${ServiceName}
            "ObjectId" = ${ObjectId}
            "ProfileId" = ${ProfileId}
            "AllowEdit" = ${AllowEdit}
            "ProgressStatus" = ${ProgressStatus}
            "BatchId" = ${BatchId}
        }

        return $PSO
    }

}

