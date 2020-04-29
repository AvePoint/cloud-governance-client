# GrantPermissionServiceDurationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to null]
**DefaultDurationInterval** | **Int32** |  | [optional] [default to null]
**DefaultDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] [default to null]
**IsEnableMaxDuration** | **Boolean** |  | [optional] [default to null]
**MaxDuration** | **Int32** |  | [optional] [default to null]
**MaxDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] [default to null]
**IsEnableExpirationNotify** | **Boolean** |  | [optional] [default to null]
**ExpirationNotifyDurationInterval** | **Int32** |  | [optional] [default to null]
**ExpirationNotifyDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] [default to null]
**IsOnlyUseDefaultDuration** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionServiceDurationSettings  -AssignBy null `
 -IsGrantTemporaryPermission null `
 -DefaultDurationInterval null `
 -DefaultDurationType null `
 -IsEnableMaxDuration null `
 -MaxDuration null `
 -MaxDurationType null `
 -IsEnableExpirationNotify null `
 -ExpirationNotifyDurationInterval null `
 -ExpirationNotifyDurationType null `
 -IsOnlyUseDefaultDuration null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

