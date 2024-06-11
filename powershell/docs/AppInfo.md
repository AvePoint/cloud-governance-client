# AppInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseId** | **String** |  | [optional] 
**PlanId** | **String** |  | [optional] 
**PlanName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AppInfo = New-Cloud.Governance.ClientAppInfo  -LicenseId null `
 -PlanId null `
 -PlanName null
```

- Convert the resource to JSON
```powershell
$AppInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

