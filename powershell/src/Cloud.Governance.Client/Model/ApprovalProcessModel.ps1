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

.PARAMETER CompletionTemplateId
No description available.

.PARAMETER StageOne
No description available.

.PARAMETER StageTwo
No description available.

.PARAMETER StageThree
No description available.

.PARAMETER StageSettings
No description available.

.PARAMETER Id
No description available.

.PARAMETER Name
No description available.

.PARAMETER Description
No description available.

.PARAMETER Status
No description available.

.PARAMETER Category
No description available.

.PARAMETER Cc
No description available.

.OUTPUTS

ApprovalProcessModel<PSCustomObject>
#>

function New-ApprovalProcessModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CompletionTemplateId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StageOne},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StageTwo},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StageThree},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StageSettings},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Cc}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ApprovalProcessModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "completionTemplateId" = ${CompletionTemplateId}
            "stageOne" = ${StageOne}
            "stageTwo" = ${StageTwo}
            "stageThree" = ${StageThree}
            "stageSettings" = ${StageSettings}
            "id" = ${Id}
            "name" = ${Name}
            "description" = ${Description}
            "status" = ${Status}
            "category" = ${Category}
            "cc" = ${Cc}
        }

        return $PSO
    }
}
