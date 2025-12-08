# ChangeExchangeResourceGroupSettingsCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
$ChangeExchangeResourceGroupSettingsCheckResult = New-Cloud.Governance.ClientChangeExchangeResourceGroupSettingsCheckResult  -GroupId null `
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
$ChangeExchangeResourceGroupSettingsCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

