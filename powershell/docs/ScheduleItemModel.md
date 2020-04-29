# ScheduleItemModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Days** | [**DayOfWeek[]**](DayOfWeek.md) |  | [optional] [default to null]
**BeginHours** | **Int32** |  | [optional] [default to null]
**EndHours** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientScheduleItemModel  -Days null `
 -BeginHours null `
 -EndHours null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

