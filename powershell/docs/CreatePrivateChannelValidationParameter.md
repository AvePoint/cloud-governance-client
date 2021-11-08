# CreatePrivateChannelValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamObjectId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CreatePrivateChannelValidationParameter = New-Cloud.Governance.ClientCreatePrivateChannelValidationParameter  -TeamObjectId null `
 -TenantId null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$CreatePrivateChannelValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

