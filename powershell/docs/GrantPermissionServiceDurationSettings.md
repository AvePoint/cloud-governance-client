# GrantPermissionServiceDurationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] 
**DefaultDurationInterval** | **Int32** |  | [optional] 
**DefaultDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] 
**IsEnableMaxDuration** | **Boolean** |  | [optional] 
**MaxDuration** | **Int32** |  | [optional] 
**MaxDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] 
**IsEnableExpirationNotify** | **Boolean** |  | [optional] 
**ExpirationNotifyDurationInterval** | **Int32** |  | [optional] 
**ExpirationNotifyDurationType** | [**DurationDateType**](DurationDateType.md) |  | [optional] 
**IsOnlyUseDefaultDuration** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionServiceDurationSettings = New-Cloud.Governance.ClientGrantPermissionServiceDurationSettings  -AssignBy null `
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

- Convert the resource to JSON
```powershell
$GrantPermissionServiceDurationSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

