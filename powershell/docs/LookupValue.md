# LookupValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenant** | **String** | Id of Office365 tenant. | [optional] [readonly] 
**Property** | **String** | Name of user property. | [optional] [readonly] 
**TargetUser** | [**ApiUser**](ApiUser.md) | Lookup user | [optional] 
**UserPropertyValue** | **String** | Property value of lookup user | [optional] 
**UserPropertyDisplayValue** | **String** | Property display value of lookup user | [optional] 

## Examples

- Prepare the resource
```powershell
$LookupValue = New-Cloud.Governance.ClientLookupValue  -Tenant null `
 -Property null `
 -TargetUser null `
 -UserPropertyValue null `
 -UserPropertyDisplayValue null
```

- Convert the resource to JSON
```powershell
$LookupValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

