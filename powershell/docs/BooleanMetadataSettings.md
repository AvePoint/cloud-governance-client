# BooleanMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableTerms** | **Boolean** |  | [optional] [default to $false]
**Value** | **Boolean** |  | [optional] [default to $false]
**TermsAndConditions** | **String** |  | [optional] 
**TrueDisplayValue** | **String** |  | [optional] 
**FalseDisplayValue** | **String** |  | [optional] 
**TermsAndConditionsContent** | [**LocalizedMetadataTermsAndConditionsModel[]**](LocalizedMetadataTermsAndConditionsModel.md) |  | [optional] 
**DefaultTermLanguageId** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$BooleanMetadataSettings = New-Cloud.Governance.ClientBooleanMetadataSettings  -EnableTerms null `
 -Value null `
 -TermsAndConditions null `
 -TrueDisplayValue null `
 -FalseDisplayValue null `
 -TermsAndConditionsContent null `
 -DefaultTermLanguageId null
```

- Convert the resource to JSON
```powershell
$BooleanMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

