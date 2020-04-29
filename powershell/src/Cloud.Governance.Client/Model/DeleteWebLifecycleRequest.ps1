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

.PARAMETER Action
No description available.

.PARAMETER WebId
No description available.

.PARAMETER WebUrl
No description available.

.PARAMETER WebRelativeUrl
No description available.

.PARAMETER SiteId
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER ActionDescription
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

DeleteWebLifecycleRequest<PSCustomObject>
#>

function New-DeleteWebLifecycleRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebRelativeUrl},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ActionDescription},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceId},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NotesToApprovers},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${QuestionnaireId},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TicketNumber},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ProgressStatus},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProgressStatusDescription},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${SubmittedTime},
        [Parameter(Position = 22, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastUpdated},
        [Parameter(Position = 23, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(Position = 24, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignTo},
        [Parameter(Position = 25, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullPath}
    )

    Process {
        'Creating object: Cloud.Governance.Client => DeleteWebLifecycleRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "action" = ${Action}
            "webId" = ${WebId}
            "webUrl" = ${WebUrl}
            "webRelativeUrl" = ${WebRelativeUrl}
            "siteId" = ${SiteId}
            "siteUrl" = ${SiteUrl}
            "actionDescription" = ${ActionDescription}
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
