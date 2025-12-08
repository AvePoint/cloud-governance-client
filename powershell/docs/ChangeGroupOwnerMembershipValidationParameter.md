# ChangeGroupOwnerMembershipValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**GroupType** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupOwnerMembershipValidationParameter = New-Cloud.Governance.ClientChangeGroupOwnerMembershipValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -GroupType null
```

- Convert the resource to JSON
```powershell
$ChangeGroupOwnerMembershipValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

