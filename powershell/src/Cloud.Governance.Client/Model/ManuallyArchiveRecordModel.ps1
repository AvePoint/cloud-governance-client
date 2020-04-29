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

.PARAMETER RowKey
No description available.

.PARAMETER PartitionKey
No description available.

.PARAMETER SiteId
No description available.

.PARAMETER Url
No description available.

.PARAMETER Version
No description available.

.PARAMETER IsSelected
No description available.

.PARAMETER NodeType
No description available.

.PARAMETER NodeTypeDescription
No description available.

.OUTPUTS

ManuallyArchiveRecordModel<PSCustomObject>
#>

function New-ManuallyArchiveRecordModel {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${RowKey},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PartitionKey},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Version},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSelected},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NodeType},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NodeTypeDescription}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ManuallyArchiveRecordModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "rowKey" = ${RowKey}
            "partitionKey" = ${PartitionKey}
            "siteId" = ${SiteId}
            "url" = ${Url}
            "version" = ${Version}
            "isSelected" = ${IsSelected}
            "nodeType" = ${NodeType}
            "nodeTypeDescription" = ${NodeTypeDescription}
        }

        return $PSO
    }
}
