# UserMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PeoplePickerProfile** | [**GuidModel**](GuidModel.md) |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$UserMetadataSettings = New-Cloud.Governance.ClientUserMetadataSettings  -Value null `
 -PeoplePickerProfile null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$UserMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

