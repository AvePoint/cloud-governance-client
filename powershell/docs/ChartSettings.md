# ChartSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**XAxisList** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]
**YAxisList** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]
**LegendSourceList** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]
**LegendEntriesList** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**DataSource** | [**ReportDataSource**](ReportDataSource.md) |  | [optional] [default to null]
**Type** | [**ChartType**](ChartType.md) |  | [optional] [default to null]
**XAxis** | **String** |  | [optional] [default to null]
**YAxis** | **String** |  | [optional] [default to null]
**EnableLegend** | **Boolean** |  | [optional] [default to null]
**LegendSource** | **String** |  | [optional] [default to null]
**LegendEntries** | **String[]** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChartSettings  -XAxisList null `
 -YAxisList null `
 -LegendSourceList null `
 -LegendEntriesList null `
 -Id null `
 -Title null `
 -Description null `
 -DataSource null `
 -Type null `
 -XAxis null `
 -YAxis null `
 -EnableLegend null `
 -LegendSource null `
 -LegendEntries null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

