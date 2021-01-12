# GrantPermissionRequestPermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBreakInheritance** | **Boolean** |  | [optional] 
**IsGrantPermissionDirectly** | **Boolean** |  | [optional] 
**SelectedSPGroup** | [**GrantPermissionGroup**](GrantPermissionGroup.md) |  | [optional] 
**SelectedPermissionLevels** | [**IntModel[]**](IntModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionRequestPermissionSettings = New-Cloud.Governance.ClientGrantPermissionRequestPermissionSettings  -IsBreakInheritance null `
 -IsGrantPermissionDirectly null `
 -SelectedSPGroup null `
 -SelectedPermissionLevels null
```

- Convert the resource to JSON
```powershell
$GrantPermissionRequestPermissionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

