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

.PARAMETER ExtendType
No description available.

.PARAMETER Duration
No description available.

.PARAMETER DurationType
No description available.

.OUTPUTS

ExtendGroupResult<PSCustomObject>
#>

function New-ExtendGroupResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ExtendGroupResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "extendType" = ${ExtendType}
            "duration" = ${Duration}
            "durationType" = ${DurationType}
        }

        return $PSO
    }
}
