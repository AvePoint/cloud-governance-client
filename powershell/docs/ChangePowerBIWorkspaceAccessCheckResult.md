# ChangePowerBIWorkspaceAccessCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Admins** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Contributors** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Viewers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePowerBIWorkspaceAccessCheckResult = New-Cloud.Governance.ClientChangePowerBIWorkspaceAccessCheckResult  -ObjectId null `
 -OfficeTenantId null `
 -Admins null `
 -Contributors null `
 -Members null `
 -Viewers null `
 -Metadatas null `
 -PrimaryContact null `
 -SecondaryContact null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangePowerBIWorkspaceAccessCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

