# TermsValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermStore** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] [readonly] 
**TermGroup** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] [readonly] 
**TermSet** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] [readonly] 
**Value** | [**GuidModel[]**](GuidModel.md) | Id and name collection of terms. | [optional] 

## Examples

- Prepare the resource
```powershell
$TermsValue = New-Cloud.Governance.ClientTermsValue  -TermStore null `
 -TermGroup null `
 -TermSet null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TermsValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

