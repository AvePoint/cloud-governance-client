# UserMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UserMetadataSettings = New-Cloud.Governance.ClientUserMetadataSettings  -Value null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$UserMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

