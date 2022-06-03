#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AllRequestList<PSCustomObject>
#>

function New-AllRequestList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalStageName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Participants},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParticipantDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TicketNumber} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DetailStatus} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DetailStatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProgressStatus} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProgressStatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${Modified},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignTo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignToDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Assignees},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceAdminDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasSubRequest} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AllRequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Category" = ${Category}
            "CategoryName" = ${CategoryName}
            "ApprovalStageName" = ${ApprovalStageName}
            "Participants" = ${Participants}
            "ParticipantDisplayName" = ${ParticipantDisplayName}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Requester" = ${Requester}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DetailStatus" = ${DetailStatus}
            "DetailStatusDescription" = ${DetailStatusDescription}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "Modified" = ${Modified}
            "AssignTo" = ${AssignTo}
            "AssignToDisplayName" = ${AssignToDisplayName}
            "Assignees" = ${Assignees}
            "ServiceAdmin" = ${ServiceAdmin}
            "ServiceAdminDisplayName" = ${ServiceAdminDisplayName}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectID" = ${ObjectID}
            "CreatedTime" = ${CreatedTime}
            "HasSubRequest" = ${HasSubRequest}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }
}

<#
AllRequestList<PSCustomObject>
#>
function ConvertFrom-JsonToAllRequestList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AllRequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AllRequestList
        $AllProperties = $("Id", "ServiceId", "ServiceName", "ServiceType", "ServiceTypeDescription", "Category", "CategoryName", "ApprovalStageName", "Participants", "ParticipantDisplayName", "TicketNumber", "Summary", "Requester", "RequesterDisplayName", "DetailStatus", "DetailStatusDescription", "ProgressStatus", "ProgressStatusDescription", "Modified", "AssignTo", "AssignToDisplayName", "Assignees", "ServiceAdmin", "ServiceAdminDisplayName", "ObjectUrl", "ObjectID", "CreatedTime", "HasSubRequest", "Metadata")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceId"))) { #optional property not found
            $ServiceId = $null
        } else {
            $ServiceId = $JsonParameters.PSobject.Properties["ServiceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceName"))) { #optional property not found
            $ServiceName = $null
        } else {
            $ServiceName = $JsonParameters.PSobject.Properties["ServiceName"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryName"))) { #optional property not found
            $CategoryName = $null
        } else {
            $CategoryName = $JsonParameters.PSobject.Properties["CategoryName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalStageName"))) { #optional property not found
            $ApprovalStageName = $null
        } else {
            $ApprovalStageName = $JsonParameters.PSobject.Properties["ApprovalStageName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Participants"))) { #optional property not found
            $Participants = $null
        } else {
            $Participants = $JsonParameters.PSobject.Properties["Participants"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParticipantDisplayName"))) { #optional property not found
            $ParticipantDisplayName = $null
        } else {
            $ParticipantDisplayName = $JsonParameters.PSobject.Properties["ParticipantDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TicketNumber"))) { #optional property not found
            $TicketNumber = $null
        } else {
            $TicketNumber = $JsonParameters.PSobject.Properties["TicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterDisplayName"))) { #optional property not found
            $RequesterDisplayName = $null
        } else {
            $RequesterDisplayName = $JsonParameters.PSobject.Properties["RequesterDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DetailStatus"))) { #optional property not found
            $DetailStatus = $null
        } else {
            $DetailStatus = $JsonParameters.PSobject.Properties["DetailStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DetailStatusDescription"))) { #optional property not found
            $DetailStatusDescription = $null
        } else {
            $DetailStatusDescription = $JsonParameters.PSobject.Properties["DetailStatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatusDescription"))) { #optional property not found
            $ProgressStatusDescription = $null
        } else {
            $ProgressStatusDescription = $JsonParameters.PSobject.Properties["ProgressStatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Modified"))) { #optional property not found
            $Modified = $null
        } else {
            $Modified = $JsonParameters.PSobject.Properties["Modified"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignToDisplayName"))) { #optional property not found
            $AssignToDisplayName = $null
        } else {
            $AssignToDisplayName = $JsonParameters.PSobject.Properties["AssignToDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Assignees"))) { #optional property not found
            $Assignees = $null
        } else {
            $Assignees = $JsonParameters.PSobject.Properties["Assignees"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdmin"))) { #optional property not found
            $ServiceAdmin = $null
        } else {
            $ServiceAdmin = $JsonParameters.PSobject.Properties["ServiceAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdminDisplayName"))) { #optional property not found
            $ServiceAdminDisplayName = $null
        } else {
            $ServiceAdminDisplayName = $JsonParameters.PSobject.Properties["ServiceAdminDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectID"))) { #optional property not found
            $ObjectID = $null
        } else {
            $ObjectID = $JsonParameters.PSobject.Properties["ObjectID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasSubRequest"))) { #optional property not found
            $HasSubRequest = $null
        } else {
            $HasSubRequest = $JsonParameters.PSobject.Properties["HasSubRequest"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Category" = ${Category}
            "CategoryName" = ${CategoryName}
            "ApprovalStageName" = ${ApprovalStageName}
            "Participants" = ${Participants}
            "ParticipantDisplayName" = ${ParticipantDisplayName}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Requester" = ${Requester}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DetailStatus" = ${DetailStatus}
            "DetailStatusDescription" = ${DetailStatusDescription}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "Modified" = ${Modified}
            "AssignTo" = ${AssignTo}
            "AssignToDisplayName" = ${AssignToDisplayName}
            "Assignees" = ${Assignees}
            "ServiceAdmin" = ${ServiceAdmin}
            "ServiceAdminDisplayName" = ${ServiceAdminDisplayName}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectID" = ${ObjectID}
            "CreatedTime" = ${CreatedTime}
            "HasSubRequest" = ${HasSubRequest}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }

}

