# GroupStatusScanJobTrigger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobType** | [**StatusScanDemoJobType**](StatusScanDemoJobType.md) |  | [optional] [default to null]
**GroupNameOrId** | **String** |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupStatusScanJobTrigger  -JobType null `
 -GroupNameOrId null `
 -IsEnabled null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

