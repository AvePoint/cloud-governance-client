# WorkspaceGridModelPageResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**WorkspaceGridModel[]**](WorkspaceGridModel.md) |  | [optional] 
**NextLink** | **String** |  | [optional] 
**NextToken** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceGridModelPageResult = New-Cloud.Governance.ClientWorkspaceGridModelPageResult  -Value null `
 -NextLink null `
 -NextToken null
```

- Convert the resource to JSON
```powershell
$WorkspaceGridModelPageResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

