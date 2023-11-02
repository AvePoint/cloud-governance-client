# PnpTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateListTitle** | **String** |  | [optional] 
**TemplateLibraryUrl** | **String** |  | [optional] 
**TemplateWebUrl** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$PnpTemplate = New-Cloud.Governance.ClientPnpTemplate  -TemplateListTitle null `
 -TemplateLibraryUrl null `
 -TemplateWebUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$PnpTemplate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

