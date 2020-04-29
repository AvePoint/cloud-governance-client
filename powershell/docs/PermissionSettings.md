# PermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGrantUserPermission** | **Boolean** |  | [optional] [default to null]
**PreventGrantSpecificPermissionLevels** | **Boolean** |  | [optional] [default to null]
**PreventPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPermissionSettings  -AllowGrantUserPermission null `
 -PreventGrantSpecificPermissionLevels null `
 -PreventPermissionLevles null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

