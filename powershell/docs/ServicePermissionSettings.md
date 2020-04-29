# ServicePermissionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAnyUserAccess** | **Boolean** |  | [optional] [default to null]
**MeetAllConditions** | **Boolean** |  | [optional] [default to null]
**PermissionSettings** | [**ServicePermissionItem[]**](ServicePermissionItem.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientServicePermissionSettings  -AllowAnyUserAccess null `
 -MeetAllConditions null `
 -PermissionSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

