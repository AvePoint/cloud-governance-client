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

.PARAMETER InstanceId
No description available.

.PARAMETER MetadataActionInstanceId
No description available.

.PARAMETER IsEnabled
No description available.

.PARAMETER IsEnabledText
No description available.

.OUTPUTS

MetadataActionLockItem<PSCustomObject>
#>

function New-MetadataActionLockItem {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InstanceId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MetadataActionInstanceId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IsEnabledText}
    )

    Process {
        'Creating object: Cloud.Governance.Client => MetadataActionLockItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "instanceId" = ${InstanceId}
            "metadataActionInstanceId" = ${MetadataActionInstanceId}
            "isEnabled" = ${IsEnabled}
            "isEnabledText" = ${IsEnabledText}
        }

        return $PSO
    }
}