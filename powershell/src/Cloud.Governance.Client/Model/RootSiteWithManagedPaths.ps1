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

.PARAMETER RootSite
No description available.

.PARAMETER ManagedPaths
No description available.

.OUTPUTS

RootSiteWithManagedPaths<PSCustomObject>
#>

function New-RootSiteWithManagedPaths {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RootSite},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ManagedPaths}
    )

    Process {
        'Creating object: Cloud.Governance.Client => RootSiteWithManagedPaths' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "rootSite" = ${RootSite}
            "managedPaths" = ${ManagedPaths}
        }

        return $PSO
    }
}
