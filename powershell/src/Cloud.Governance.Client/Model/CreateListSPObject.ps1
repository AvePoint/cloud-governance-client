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

.PARAMETER ParentUrl
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER SiteId
No description available.

.OUTPUTS

CreateListSPObject<PSCustomObject>
#>

function New-CreateListSPObject {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentUrl},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId}
    )

    Process {
        'Creating object: Cloud.Governance.Client => CreateListSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "parentUrl" = ${ParentUrl}
            "siteUrl" = ${SiteUrl}
            "siteId" = ${SiteId}
        }

        return $PSO
    }
}