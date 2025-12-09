# ChangePowerBIWorkspaceAccessValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**ObjectName** | **String** |  | [optional] 
**AdminActivityId** | **String** |  | [optional] 
**ContributorActivityId** | **String** |  | [optional] 
**MemberActivityId** | **String** |  | [optional] 
**ViewerActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePowerBIWorkspaceAccessValidationParameter = New-Cloud.Governance.ClientChangePowerBIWorkspaceAccessValidationParameter  -TenantId null `
 -ObjectId null `
 -ObjectName null `
 -AdminActivityId null `
 -ContributorActivityId null `
 -MemberActivityId null `
 -ViewerActivityId null
```

- Convert the resource to JSON
```powershell
$ChangePowerBIWorkspaceAccessValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

