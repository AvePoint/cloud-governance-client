# ContentMoveSPObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**FullUrl** | **String** |  | [optional] [default to null]
**Type** | [**NodeType**](NodeType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveSPObject  -SiteId null `
 -SiteUrl null `
 -Id null `
 -Title null `
 -FullUrl null `
 -Type null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

