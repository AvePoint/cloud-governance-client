# UserProfileMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminCenter** | **String** |  | [optional] [default to null]
**EnableValueSync** | **Boolean** |  | [optional] [default to null]
**EnableRoleValueSync** | **Boolean** |  | [optional] [default to null]
**Value** | [**LookupValue**](LookupValue.md) |  | [optional] [default to null]
**Property** | **String** |  | [optional] [default to null]
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientUserProfileMetadataSettings  -AdminCenter null `
 -EnableValueSync null `
 -EnableRoleValueSync null `
 -Value null `
 -Property null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

