# CustomMetadataUserProfileMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminCenter** | **String** |  | [optional] 
**ValueType** | **String** |  | [optional] 
**EnableValueSync** | **Boolean** |  | [optional] [default to $false]
**EnableRoleValueSync** | **Boolean** |  | [optional] [default to $false]
**Value** | [**AzureAdMetadataSettingsValue**](AzureAdMetadataSettingsValue.md) |  | [optional] 
**Property** | **String** |  | [optional] 
**ExtensionAttribute** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CustomMetadataUserProfileMetadataSettings = New-Cloud.Governance.ClientCustomMetadataUserProfileMetadataSettings  -AdminCenter null `
 -ValueType null `
 -EnableValueSync null `
 -EnableRoleValueSync null `
 -Value null `
 -Property null `
 -ExtensionAttribute null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$CustomMetadataUserProfileMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

