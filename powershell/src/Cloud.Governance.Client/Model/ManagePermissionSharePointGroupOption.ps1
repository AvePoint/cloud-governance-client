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

.PARAMETER IsEnableCreateSPGroup
No description available.

.PARAMETER IsEnableDeleteSPGroup
No description available.

.PARAMETER IsEnableManageGroupSettings
No description available.

.PARAMETER IsEnableManageGroupMembers
No description available.

.PARAMETER GroupOwner
No description available.

.PARAMETER GroupOwnerAssignBy
No description available.

.PARAMETER SpGroupViewType
No description available.

.PARAMETER SpGroupEditType
No description available.

.PARAMETER SpGroupOptionAssignBy
No description available.

.PARAMETER IsAllowJoinOrLeaveRequest
No description available.

.PARAMETER IsAutoAcceptRequest
No description available.

.PARAMETER SendMembershipRequestEmailAddress
No description available.

.PARAMETER GroupRequestAssignBy
No description available.

.OUTPUTS

ManagePermissionSharePointGroupOption<PSCustomObject>
#>

function New-ManagePermissionSharePointGroupOption {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableCreateSPGroup},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableDeleteSPGroup},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableManageGroupSettings},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableManageGroupMembers},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwner},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwnerAssignBy},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupViewType},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupEditType},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupOptionAssignBy},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowJoinOrLeaveRequest},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAutoAcceptRequest},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SendMembershipRequestEmailAddress},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupRequestAssignBy}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ManagePermissionSharePointGroupOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnableCreateSPGroup" = ${IsEnableCreateSPGroup}
            "isEnableDeleteSPGroup" = ${IsEnableDeleteSPGroup}
            "isEnableManageGroupSettings" = ${IsEnableManageGroupSettings}
            "isEnableManageGroupMembers" = ${IsEnableManageGroupMembers}
            "groupOwner" = ${GroupOwner}
            "groupOwnerAssignBy" = ${GroupOwnerAssignBy}
            "spGroupViewType" = ${SpGroupViewType}
            "spGroupEditType" = ${SpGroupEditType}
            "spGroupOptionAssignBy" = ${SpGroupOptionAssignBy}
            "isAllowJoinOrLeaveRequest" = ${IsAllowJoinOrLeaveRequest}
            "isAutoAcceptRequest" = ${IsAutoAcceptRequest}
            "sendMembershipRequestEmailAddress" = ${SendMembershipRequestEmailAddress}
            "groupRequestAssignBy" = ${GroupRequestAssignBy}
        }

        return $PSO
    }
}
