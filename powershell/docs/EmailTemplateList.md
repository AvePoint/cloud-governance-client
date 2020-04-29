# EmailTemplateList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**TemplateType** | [**EmailTemplateType**](EmailTemplateType.md) |  | [optional] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientEmailTemplateList  -Id null `
 -Name null `
 -Description null `
 -TemplateType null `
 -TypeDescription null `
 -ModifiedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

