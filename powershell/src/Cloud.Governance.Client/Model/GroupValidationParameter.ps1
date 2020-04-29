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

.PARAMETER GroupId
No description available.

.PARAMETER IsEditTask
No description available.

.PARAMETER IsFromQuestionnaire
No description available.

.OUTPUTS

GroupValidationParameter<PSCustomObject>
#>

function New-GroupValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEditTask},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsFromQuestionnaire}
    )

    Process {
        'Creating object: Cloud.Governance.Client => GroupValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "groupId" = ${GroupId}
            "isEditTask" = ${IsEditTask}
            "isFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}
