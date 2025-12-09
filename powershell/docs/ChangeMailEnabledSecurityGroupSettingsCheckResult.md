# ChangeMailEnabledSecurityGroupSettingsCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabledHiddenGlobalFromAddressList** | **Boolean** |  | [optional] [default to $false]
**IsEnabledCommunication** | **Boolean** |  | [optional] [default to $false]
**SendAs** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SendOnBehalf** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**GroupId** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**Visibility** | **String** |  | [optional] 
**IsAssignableToRole** | **Boolean** |  | [optional] [default to $false]
**IsDeleted** | **Boolean** |  | [optional] [default to $false]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeMailEnabledSecurityGroupSettingsCheckResult = New-Cloud.Governance.ClientChangeMailEnabledSecurityGroupSettingsCheckResult  -IsEnabledHiddenGlobalFromAddressList null `
 -IsEnabledCommunication null `
 -SendAs null `
 -SendOnBehalf null `
 -GroupId null `
 -DisplayName null `
 -Email null `
 -Description null `
 -TenantId null `
 -Type null `
 -Visibility null `
 -IsAssignableToRole null `
 -IsDeleted null `
 -Metadatas null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeMailEnabledSecurityGroupSettingsCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

