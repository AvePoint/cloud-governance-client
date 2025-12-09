# ChangeGroupSettingsValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingsValidationParameter = New-Cloud.Governance.ClientChangeGroupSettingsValidationParameter  -TenantId null `
 -ObjectId null `
 -Email null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingsValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

