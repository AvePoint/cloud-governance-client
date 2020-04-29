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

.PARAMETER LinkType
No description available.

.PARAMETER HelpLink
No description available.

.OUTPUTS

CustomHelpLinkModel<PSCustomObject>
#>

function New-CustomHelpLinkModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LinkType},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${HelpLink}
    )

    Process {
        'Creating object: Cloud.Governance.Client => CustomHelpLinkModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "linkType" = ${LinkType}
            "helpLink" = ${HelpLink}
        }

        return $PSO
    }
}
