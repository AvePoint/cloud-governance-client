# ServiceGridModelPageResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**ServiceGridModel[]**](ServiceGridModel.md) |  | [optional] 
**NextLink** | **String** |  | [optional] 
**NextToken** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceGridModelPageResult = New-Cloud.Governance.ClientServiceGridModelPageResult  -Value null `
 -NextLink null `
 -NextToken null
```

- Convert the resource to JSON
```powershell
$ServiceGridModelPageResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

