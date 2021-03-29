# UserProfileMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminCenter** | **String** |  | [optional] 
**ValueType** | **String** |  | [optional] 
**EnableValueSync** | **Boolean** |  | [optional] [default to $false]
**EnableRoleValueSync** | **Boolean** |  | [optional] [default to $false]
**Value** | [**LookupValue**](LookupValue.md) | Value of Lookup to SharePoint library/list metadata. | [optional] 
**Property** | **String** |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

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

