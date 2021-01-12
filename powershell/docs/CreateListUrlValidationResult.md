# CreateListUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentObject** | [**CreateListSPObject**](CreateListSPObject.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListUrlValidationResult = New-Cloud.Governance.ClientCreateListUrlValidationResult  -ParentObject null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$CreateListUrlValidationResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

