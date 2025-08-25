# CustomMetadataAzureAdMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365Tenant** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**UseBuiltInProperty** | **Boolean** |  | [optional] [default to $false]
**Value** | [**AzureAdMetadataSettingsValue**](AzureAdMetadataSettingsValue.md) |  | [optional] 
**Property** | **String** |  | [optional] 
**ExtensionAttribute** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CustomMetadataAzureAdMetadataSettings = New-Cloud.Governance.ClientCustomMetadataAzureAdMetadataSettings  -Office365Tenant null `
 -UseBuiltInProperty null `
 -Value null `
 -Property null `
 -ExtensionAttribute null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$CustomMetadataAzureAdMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

