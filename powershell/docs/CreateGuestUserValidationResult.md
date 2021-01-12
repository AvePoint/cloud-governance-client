# CreateGuestUserValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupName** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGuestUserValidationResult = New-Cloud.Governance.ClientCreateGuestUserValidationResult  -GroupName null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$CreateGuestUserValidationResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

