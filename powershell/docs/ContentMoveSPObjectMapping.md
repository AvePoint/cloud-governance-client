# ContentMoveSPObjectMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] 
**Destination** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] 
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

