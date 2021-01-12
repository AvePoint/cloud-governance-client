# ServiceListPageResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**ServiceList[]**](ServiceList.md) |  | [optional] 
**NextLink** | **String** |  | [optional] 
**NextToken** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceListPageResult = New-Cloud.Governance.ClientServiceListPageResult  -Value null `
 -NextLink null `
 -NextToken null
```

- Convert the resource to JSON
```powershell
$ServiceListPageResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

