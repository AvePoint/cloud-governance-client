# TermTreeModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**Child** | [**TermTreeModel**](TermTreeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TermTreeModel = New-Cloud.Governance.ClientTermTreeModel  -Name null `
 -Id null `
 -Child null
```

- Convert the resource to JSON
```powershell
$TermTreeModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

