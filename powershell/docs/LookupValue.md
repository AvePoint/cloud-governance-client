# LookupValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenant** | **String** |  | [optional] [readonly] 
**Property** | **String** |  | [optional] [readonly] 
**TargetUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**UserPropertyValue** | **String** |  | [optional] 
**UserPropertyDisplayValue** | **String** |  | [optional] 

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

