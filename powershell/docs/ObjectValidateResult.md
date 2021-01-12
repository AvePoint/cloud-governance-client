# ObjectValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ObjectValidateResult = New-Cloud.Governance.ClientObjectValidateResult  -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ObjectValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

