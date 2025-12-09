# ChangeSharedMailboxPermissionValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeActivityId** | **String** |  | [optional] 
**MembersActivityId** | **String** |  | [optional] 
**SendAsActivityId** | **String** |  | [optional] 
**SendOnBehalfActivityId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSharedMailboxPermissionValidationParameter = New-Cloud.Governance.ClientChangeSharedMailboxPermissionValidationParameter  -ScopeActivityId null `
 -MembersActivityId null `
 -SendAsActivityId null `
 -SendOnBehalfActivityId null `
 -TenantId null `
 -ObjectId null `
 -DisplayName null `
 -Email null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ChangeSharedMailboxPermissionValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

