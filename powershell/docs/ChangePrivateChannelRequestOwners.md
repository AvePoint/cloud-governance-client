# ChangePrivateChannelRequestOwners
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**OriginalValue** | [**ApiUser[]**](ApiUser.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelRequestOwners = New-Cloud.Governance.ClientChangePrivateChannelRequestOwners  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelRequestOwners | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

