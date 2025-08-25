# CreateListServicePermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGrantUserPermission** | **Boolean** |  | [optional] [default to $false]
**PreventGrantSpecificPermissionLevels** | **Boolean** |  | [optional] [default to $false]
**PreventPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 
**PreventPermissionLevels** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListServicePermissionSettings = New-Cloud.Governance.ClientCreateListServicePermissionSettings  -AllowGrantUserPermission null `
 -PreventGrantSpecificPermissionLevels null `
 -PreventPermissionLevles null `
 -PreventPermissionLevels null
```

- Convert the resource to JSON
```powershell
$CreateListServicePermissionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

