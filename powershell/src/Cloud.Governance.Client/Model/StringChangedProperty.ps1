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

.PARAMETER ChangeValue
No description available.

.PARAMETER OriginalValue
No description available.

.OUTPUTS

StringChangedProperty<PSCustomObject>
#>

function New-StringChangedProperty {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ChangeValue},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalValue}
    )

    Process {
        'Creating object: Cloud.Governance.Client => StringChangedProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "changeValue" = ${ChangeValue}
            "originalValue" = ${OriginalValue}
        }

        return $PSO
    }
}
