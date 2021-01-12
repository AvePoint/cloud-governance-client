# AzureAdMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365Tenant** | [**GuidModel**](GuidModel.md) |  | [optional] 
**UseBuiltInProperty** | **Boolean** |  | [optional] 
**Value** | [**LookupValue**](LookupValue.md) |  | [optional] 
**Property** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AzureAdMetadataSettings = New-Cloud.Governance.ClientAzureAdMetadataSettings  -Office365Tenant null `
 -UseBuiltInProperty null `
 -Value null `
 -Property null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$AzureAdMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

