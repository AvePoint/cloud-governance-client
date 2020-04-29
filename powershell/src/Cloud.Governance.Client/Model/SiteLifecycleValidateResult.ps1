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

.PARAMETER SiteId
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER ChangeQuotaSetting
No description available.

.PARAMETER ExtendSetting
No description available.

.PARAMETER UnlockSetting
No description available.

.PARAMETER ChangePolicySetting
No description available.

.PARAMETER LockSetting
No description available.

.PARAMETER IsValid
No description available.

.PARAMETER ErrorMessage
No description available.

.OUTPUTS

SiteLifecycleValidateResult<PSCustomObject>
#>

function New-SiteLifecycleValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangeQuotaSetting},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendSetting},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UnlockSetting},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePolicySetting},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LockSetting},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SiteLifecycleValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "siteId" = ${SiteId}
            "siteUrl" = ${SiteUrl}
            "changeQuotaSetting" = ${ChangeQuotaSetting}
            "extendSetting" = ${ExtendSetting}
            "unlockSetting" = ${UnlockSetting}
            "changePolicySetting" = ${ChangePolicySetting}
            "lockSetting" = ${LockSetting}
            "isValid" = ${IsValid}
            "errorMessage" = ${ErrorMessage}
        }

        return $PSO
    }
}
