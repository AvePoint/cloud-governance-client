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

.PARAMETER IsEnabled
No description available.

.PARAMETER EnableAddOrDelete
No description available.

.PARAMETER Metadatas
No description available.

.OUTPUTS

ChangeMetadataActionSetting<PSCustomObject>
#>

function New-ChangeMetadataActionSetting {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddOrDelete},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChangeMetadataActionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "isEnabled" = ${IsEnabled}
            "enableAddOrDelete" = ${EnableAddOrDelete}
            "metadatas" = ${Metadatas}
        }

        return $PSO
    }
}
