# TermsMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultiple** | **Boolean** |  | [optional] [default to null]
**AdminCenter** | **String** |  | [optional] [default to null]
**Value** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**TermStore** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**TermGroup** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**TermSet** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**Scope** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTermsMetadataSettings  -AllowMultiple null `
 -AdminCenter null `
 -Value null `
 -TermStore null `
 -TermGroup null `
 -TermSet null `
 -Scope null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

