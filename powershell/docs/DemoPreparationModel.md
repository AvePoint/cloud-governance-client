# DemoPreparationModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | [**TaskDurationModel**](TaskDurationModel.md) |  | [optional] [default to null]
**SiteJobs** | [**SiteJobTriggers**](SiteJobTriggers.md) |  | [optional] [default to null]
**GroupJobs** | [**GroupJobTriggers**](GroupJobTriggers.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDemoPreparationModel  -Duration null `
 -SiteJobs null `
 -GroupJobs null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

