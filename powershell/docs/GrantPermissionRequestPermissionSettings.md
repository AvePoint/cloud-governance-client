# GrantPermissionRequestPermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBreakInheritance** | **Boolean** |  | [optional] [default to null]
**IsGrantPermissionDirectly** | **Boolean** |  | [optional] [default to null]
**SelectedSPGroup** | [**GrantPermissionGroup**](GrantPermissionGroup.md) |  | [optional] [default to null]
**SelectedPermissionLevels** | [**IntModel[]**](IntModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionRequestPermissionSettings  -IsBreakInheritance null `
 -IsGrantPermissionDirectly null `
 -SelectedSPGroup null `
 -SelectedPermissionLevels null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

