# ValidateInviteGuestEmailModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ValidateInviteGuestEmailModel = New-Cloud.Governance.ClientValidateInviteGuestEmailModel  -TenantId null `
 -Email null
```

- Convert the resource to JSON
```powershell
$ValidateInviteGuestEmailModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

