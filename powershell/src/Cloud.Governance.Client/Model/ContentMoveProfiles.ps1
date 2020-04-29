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

.PARAMETER BackupEnvironmentStoragePolices
No description available.

.PARAMETER ColumnMappings
No description available.

.PARAMETER ContentTypeMappings
No description available.

.PARAMETER UserMappings
No description available.

.PARAMETER LanguageMappings
No description available.

.PARAMETER FilterPolices
No description available.

.OUTPUTS

ContentMoveProfiles<PSCustomObject>
#>

function New-ContentMoveProfiles {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${BackupEnvironmentStoragePolices},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ColumnMappings},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ContentTypeMappings},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserMappings},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${LanguageMappings},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${FilterPolices}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ContentMoveProfiles' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "backupEnvironmentStoragePolices" = ${BackupEnvironmentStoragePolices}
            "columnMappings" = ${ColumnMappings}
            "contentTypeMappings" = ${ContentTypeMappings}
            "userMappings" = ${UserMappings}
            "languageMappings" = ${LanguageMappings}
            "filterPolices" = ${FilterPolices}
        }

        return $PSO
    }
}
