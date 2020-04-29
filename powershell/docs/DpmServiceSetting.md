# DpmServiceSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**DefaultValue** | **String** |  | [optional] [default to null]
**SelectedItems** | **String[]** |  | [optional] [default to null]
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDpmServiceSetting  -IsEnabled null `
 -DefaultValue null `
 -SelectedItems null `
 -AssignBy null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

