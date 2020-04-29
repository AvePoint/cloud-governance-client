# MultiGeoSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**ControlMode** | [**MultiGeoControlMode**](MultiGeoControlMode.md) |  | [optional] [default to null]
**DefaultLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] [default to null]
**SelectedLocations** | [**GeoLocationBase[]**](GeoLocationBase.md) |  | [optional] [default to null]
**LocationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**UserRoleForLocation** | **String** |  | [optional] [default to null]
**AllLocations** | [**GeoLocationBase[]**](GeoLocationBase.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientMultiGeoSetting  -IsEnabled null `
 -ControlMode null `
 -DefaultLocation null `
 -SelectedLocations null `
 -LocationAssignBy null `
 -UserRoleForLocation null `
 -AllLocations null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

