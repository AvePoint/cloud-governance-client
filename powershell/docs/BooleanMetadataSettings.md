# BooleanMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableTerms** | **Boolean** |  | [optional] [default to $false]
**Value** | **Boolean** |  | [optional] [default to $false]
**TermsAndConditions** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BooleanMetadataSettings = New-Cloud.Governance.ClientBooleanMetadataSettings  -EnableTerms null `
 -Value null `
 -TermsAndConditions null
```

- Convert the resource to JSON
```powershell
$BooleanMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

