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

.PARAMETER TermStore
No description available.

.PARAMETER TermGroup
No description available.

.PARAMETER TermSet
No description available.

.PARAMETER Value
No description available.

.OUTPUTS

TermsValue<PSCustomObject>
#>

function New-TermsValue {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermStore},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermGroup},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermSet},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Value}
    )

    Process {
        'Creating object: Cloud.Governance.Client => TermsValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "termStore" = ${TermStore}
            "termGroup" = ${TermGroup}
            "termSet" = ${TermSet}
            "value" = ${Value}
        }

        return $PSO
    }
}
