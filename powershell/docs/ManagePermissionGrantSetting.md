# ManagePermissionGrantSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableGrantPermission** | **Boolean** |  | [optional] [default to $false]
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to $false]
**GrantPermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemporaryPermissionDuration** | **Int32** |  | [optional] [default to 0]
**TemporaryDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**IsMaxTemporaryDurationSetted** | **Boolean** |  | [optional] [default to $false]
**TemporaryPermissionMaxDuration** | **Int32** |  | [optional] [default to 0]
**TemporaryPermissionMaxDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**IsEnableExpireNotify** | **Boolean** |  | [optional] [default to $false]
**IsAllowSelectAdmin** | **Boolean** |  | [optional] [default to $false]
**ExpireNotifyDuration** | **Int32** |  | [optional] [default to 0]
**ExpireNotifyDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**ExpireNotifyEmailTemplate** | **String** |  | [optional] 
**IsEnableWelcomeNotify** | **Boolean** |  | [optional] [default to $false]
**WelcomeEmailSubject** | **String** |  | [optional] 
**WelcomeEmailBody** | **String** |  | [optional] 
**WelcomeEmailAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AllowSpecifyTemporayPermissionDuration** | **Boolean** |  | [optional] [default to $false]

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

