# QuestionnaireNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectIds** | [**UUID[]**](UUID.md) |  | [optional] [default to null]
**Type** | [**QuestionnaireNodeType**](QuestionnaireNodeType.md) |  | [optional] [default to null]
**Joints** | [**JointNode[]**](JointNode.md) |  | [optional] [default to null]
**Msg** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestionnaireNode  -ObjectIds null `
 -Type null `
 -Joints null `
 -Msg null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

