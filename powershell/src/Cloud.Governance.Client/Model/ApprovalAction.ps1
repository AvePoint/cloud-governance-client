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

Reject=0, Approval=1

.OUTPUTS

ApprovalAction<PSCustomObject>
#>

function New-ApprovalAction {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => ApprovalAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}