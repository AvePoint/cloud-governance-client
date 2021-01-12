# UserProfileMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminCenter** | **String** |  | [optional] 
**ValueType** | **String** |  | [optional] 
**EnableValueSync** | **Boolean** |  | [optional] 
**EnableRoleValueSync** | **Boolean** |  | [optional] 
**Value** | [**LookupValue**](LookupValue.md) |  | [optional] 
**Property** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UserProfileMetadataSettings = New-Cloud.Governance.ClientUserProfileMetadataSettings  -AdminCenter null `
 -ValueType null `
 -EnableValueSync null `
 -EnableRoleValueSync null `
 -Value null `
 -Property null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$UserProfileMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

