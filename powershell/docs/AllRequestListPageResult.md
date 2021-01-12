# AllRequestListPageResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**AllRequestList[]**](AllRequestList.md) |  | [optional] 
**NextLink** | **String** |  | [optional] 
**NextToken** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AllRequestListPageResult = New-Cloud.Governance.ClientAllRequestListPageResult  -Value null `
 -NextLink null `
 -NextToken null
```

- Convert the resource to JSON
```powershell
$AllRequestListPageResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

