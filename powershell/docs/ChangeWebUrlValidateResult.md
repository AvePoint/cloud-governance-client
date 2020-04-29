# ChangeWebUrlValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | [**ChangeWebSPObject**](ChangeWebSPObject.md) |  | [optional] [default to null]
**WebTitle** | **String** |  | [optional] [default to null]
**WebDescription** | **String** |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeWebUrlValidateResult  -Url null `
 -WebTitle null `
 -WebDescription null `
 -Metadatas null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

