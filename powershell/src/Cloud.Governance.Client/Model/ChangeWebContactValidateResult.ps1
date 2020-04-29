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

.PARAMETER SiteId
No description available.

.PARAMETER SiteUrl
No description available.

.PARAMETER WebId
No description available.

.PARAMETER WebUrl
No description available.

.PARAMETER PrimaryContact
No description available.

.PARAMETER SecondaryContact
No description available.

.PARAMETER IsValid
No description available.

.PARAMETER ErrorMessage
No description available.

.OUTPUTS

ChangeWebContactValidateResult<PSCustomObject>
#>

function New-ChangeWebContactValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebId},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangeWebContactValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "siteId" = ${SiteId}
            "siteUrl" = ${SiteUrl}
            "webId" = ${WebId}
            "webUrl" = ${WebUrl}
            "primaryContact" = ${PrimaryContact}
            "secondaryContact" = ${SecondaryContact}
            "isValid" = ${IsValid}
            "errorMessage" = ${ErrorMessage}
        }

        return $PSO
    }
}
