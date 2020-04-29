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

.PARAMETER AllowedAnySize
No description available.

.PARAMETER MinQuotaSize
No description available.

.PARAMETER MaxQuotaSize
No description available.

.PARAMETER CurrentQuotaSize
No description available.

.OUTPUTS

ChangeSiteQuotaSettings<PSCustomObject>
#>

function New-ChangeSiteQuotaSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowedAnySize},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MinQuotaSize},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaxQuotaSize},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${CurrentQuotaSize}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangeSiteQuotaSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "allowedAnySize" = ${AllowedAnySize}
            "minQuotaSize" = ${MinQuotaSize}
            "maxQuotaSize" = ${MaxQuotaSize}
            "currentQuotaSize" = ${CurrentQuotaSize}
        }

        return $PSO
    }
}
