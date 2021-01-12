# DpmServiceSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] 
**DefaultValue** | **String** |  | [optional] 
**SelectedItems** | **String[]** |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DpmServiceSetting = New-Cloud.Governance.ClientDpmServiceSetting  -IsEnabled null `
 -DefaultValue null `
 -SelectedItems null `
 -AssignBy null
```

- Convert the resource to JSON
```powershell
$DpmServiceSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

