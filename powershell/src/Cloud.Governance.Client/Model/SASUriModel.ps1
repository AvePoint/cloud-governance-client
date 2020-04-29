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

.PARAMETER Uri
No description available.

.PARAMETER FileName
No description available.

.PARAMETER ExpiredTime
No description available.

.OUTPUTS

SASUriModel<PSCustomObject>
#>

function New-SASUriModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Uri},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FileName},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ExpiredTime}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SASUriModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "uri" = ${Uri}
            "fileName" = ${FileName}
            "expiredTime" = ${ExpiredTime}
        }

        return $PSO
    }
}
