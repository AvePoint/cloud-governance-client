# ChangeDistributionGroupSettingsValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**IsAllowChangeDomain** | **Boolean** |  | [optional] [default to $false]
**ActionActivityTitle** | **String** |  | [optional] 
**SendAsActivityId** | **String** |  | [optional] 
**SendOnBehalfActivityId** | **String** |  | [optional] 
**DeliveryManagementActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeDistributionGroupSettingsValidationParameter = New-Cloud.Governance.ClientChangeDistributionGroupSettingsValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -IsAllowChangeDomain null `
 -ActionActivityTitle null `
 -SendAsActivityId null `
 -SendOnBehalfActivityId null `
 -DeliveryManagementActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeDistributionGroupSettingsValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

