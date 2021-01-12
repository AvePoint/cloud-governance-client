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
        [System.Nullable[Int32]]
        ${RequestTicketNumber},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${DueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DueDateType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TaskList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
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
        $AllProperties = $("Id", "Title", "Requester", "RequestTicketNumber", "RequesterDisplayName", "DueDate", "DueDateType", "ServiceType", "ServiceTypeDescription", "CreatedTime", "TaskType", "Status", "StatusDescription")
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

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Requester" = ${Requester}
            "RequestTicketNumber" = ${RequestTicketNumber}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DueDate" = ${DueDate}
            "DueDateType" = ${DueDateType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "CreatedTime" = ${CreatedTime}
            "TaskType" = ${TaskType}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
        }

        return $PSO
    }

}

