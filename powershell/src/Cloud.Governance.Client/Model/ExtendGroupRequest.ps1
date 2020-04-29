#
# Cloud Governance Api
# No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
# Version: 1.0
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

No description available.

.PARAMETER ExtendDuration
No description available.

.PARAMETER ExtendDurationType
No description available.

.PARAMETER GroupId
No description available.

.PARAMETER GroupName
No description available.

.PARAMETER GroupEmail
No description available.

.PARAMETER Id
No description available.

.PARAMETER ServiceId
No description available.

.PARAMETER Department
No description available.

.PARAMETER Summary
No description available.

.PARAMETER NotesToApprovers
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER Metadatas
No description available.

.PARAMETER TicketNumber
No description available.

.PARAMETER Type
No description available.

.PARAMETER TypeDescription
No description available.

.PARAMETER Requester
No description available.

.PARAMETER Status
No description available.

.PARAMETER ProgressStatus
No description available.

.PARAMETER ProgressStatusDescription
No description available.

.PARAMETER SubmittedTime
No description available.

.PARAMETER LastUpdated
No description available.

.PARAMETER CreatedTime
No description available.

.PARAMETER AssignTo
No description available.

.PARAMETER FullPath
No description available.

.OUTPUTS

ExtendGroupRequest<PSCustomObject>
#>

function New-ExtendGroupRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExtendDuration},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendDurationType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupId},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceId},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NotesToApprovers},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${QuestionnaireId},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TicketNumber},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ProgressStatus},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProgressStatusDescription},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${SubmittedTime},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastUpdated},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(Position = 22, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignTo},
        [Parameter(Position = 23, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullPath}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ExtendGroupRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "extendDuration" = ${ExtendDuration}
            "extendDurationType" = ${ExtendDurationType}
            "groupId" = ${GroupId}
            "groupName" = ${GroupName}
            "groupEmail" = ${GroupEmail}
            "id" = ${Id}
            "serviceId" = ${ServiceId}
            "department" = ${Department}
            "summary" = ${Summary}
            "notesToApprovers" = ${NotesToApprovers}
            "questionnaireId" = ${QuestionnaireId}
            "metadatas" = ${Metadatas}
            "ticketNumber" = ${TicketNumber}
            "type" = ${Type}
            "typeDescription" = ${TypeDescription}
            "requester" = ${Requester}
            "status" = ${Status}
            "progressStatus" = ${ProgressStatus}
            "progressStatusDescription" = ${ProgressStatusDescription}
            "submittedTime" = ${SubmittedTime}
            "lastUpdated" = ${LastUpdated}
            "createdTime" = ${CreatedTime}
            "assignTo" = ${AssignTo}
            "fullPath" = ${FullPath}
        }

        return $PSO
    }
}
