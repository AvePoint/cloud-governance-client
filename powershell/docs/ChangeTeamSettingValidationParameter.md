# ChangeTeamSettingValidationParameter
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
$ChangeTeamSettingValidationParameter = New-Cloud.Governance.ClientChangeTeamSettingValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null `
 -RequestId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

