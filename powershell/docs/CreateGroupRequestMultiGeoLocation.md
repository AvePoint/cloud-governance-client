# CreateGroupRequestMultiGeoLocation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Geo location name | [optional] 
**DisplayName** | **String** | Geo location display name | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGroupRequestMultiGeoLocation = New-Cloud.Governance.ClientCreateGroupRequestMultiGeoLocation  -Name null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$CreateGroupRequestMultiGeoLocation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

