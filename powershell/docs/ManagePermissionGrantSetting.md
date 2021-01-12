# ManagePermissionGrantSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableGrantPermission** | **Boolean** |  | [optional] 
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] 
**GrantPermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemporaryPermissionDuration** | **Int32** |  | [optional] 
**TemporaryDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**IsMaxTemporaryDurationSetted** | **Boolean** |  | [optional] 
**TemporaryPermissionMaxDuration** | **Int32** |  | [optional] 
**TemporaryPermissionMaxDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**IsEnableExpireNotify** | **Boolean** |  | [optional] 
**IsAllowSelectAdmin** | **Boolean** |  | [optional] 
**ExpireNotifyDuration** | **Int32** |  | [optional] 
**ExpireNotifyDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**ExpireNotifyEmailTemplate** | **String** |  | [optional] 
**IsEnableWelcomeNotify** | **Boolean** |  | [optional] 
**WelcomeEmailSubject** | **String** |  | [optional] 
**WelcomeEmailBody** | **String** |  | [optional] 
**WelcomeEmailAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AllowSpecifyTemporayPermissionDuration** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagePermissionGrantSetting = New-Cloud.Governance.ClientManagePermissionGrantSetting  -IsEnableGrantPermission null `
 -IsGrantTemporaryPermission null `
 -GrantPermissionAssignBy null `
 -TemporaryPermissionDuration null `
 -TemporaryDurationType null `
 -IsMaxTemporaryDurationSetted null `
 -TemporaryPermissionMaxDuration null `
 -TemporaryPermissionMaxDurationType null `
 -IsEnableExpireNotify null `
 -IsAllowSelectAdmin null `
 -ExpireNotifyDuration null `
 -ExpireNotifyDurationType null `
 -ExpireNotifyEmailTemplate null `
 -IsEnableWelcomeNotify null `
 -WelcomeEmailSubject null `
 -WelcomeEmailBody null `
 -WelcomeEmailAssignBy null `
 -AllowSpecifyTemporayPermissionDuration null
```

- Convert the resource to JSON
```powershell
$ManagePermissionGrantSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

