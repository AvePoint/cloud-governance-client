# DelegatedAccessTokenApiResultValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **String** |  | [optional] 
**RefreshToken** | **String** |  | [optional] 
**Duration** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$DelegatedAccessTokenApiResultValue = New-Cloud.Governance.ClientDelegatedAccessTokenApiResultValue  -AccessToken null `
 -RefreshToken null `
 -Duration null
```

- Convert the resource to JSON
```powershell
$DelegatedAccessTokenApiResultValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

