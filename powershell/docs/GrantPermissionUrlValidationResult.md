# GrantPermissionUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] [default to null]
**EnableShareAnnoymousLink** | **Boolean** |  | [optional] [default to null]
**Object** | [**GrantPermissionSPObject**](GrantPermissionSPObject.md) |  | [optional] [default to null]
**SpPermissionLevels** | [**IntModel[]**](IntModel.md) |  | [optional] [default to null]
**SpGroups** | [**GrantPermissionGroup[]**](GrantPermissionGroup.md) |  | [optional] [default to null]
**AllowBreakPermissionInheritance** | **Boolean** |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionUrlValidationResult  -ExternalSharingOptions null `
 -EnableShareAnnoymousLink null `
 -Object null `
 -SpPermissionLevels null `
 -SpGroups null `
 -AllowBreakPermissionInheritance null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

