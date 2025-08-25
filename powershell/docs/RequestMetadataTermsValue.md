# RequestMetadataTermsValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermStore** | [**TermsValueTermStore**](TermsValueTermStore.md) |  | [optional] 
**TermGroup** | [**TermsValueTermGroup**](TermsValueTermGroup.md) |  | [optional] 
**TermSet** | [**TermsValueTermSet**](TermsValueTermSet.md) |  | [optional] 
**Value** | [**GuidModel[]**](GuidModel.md) | Id and name collection of terms. | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestMetadataTermsValue = New-Cloud.Governance.ClientRequestMetadataTermsValue  -TermStore null `
 -TermGroup null `
 -TermSet null `
 -Value null
```

- Convert the resource to JSON
```powershell
$RequestMetadataTermsValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

