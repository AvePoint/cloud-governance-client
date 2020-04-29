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

.PARAMETER Name
No description available.

.PARAMETER Attribute
No description available.

.PARAMETER Type
No description available.

.OUTPUTS

EmailReferenceModel<PSCustomObject>
#>

function New-EmailReferenceModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Attribute},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type}
    )

    Process {
        'Creating object: Cloud.Governance.Client => EmailReferenceModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "name" = ${Name}
            "attribute" = ${Attribute}
            "type" = ${Type}
        }

        return $PSO
    }
}
