# LocalizedMetadataTermsAndConditionsModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Term** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**IsEnableCustomValue** | **Boolean** |  | [optional] [default to $false]
**TrueValue** | **String** |  | [optional] 
**FalseValue** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LocalizedMetadataTermsAndConditionsModel = New-Cloud.Governance.ClientLocalizedMetadataTermsAndConditionsModel  -Term null `
 -LanguageId null `
 -IsEnabled null `
 -IsEnableCustomValue null `
 -TrueValue null `
 -FalseValue null
```

- Convert the resource to JSON
```powershell
$LocalizedMetadataTermsAndConditionsModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

