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

None=0, Extend=1, Delete=2, </br>Archive=3, Policy=4, Unlock=5, </br>Continue=6, Lock=7, Quota=8, </br>

.OUTPUTS

LifecycleAction<PSCustomObject>
#>

function New-LifecycleAction {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => LifecycleAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}
