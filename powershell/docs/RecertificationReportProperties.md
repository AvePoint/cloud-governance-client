# RecertificationReportProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectName** | **String** |  | [optional] [default to null]
**IsAllowedReassign** | **Boolean** |  | [optional] [default to null]
**ReportGeneratedTime** | **System.DateTime** |  | [optional] [default to null]
**RequestSummary** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRecertificationReportProperties  -ObjectId null `
 -ObjectName null `
 -IsAllowedReassign null `
 -ReportGeneratedTime null `
 -RequestSummary null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

