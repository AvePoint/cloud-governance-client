# DepartmentSettingsModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSource** | [**DepartmentSource**](DepartmentSource.md) |  | [optional] [default to null]
**Departments** | [**DepartmentActionModel[]**](DepartmentActionModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDepartmentSettingsModel  -DataSource null `
 -Departments null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

