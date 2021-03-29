# MultiGeoSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**ControlMode** | [**MultiGeoControlMode**](MultiGeoControlMode.md) |  | [optional] 
**DefaultLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] 
**SelectedLocations** | [**GeoLocationBase[]**](GeoLocationBase.md) |  | [optional] 
**LocationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**UserRoleForLocation** | **String** |  | [optional] 
**AllLocations** | [**GeoLocationBase[]**](GeoLocationBase.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MultiGeoSetting = New-Cloud.Governance.ClientMultiGeoSetting  -IsEnabled null `
 -ControlMode null `
 -DefaultLocation null `
 -SelectedLocations null `
 -LocationAssignBy null `
 -UserRoleForLocation null `
 -AllLocations null
```

- Convert the resource to JSON
```powershell
$MultiGeoSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

