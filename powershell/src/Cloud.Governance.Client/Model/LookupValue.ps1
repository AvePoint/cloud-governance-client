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

.PARAMETER Tenant
No description available.

.PARAMETER Property
No description available.

.PARAMETER TargetUser
No description available.

.PARAMETER UserPropertyValue
No description available.

.PARAMETER UserPropertyDisplayValue
No description available.

.OUTPUTS

LookupValue<PSCustomObject>
#>

function New-LookupValue {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Tenant},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Property},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetUser},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserPropertyValue},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserPropertyDisplayValue}
    )

    Process {
        'Creating object: Cloud.Governance.Client => LookupValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "tenant" = ${Tenant}
            "property" = ${Property}
            "targetUser" = ${TargetUser}
            "userPropertyValue" = ${UserPropertyValue}
            "userPropertyDisplayValue" = ${UserPropertyDisplayValue}
        }

        return $PSO
    }
}
