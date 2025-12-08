# ChangeExchangeResourceGroupSettingsValidationParameter
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
$ChangeExchangeResourceGroupSettingsValidationParameter = New-Cloud.Governance.ClientChangeExchangeResourceGroupSettingsValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -GroupType null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceGroupSettingsValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

