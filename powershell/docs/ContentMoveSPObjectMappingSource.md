# ContentMoveSPObjectMappingSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**FullUrl** | **String** |  | [optional] 
**Type** | [**NodeType**](NodeType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveSPObjectMappingSource = New-Cloud.Governance.ClientContentMoveSPObjectMappingSource  -SiteId null `
 -SiteUrl null `
 -Id null `
 -Title null `
 -FullUrl null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ContentMoveSPObjectMappingSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

