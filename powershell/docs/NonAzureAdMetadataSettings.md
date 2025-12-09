# NonAzureAdMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365Tenant** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**PropertyFriendlyName** | **String** |  | [optional] 
**Value** | [**LookupValue**](LookupValue.md) | Value of Lookup to SharePoint library/list metadata. | [optional] 
**Property** | **String** |  | [optional] 
**ExtensionAttribute** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$NonAzureAdMetadataSettings = New-Cloud.Governance.ClientNonAzureAdMetadataSettings  -Office365Tenant null `
 -PropertyFriendlyName null `
 -Value null `
 -Property null `
 -ExtensionAttribute null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$NonAzureAdMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

