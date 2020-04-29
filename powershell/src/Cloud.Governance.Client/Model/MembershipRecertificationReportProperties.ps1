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

.PARAMETER O365TenantId
No description available.

.PARAMETER IsDynamicMembership
No description available.

.PARAMETER EnableRecertifyOwners
No description available.

.PARAMETER EnableRecertifyMembers
No description available.

.PARAMETER ObjectId
No description available.

.PARAMETER ObjectName
No description available.

.PARAMETER IsAllowedReassign
No description available.

.PARAMETER ReportGeneratedTime
No description available.

.PARAMETER RequestSummary
No description available.

.OUTPUTS

MembershipRecertificationReportProperties<PSCustomObject>
#>

function New-MembershipRecertificationReportProperties {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${O365TenantId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDynamicMembership},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRecertifyOwners},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRecertifyMembers},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ObjectId},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectName},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowedReassign},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ReportGeneratedTime},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequestSummary}
    )

    Process {
        'Creating object: Cloud.Governance.Client => MembershipRecertificationReportProperties' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "o365TenantId" = ${O365TenantId}
            "isDynamicMembership" = ${IsDynamicMembership}
            "enableRecertifyOwners" = ${EnableRecertifyOwners}
            "enableRecertifyMembers" = ${EnableRecertifyMembers}
            "objectId" = ${ObjectId}
            "objectName" = ${ObjectName}
            "isAllowedReassign" = ${IsAllowedReassign}
            "reportGeneratedTime" = ${ReportGeneratedTime}
            "requestSummary" = ${RequestSummary}
        }

        return $PSO
    }
}
