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

None=0, Owners=1, Members=2, </br>Visitors=3

.OUTPUTS

SharePointBuildInGroupType<PSCustomObject>
#>

function New-SharePointBuildInGroupType {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => SharePointBuildInGroupType' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}