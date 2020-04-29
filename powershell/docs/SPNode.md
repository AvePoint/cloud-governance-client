# SPNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**FullUrl** | **String** |  | [optional] [default to null]
**Type** | [**NodeType**](NodeType.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**IsSelected** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPNode  -Id null `
 -FullUrl null `
 -Type null `
 -Name null `
 -Title null `
 -IsSelected null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

