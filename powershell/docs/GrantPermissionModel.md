# GrantPermissionModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionDurationSettings** | [**TemporaryPermissionRequestSetting**](TemporaryPermissionRequestSetting.md) |  | [optional] [default to null]
**WelcomeEmailSettings** | [**WelcomeEmailSettings**](WelcomeEmailSettings.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionModel  -PermissionDurationSettings null `
 -WelcomeEmailSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

