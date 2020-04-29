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

.PARAMETER IsEnabled
No description available.

.PARAMETER ExcludeUsers
No description available.

.PARAMETER IsNotifyTaskEnabled
No description available.

.PARAMETER TaskEmailTemplate
No description available.

.PARAMETER IsNotifyPrimaryContactEnabled
No description available.

.PARAMETER NotifyPrimaryContactTemplate
No description available.

.PARAMETER IsNotifySecondaryContactEnabled
No description available.

.PARAMETER NotifySecondaryContactTemplate
No description available.

.PARAMETER Duration
No description available.

.PARAMETER DurationType
No description available.

.PARAMETER IsReminderEnabled
No description available.

.PARAMETER ReminderProfileId
No description available.

.PARAMETER EnableOnlyOtherContactElection
No description available.

.OUTPUTS

PolicyElectionSetting<PSCustomObject>
#>

function New-PolicyElectionSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ExcludeUsers},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsNotifyTaskEnabled},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskEmailTemplate},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsNotifyPrimaryContactEnabled},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifyPrimaryContactTemplate},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsNotifySecondaryContactEnabled},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifySecondaryContactTemplate},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DurationType},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsReminderEnabled},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ReminderProfileId},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableOnlyOtherContactElection}
    )

    Process {
        'Creating object: Cloud.Governance.Client => PolicyElectionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnabled" = ${IsEnabled}
            "excludeUsers" = ${ExcludeUsers}
            "isNotifyTaskEnabled" = ${IsNotifyTaskEnabled}
            "taskEmailTemplate" = ${TaskEmailTemplate}
            "isNotifyPrimaryContactEnabled" = ${IsNotifyPrimaryContactEnabled}
            "notifyPrimaryContactTemplate" = ${NotifyPrimaryContactTemplate}
            "isNotifySecondaryContactEnabled" = ${IsNotifySecondaryContactEnabled}
            "notifySecondaryContactTemplate" = ${NotifySecondaryContactTemplate}
            "duration" = ${Duration}
            "durationType" = ${DurationType}
            "isReminderEnabled" = ${IsReminderEnabled}
            "reminderProfileId" = ${ReminderProfileId}
            "enableOnlyOtherContactElection" = ${EnableOnlyOtherContactElection}
        }

        return $PSO
    }
}
