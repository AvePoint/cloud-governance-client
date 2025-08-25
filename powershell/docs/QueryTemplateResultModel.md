# QueryTemplateResultModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateTitle** | **String** |  | [optional] 
**TemplateName** | **String** |  | [optional] 
**TemplateId** | **String** |  | [optional] 
**HasDraft** | **Boolean** |  | [optional] [default to $false]
**Status** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$QueryTemplateResultModel = New-Cloud.Governance.ClientQueryTemplateResultModel  -TemplateTitle null `
 -TemplateName null `
 -TemplateId null `
 -HasDraft null `
 -Status null
```

- Convert the resource to JSON
```powershell
$QueryTemplateResultModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

