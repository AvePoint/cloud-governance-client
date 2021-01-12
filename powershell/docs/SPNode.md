# SPNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**FullUrl** | **String** |  | [optional] 
**Type** | [**NodeType**](NodeType.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**IsSelected** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPNode = New-Cloud.Governance.ClientSPNode  -Id null `
 -FullUrl null `
 -Type null `
 -Name null `
 -Title null `
 -IsSelected null
```

- Convert the resource to JSON
```powershell
$SPNode | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

