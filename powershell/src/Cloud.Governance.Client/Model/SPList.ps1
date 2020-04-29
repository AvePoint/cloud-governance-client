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

.PARAMETER Id
No description available.

.PARAMETER Title
No description available.

.PARAMETER Url
No description available.

.PARAMETER Description
No description available.

.PARAMETER IsLibrary
No description available.

.PARAMETER IsOnQuickLaunch
No description available.

.PARAMETER IsEnableModeration
No description available.

.PARAMETER IsEnableVersioning
No description available.

.PARAMETER IsEnableMinorVersion
No description available.

.PARAMETER MajorVersionLimit
No description available.

.PARAMETER MajorWithMinorVersionsLimit
No description available.

.OUTPUTS

SPList<PSCustomObject>
#>

function New-SPList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsLibrary},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnQuickLaunch},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableModeration},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableVersioning},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableMinorVersion},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MajorVersionLimit},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MajorWithMinorVersionsLimit}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SPList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "title" = ${Title}
            "url" = ${Url}
            "description" = ${Description}
            "isLibrary" = ${IsLibrary}
            "isOnQuickLaunch" = ${IsOnQuickLaunch}
            "isEnableModeration" = ${IsEnableModeration}
            "isEnableVersioning" = ${IsEnableVersioning}
            "isEnableMinorVersion" = ${IsEnableMinorVersion}
            "majorVersionLimit" = ${MajorVersionLimit}
            "majorWithMinorVersionsLimit" = ${MajorWithMinorVersionsLimit}
        }

        return $PSO
    }
}
