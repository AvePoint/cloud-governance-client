# TerminologyList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LanguageId** | **Int32** |  | [optional] [default to null]
**OriginalTerminology** | **String** |  | [optional] [default to null]
**NewTerminology** | **String** |  | [optional] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTerminologyList  -Id null `
 -LanguageId null `
 -OriginalTerminology null `
 -NewTerminology null `
 -ModifiedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

