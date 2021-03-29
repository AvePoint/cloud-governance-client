# DelegatedAccessToken
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **String** |  | [optional] 
**RefreshToken** | **String** |  | [optional] 
**Duration** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$DelegatedAccessToken = New-Cloud.Governance.ClientDelegatedAccessToken  -AccessToken null `
 -RefreshToken null `
 -Duration null
```

- Convert the resource to JSON
```powershell
$DelegatedAccessToken | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

