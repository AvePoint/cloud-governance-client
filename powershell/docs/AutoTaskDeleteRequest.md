# AutoTaskDeleteRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**LifecycleAction**](LifecycleAction.md) |  | [optional] [default to null]
**TaskId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**Comments** | [**CommentsParam**](CommentsParam.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAutoTaskDeleteRequest  -Action null `
 -TaskId null `
 -Metadatas null `
 -Comments null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

