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

.PARAMETER Id
No description available.

.PARAMETER Description
No description available.

.PARAMETER Title
No description available.

.PARAMETER Url
No description available.

.PARAMETER Template
No description available.

.PARAMETER PrimaryContact
No description available.

.PARAMETER PrimaryContactDisplayName
No description available.

.PARAMETER SecondaryContact
No description available.

.PARAMETER SecondaryContactDisplayName
No description available.

.PARAMETER CreatedTime
No description available.

.PARAMETER Status
No description available.

.PARAMETER StatusDescription
No description available.

.PARAMETER Metadata
No description available.

.OUTPUTS

WebList<PSCustomObject>
#>

function New-WebList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Template},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactDisplayName},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContact},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactDisplayName},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedTime},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating object: Cloud.Governance.Client => WebList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "id" = ${Id}
            "description" = ${Description}
            "title" = ${Title}
            "url" = ${Url}
            "template" = ${Template}
            "primaryContact" = ${PrimaryContact}
            "primaryContactDisplayName" = ${PrimaryContactDisplayName}
            "secondaryContact" = ${SecondaryContact}
            "secondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "createdTime" = ${CreatedTime}
            "status" = ${Status}
            "statusDescription" = ${StatusDescription}
            "metadata" = ${Metadata}
        }

        return $PSO
    }
}
