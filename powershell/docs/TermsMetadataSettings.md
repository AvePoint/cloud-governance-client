# TermsMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMultiple** | **Boolean** |  | [optional] [default to $false]
**AdminCenter** | **String** |  | [optional] 
**Value** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**TermStore** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**TermGroup** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**TermSet** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**Scope** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**Tree** | [**TermTreeModel**](TermTreeModel.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$TermsMetadataSettings = New-Cloud.Governance.ClientTermsMetadataSettings  -AllowMultiple null `
 -AdminCenter null `
 -Value null `
 -TermStore null `
 -TermGroup null `
 -TermSet null `
 -Scope null `
 -Tree null `
 -IsValid null
```

- Convert the resource to JSON
```powershell
$TermsMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

