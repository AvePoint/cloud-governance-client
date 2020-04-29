# ExecutionScheduleModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [default to null]
**Description** | **String** |  | [optional] [default to null]
**Schedules** | [**ScheduleItemModel[]**](ScheduleItemModel.md) |  | [default to null]
**TimeZone** | **Double** |  | [optional] [default to null]
**IsAdjustDaylight** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientExecutionScheduleModel  -Id null `
 -Name null `
 -Description null `
 -Schedules null `
 -TimeZone null `
 -IsAdjustDaylight null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

