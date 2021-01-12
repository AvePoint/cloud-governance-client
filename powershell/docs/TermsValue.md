# TermsValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermStore** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] 
**TermGroup** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] 
**TermSet** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] 
**Value** | [**GuidModel[]**](GuidModel.md) |  | [optional] 

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

