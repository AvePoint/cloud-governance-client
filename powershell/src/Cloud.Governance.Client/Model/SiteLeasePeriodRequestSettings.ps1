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

.PARAMETER LeaseInterval
No description available.

.PARAMETER LeaseDurationType
No description available.

.PARAMETER LeaseWarningInterval
No description available.

.PARAMETER LeaseWarningDurationType
No description available.

.OUTPUTS

SiteLeasePeriodRequestSettings<PSCustomObject>
#>

function New-SiteLeasePeriodRequestSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseInterval},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseDurationType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseWarningInterval},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseWarningDurationType}
    )

    Process {
        'Creating object: Cloud.Governance.Client => SiteLeasePeriodRequestSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "leaseInterval" = ${LeaseInterval}
            "leaseDurationType" = ${LeaseDurationType}
            "leaseWarningInterval" = ${LeaseWarningInterval}
            "leaseWarningDurationType" = ${LeaseWarningDurationType}
        }

        return $PSO
    }
}
