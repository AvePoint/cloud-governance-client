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

.PARAMETER Profile
No description available.

.PARAMETER IsNotifyEnabled
No description available.

.PARAMETER NotifyUser
No description available.

.PARAMETER NotifyTemplate
No description available.

.PARAMETER IsEnabled
No description available.

.PARAMETER IsDefaultProcess
No description available.

.PARAMETER Process
No description available.

.OUTPUTS

SiteArchiveLifecycleItem<PSCustomObject>
#>

function New-SiteArchiveLifecycleItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Profile},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsNotifyEnabled},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${NotifyUser},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifyTemplate},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDefaultProcess},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Process}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SiteArchiveLifecycleItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "profile" = ${Profile}
            "isNotifyEnabled" = ${IsNotifyEnabled}
            "notifyUser" = ${NotifyUser}
            "notifyTemplate" = ${NotifyTemplate}
            "isEnabled" = ${IsEnabled}
            "isDefaultProcess" = ${IsDefaultProcess}
            "process" = ${Process}
        }

        return $PSO
    }
}