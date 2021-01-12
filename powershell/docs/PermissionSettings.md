# PermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGrantUserPermission** | **Boolean** |  | [optional] 
**PreventGrantSpecificPermissionLevels** | **Boolean** |  | [optional] 
**PreventPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PermissionSettings = New-Cloud.Governance.ClientPermissionSettings  -AllowGrantUserPermission null `
 -PreventGrantSpecificPermissionLevels null `
 -PreventPermissionLevles null
```

- Convert the resource to JSON
```powershell
$PermissionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

