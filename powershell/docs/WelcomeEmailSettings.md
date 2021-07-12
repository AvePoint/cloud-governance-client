# WelcomeEmailSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**Subject** | **String** |  | [optional] 
**PersonalMessage** | **String** |  | [optional] 
**EnabledSendEmailInService** | **Boolean** |  | [optional] [default to $false]
**WelcomeEmailTemplateId** | **String** |  | [optional] 
**IsWelcomeEmailTemplate** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$WelcomeEmailSettings = New-Cloud.Governance.ClientWelcomeEmailSettings  -Enabled null `
 -Subject null `
 -PersonalMessage null `
 -EnabledSendEmailInService null `
 -WelcomeEmailTemplateId null `
 -IsWelcomeEmailTemplate null
```

- Convert the resource to JSON
```powershell
$WelcomeEmailSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

