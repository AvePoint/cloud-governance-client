# ServiceScopeSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**SPNode[]**](SPNode.md) |  | [optional] 
**AutoPopulateUrlWithSPContext** | **Boolean** |  | [optional] 
**AutoPopulateUrlWithSPContextAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceScopeSettings = New-Cloud.Governance.ClientServiceScopeSettings  -SelectedNodes null `
 -AutoPopulateUrlWithSPContext null `
 -AutoPopulateUrlWithSPContextAssignBy null
```

- Convert the resource to JSON
```powershell
$ServiceScopeSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

