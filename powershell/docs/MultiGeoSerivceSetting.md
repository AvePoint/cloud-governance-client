# MultiGeoSerivceSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMultiGeoTenant** | **Boolean** |  | [optional] 
**AllLocations** | [**GeoLocationModel[]**](GeoLocationModel.md) |  | [optional] 
**IsEnabled** | **Boolean** |  | [optional] 
**ControlMode** | [**MultiGeoControlMode**](MultiGeoControlMode.md) |  | [optional] 
**DefaultLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] 
**SelectedLocations** | [**GeoLocationBase[]**](GeoLocationBase.md) |  | [optional] 
**LocationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**UserRoleForLocation** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MultiGeoSerivceSetting = New-Cloud.Governance.ClientMultiGeoSerivceSetting  -IsMultiGeoTenant null `
 -AllLocations null `
 -IsEnabled null `
 -ControlMode null `
 -DefaultLocation null `
 -SelectedLocations null `
 -LocationAssignBy null `
 -UserRoleForLocation null
```

- Convert the resource to JSON
```powershell
$MultiGeoSerivceSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

