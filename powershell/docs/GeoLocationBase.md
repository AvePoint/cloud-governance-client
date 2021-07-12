# GeoLocationBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Geo location name | [optional] 
**DisplayName** | **String** | Geo location display name | [optional] 

## Examples

- Prepare the resource
```powershell
$GeoLocationBase = New-Cloud.Governance.ClientGeoLocationBase  -Name null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$GeoLocationBase | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

