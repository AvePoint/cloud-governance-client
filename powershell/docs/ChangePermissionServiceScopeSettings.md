# ChangePermissionServiceScopeSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | [**SPNode[]**](SPNode.md) |  | [optional] 
**AutoPopulateUrlWithSPContext** | **Boolean** |  | [optional] [default to $false]
**AutoPopulateUrlWithSPContextAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePermissionServiceScopeSettings = New-Cloud.Governance.ClientChangePermissionServiceScopeSettings  -SelectedNodes null `
 -AutoPopulateUrlWithSPContext null `
 -AutoPopulateUrlWithSPContextAssignBy null
```

- Convert the resource to JSON
```powershell
$ChangePermissionServiceScopeSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

