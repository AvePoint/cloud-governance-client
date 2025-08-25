# CreatePrivateChannelCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Team** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreatePrivateChannelCheckResult = New-Cloud.Governance.ClientCreatePrivateChannelCheckResult  -Owners null `
 -Team null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$CreatePrivateChannelCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

