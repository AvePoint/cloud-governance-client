# GrantPermissionModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionDurationSettings** | [**TemporaryPermissionRequestSetting**](TemporaryPermissionRequestSetting.md) |  | [optional] 
**WelcomeEmailSettings** | [**WelcomeEmailSettings**](WelcomeEmailSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionModel = New-Cloud.Governance.ClientGrantPermissionModel  -PermissionDurationSettings null `
 -WelcomeEmailSettings null
```

- Convert the resource to JSON
```powershell
$GrantPermissionModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

