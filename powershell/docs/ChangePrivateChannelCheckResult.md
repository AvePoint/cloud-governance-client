# ChangePrivateChannelCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Team** | [**ChangePrivateChannelCheckResultTeam**](ChangePrivateChannelCheckResultTeam.md) |  | [optional] 
**Channels** | [**ApiUser[]**](ApiUser.md) | Channels | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelCheckResult = New-Cloud.Governance.ClientChangePrivateChannelCheckResult  -Team null `
 -Channels null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

