# ChangeYammerSettingValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**RequestId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeYammerSettingValidationParameter = New-Cloud.Governance.ClientChangeYammerSettingValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -RequestId null
```

- Convert the resource to JSON
```powershell
$ChangeYammerSettingValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

