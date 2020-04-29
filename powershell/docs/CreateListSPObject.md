# CreateListSPObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentUrl** | **String** |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateListSPObject  -ParentUrl null `
 -SiteUrl null `
 -SiteId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

