# GrantPermissionServiceUserLevelControlSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserLevelControlMode** | [**UserLevelControlMode**](UserLevelControlMode.md) |  | [optional] 
**IsSetRequesterAsDefaultEnabled** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$GrantPermissionServiceUserLevelControlSettings = New-Cloud.Governance.ClientGrantPermissionServiceUserLevelControlSettings  -UserLevelControlMode null `
 -IsSetRequesterAsDefaultEnabled null
```

- Convert the resource to JSON
```powershell
$GrantPermissionServiceUserLevelControlSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

