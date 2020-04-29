# ContentMoveSPObjectMapping
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] [default to null]
**Destination** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] [default to null]
**Action** | [**ContentMoveAction**](ContentMoveAction.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveSPObjectMapping  -Source null `
 -Destination null `
 -Action null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

