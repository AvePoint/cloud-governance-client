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

Add=1, Update=2, Delete=3, </br>Login=4, Logout=5, Activate=7, </br>Deactivate=8, Cancel=9, Submit=10, </br>Approve=11, Reject=12, Import=13, </br>Export=14, ContinueAccess=15, Extend=16, </br>Archive=17, Completed=18, Apply=19, </br>ChangePolicy=20, Remove=21, Retried=22, </br>Skipped=23, Reassigned=24, Claim=25, </br>Decline=26, SpecifyContact=27, Send=28, </br>

.OUTPUTS

EventAction<PSCustomObject>
#>

function New-EventAction {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating object: Cloud.Governance.Client => EventAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}
