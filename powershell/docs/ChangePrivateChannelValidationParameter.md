# ChangePrivateChannelValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamObjectId** | **String** | team object id | [optional] 
**TenantId** | **String** | tenant id | [optional] 
**TaskId** | **String** | Task id | [optional] 
**IsEditTask** | **Boolean** |  | [optional] [default to $false]
**IsFromQuestionnaire** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelValidationParameter = New-Cloud.Governance.ClientChangePrivateChannelValidationParameter  -TeamObjectId null `
 -TenantId null `
 -TaskId null `
 -IsEditTask null `
 -IsFromQuestionnaire null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

