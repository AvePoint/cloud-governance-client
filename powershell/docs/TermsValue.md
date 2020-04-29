# TermsValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermStore** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] [default to null]
**TermGroup** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] [default to null]
**TermSet** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] [default to null]
**Value** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTermsValue  -TermStore null `
 -TermGroup null `
 -TermSet null `
 -Value null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

