# DRPermissionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$DRPermissionSetting = New-Cloud.Governance.ClientDRPermissionSetting  -UserPermissions null `
 -GroupPermissions null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$DRPermissionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

