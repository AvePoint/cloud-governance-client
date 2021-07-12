# GeoLocationModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RootSiteUrl** | **String** |  | [optional] 
**TenantAdminUrl** | **String** |  | [optional] 
**Name** | **String** | Geo location name | [optional] 
**DisplayName** | **String** | Geo location display name | [optional] 

## Examples

- Prepare the resource
```powershell
$GeoLocationModel = New-Cloud.Governance.ClientGeoLocationModel  -RootSiteUrl null `
 -TenantAdminUrl null `
 -Name null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$GeoLocationModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

