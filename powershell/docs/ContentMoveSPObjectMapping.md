# ContentMoveSPObjectMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ContentMoveSPObjectMappingSource**](ContentMoveSPObjectMappingSource.md) |  | [optional] 
**Destination** | [**ContentMoveSPObjectMappingSource**](ContentMoveSPObjectMappingSource.md) |  | [optional] 
**Action** | [**ContentMoveAction**](ContentMoveAction.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveSPObjectMapping = New-Cloud.Governance.ClientContentMoveSPObjectMapping  -Source null `
 -Destination null `
 -Action null
```

- Convert the resource to JSON
```powershell
$ContentMoveSPObjectMapping | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

