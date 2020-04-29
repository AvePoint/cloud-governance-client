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

.PARAMETER XAxisList
No description available.

.PARAMETER YAxisList
No description available.

.PARAMETER LegendSourceList
No description available.

.PARAMETER LegendEntriesList
No description available.

.PARAMETER Id
No description available.

.PARAMETER Title
No description available.

.PARAMETER Description
No description available.

.PARAMETER DataSource
No description available.

.PARAMETER Type
No description available.

.PARAMETER XAxis
No description available.

.PARAMETER YAxis
No description available.

.PARAMETER EnableLegend
No description available.

.PARAMETER LegendSource
No description available.

.PARAMETER LegendEntries
No description available.

.OUTPUTS

ChartSettings<PSCustomObject>
#>

function New-ChartSettings {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${XAxisList},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${YAxisList},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${LegendSourceList},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${LegendEntriesList},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(Position = 6, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(Position = 7, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DataSource},
        [Parameter(Position = 8, ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(Position = 9, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${XAxis},
        [Parameter(Position = 10, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${YAxis},
        [Parameter(Position = 11, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableLegend},
        [Parameter(Position = 12, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LegendSource},
        [Parameter(Position = 13, ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${LegendEntries}
    )

    Process {
        'Creating object: Cloud.Governance.Client => ChartSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $PSO = [PSCustomObject]@{
            "xAxisList" = ${XAxisList}
            "yAxisList" = ${YAxisList}
            "legendSourceList" = ${LegendSourceList}
            "legendEntriesList" = ${LegendEntriesList}
            "id" = ${Id}
            "title" = ${Title}
            "description" = ${Description}
            "dataSource" = ${DataSource}
            "type" = ${Type}
            "xAxis" = ${XAxis}
            "yAxis" = ${YAxis}
            "enableLegend" = ${EnableLegend}
            "legendSource" = ${LegendSource}
            "legendEntries" = ${LegendEntries}
        }

        return $PSO
    }
}
