# ManagePermissionGrantSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableGrantPermission** | **Boolean** |  | [optional] [default to null]
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to null]
**GrantPermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**TemporaryPermissionDuration** | **Int32** |  | [optional] [default to null]
**TemporaryDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**IsMaxTemporaryDurationSetted** | **Boolean** |  | [optional] [default to null]
**TemporaryPermissionMaxDuration** | **Int32** |  | [optional] [default to null]
**TemporaryPermissionMaxDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**IsEnableExpireNotify** | **Boolean** |  | [optional] [default to null]
**ExpireNotifyDuration** | **Int32** |  | [optional] [default to null]
**ExpireNotifyDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**ExpireNotifyEmailTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsEnableWelcomeNotify** | **Boolean** |  | [optional] [default to null]
**WelcomeEmailSubject** | **String** |  | [optional] [default to null]
**WelcomeEmailBody** | **String** |  | [optional] [default to null]
**WelcomeEmailAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**AllowSpecifyTemporayPermissionDuration** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientManagePermissionGrantSetting  -IsEnableGrantPermission null `
 -IsGrantTemporaryPermission null `
 -GrantPermissionAssignBy null `
 -TemporaryPermissionDuration null `
 -TemporaryDurationType null `
 -IsMaxTemporaryDurationSetted null `
 -TemporaryPermissionMaxDuration null `
 -TemporaryPermissionMaxDurationType null `
 -IsEnableExpireNotify null `
 -ExpireNotifyDuration null `
 -ExpireNotifyDurationType null `
 -ExpireNotifyEmailTemplate null `
 -IsEnableWelcomeNotify null `
 -WelcomeEmailSubject null `
 -WelcomeEmailBody null `
 -WelcomeEmailAssignBy null `
 -AllowSpecifyTemporayPermissionDuration null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

