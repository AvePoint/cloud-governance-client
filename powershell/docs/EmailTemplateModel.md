# EmailTemplateModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**EmailTemplateType**](EmailTemplateType.md) |  | [optional] [default to null]
**DefaultLanguage** | **Int32** |  | [optional] [default to null]
**Contents** | [**EmailTemplateContent[]**](EmailTemplateContent.md) |  | [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientEmailTemplateModel  -Id null `
 -Name null `
 -Description null `
 -Type null `
 -DefaultLanguage null `
 -Contents null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

