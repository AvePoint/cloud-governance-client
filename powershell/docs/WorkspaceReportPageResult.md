# WorkspaceReportPageResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**WorkspaceReport[]**](WorkspaceReport.md) |  | [optional] 
**NextLink** | **String** |  | [optional] 
**NextToken** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceReportPageResult = New-Cloud.Governance.ClientWorkspaceReportPageResult  -Value null `
 -NextLink null `
 -NextToken null
```

- Convert the resource to JSON
```powershell
$WorkspaceReportPageResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

