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

.PARAMETER ServerResourceQuota
No description available.

.PARAMETER StorageQuota
No description available.

.PARAMETER SharingSetting
No description available.

.PARAMETER IsDesignerEnabled
No description available.

.PARAMETER SiteMaxDepth
No description available.

.PARAMETER SiteMaxDepthType
No description available.

.PARAMETER IsDisplayPolicyIcon
No description available.

.PARAMETER PolicyIconAddress
No description available.

.PARAMETER PolicyDetailReferenceURL
No description available.

.PARAMETER AosSettings
No description available.

.PARAMETER LifecycleSettings
No description available.

.PARAMETER RecertificationSettings
No description available.

.PARAMETER InactivitySettings
No description available.

.PARAMETER LeasePeriodSettings
No description available.

.PARAMETER ElectionSettings
No description available.

.PARAMETER IsOverwriteLifecycleStartTime
No description available.

.PARAMETER Id
No description available.

.PARAMETER Name
No description available.

.PARAMETER Description
No description available.

.PARAMETER Category
No description available.

.PARAMETER TenantId
No description available.

.PARAMETER Status
No description available.

.OUTPUTS

SitePolicyModel<PSCustomObject>
#>

function New-SitePolicyModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${ServerResourceQuota},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${StorageQuota},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SharingSetting},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDesignerEnabled},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${SiteMaxDepth},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${SiteMaxDepthType},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDisplayPolicyIcon},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyIconAddress},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyDetailReferenceURL},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AosSettings},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LifecycleSettings},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RecertificationSettings},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InactivitySettings},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeasePeriodSettings},
        [Parameter(Position = 14, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ElectionSettings},
        [Parameter(Position = 15, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOverwriteLifecycleStartTime},
        [Parameter(Position = 16, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 17, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 18, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 19, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(Position = 20, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TenantId},
        [Parameter(Position = 21, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SitePolicyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "serverResourceQuota" = ${ServerResourceQuota}
            "storageQuota" = ${StorageQuota}
            "sharingSetting" = ${SharingSetting}
            "isDesignerEnabled" = ${IsDesignerEnabled}
            "siteMaxDepth" = ${SiteMaxDepth}
            "siteMaxDepthType" = ${SiteMaxDepthType}
            "isDisplayPolicyIcon" = ${IsDisplayPolicyIcon}
            "policyIconAddress" = ${PolicyIconAddress}
            "policyDetailReferenceURL" = ${PolicyDetailReferenceURL}
            "aosSettings" = ${AosSettings}
            "lifecycleSettings" = ${LifecycleSettings}
            "recertificationSettings" = ${RecertificationSettings}
            "inactivitySettings" = ${InactivitySettings}
            "leasePeriodSettings" = ${LeasePeriodSettings}
            "electionSettings" = ${ElectionSettings}
            "isOverwriteLifecycleStartTime" = ${IsOverwriteLifecycleStartTime}
            "id" = ${Id}
            "name" = ${Name}
            "description" = ${Description}
            "category" = ${Category}
            "tenantId" = ${TenantId}
            "status" = ${Status}
        }

        return $PSO
    }
}