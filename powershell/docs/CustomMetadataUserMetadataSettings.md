# CustomMetadataUserMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PeoplePickerProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**AllowBusinessUserToInputSingleValue** | **Boolean** |  | [optional] [default to $false]
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CustomMetadataUserMetadataSettings = New-Cloud.Governance.ClientCustomMetadataUserMetadataSettings  -Value null `
 -PeoplePickerProfile null `
 -AllowBusinessUserToInputSingleValue null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$CustomMetadataUserMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

