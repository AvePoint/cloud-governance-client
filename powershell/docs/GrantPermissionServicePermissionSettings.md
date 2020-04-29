# GrantPermissionServicePermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**IsGrantPermissionDirectly** | **Boolean** |  | [optional] [default to null]
**EnableExcludePermissionLevles** | **Boolean** |  | [optional] [default to null]
**ExcludedPermissionLevles** | [**PermissionLevel[]**](PermissionLevel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionServicePermissionSettings  -AssignBy null `
 -IsGrantPermissionDirectly null `
 -EnableExcludePermissionLevles null `
 -ExcludedPermissionLevles null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

