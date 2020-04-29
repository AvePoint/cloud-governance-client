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

.PARAMETER EnableInstallApp
No description available.

.PARAMETER EnableAddSiteInfoCard
No description available.

.PARAMETER EnableAddTimeLine
No description available.

.PARAMETER EnableAddPanel
No description available.

.OUTPUTS

AppSettings<PSCustomObject>
#>

function New-AppSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallApp},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddSiteInfoCard},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddTimeLine},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddPanel}
    )

    Process {
        'Creating object: Cloud.Governance.Client => AppSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "enableInstallApp" = ${EnableInstallApp}
            "enableAddSiteInfoCard" = ${EnableAddSiteInfoCard}
            "enableAddTimeLine" = ${EnableAddTimeLine}
            "enableAddPanel" = ${EnableAddPanel}
        }

        return $PSO
    }
}
