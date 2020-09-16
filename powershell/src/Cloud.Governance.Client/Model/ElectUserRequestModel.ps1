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

.PARAMETER Title
No description available.

.PARAMETER ExcludeUsers
No description available.

.PARAMETER EnableNotifyTask
No description available.

.PARAMETER TaskEmailTemplateId
No description available.

.PARAMETER EnableNotifyPrimaryContact
No description available.

.PARAMETER NotifyPrimaryContactTemplateId
No description available.

.PARAMETER EnableNotifySecondaryContact
No description available.

.PARAMETER NotifySecondaryContactTemplateId
No description available.

.PARAMETER Duration
No description available.

.PARAMETER DurationType
No description available.

.PARAMETER IsEnableTaskReminder
No description available.

.PARAMETER TaskReminderProfileId
No description available.

.PARAMETER SelectedSiteIds
No description available.

.OUTPUTS

ElectUserRequestModel<PSCustomObject>
#>

function New-ElectUserRequestModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ExcludeUsers},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableNotifyTask},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskEmailTemplateId},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableNotifyPrimaryContact},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifyPrimaryContactTemplateId},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableNotifySecondaryContact},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifySecondaryContactTemplateId},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableTaskReminder},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskReminderProfileId},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SelectedSiteIds}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ElectUserRequestModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "title" = ${Title}
            "excludeUsers" = ${ExcludeUsers}
            "enableNotifyTask" = ${EnableNotifyTask}
            "taskEmailTemplateId" = ${TaskEmailTemplateId}
            "enableNotifyPrimaryContact" = ${EnableNotifyPrimaryContact}
            "notifyPrimaryContactTemplateId" = ${NotifyPrimaryContactTemplateId}
            "enableNotifySecondaryContact" = ${EnableNotifySecondaryContact}
            "notifySecondaryContactTemplateId" = ${NotifySecondaryContactTemplateId}
            "duration" = ${Duration}
            "durationType" = ${DurationType}
            "isEnableTaskReminder" = ${IsEnableTaskReminder}
            "taskReminderProfileId" = ${TaskReminderProfileId}
            "selectedSiteIds" = ${SelectedSiteIds}
        }

        return $PSO
    }
}