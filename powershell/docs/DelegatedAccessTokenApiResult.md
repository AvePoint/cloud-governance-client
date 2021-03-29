# DelegatedAccessTokenApiResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**DelegatedAccessToken**](DelegatedAccessToken.md) |  | [optional] 
**IsSuccess** | **Boolean** |  | [optional] [default to $false]
**ErrorMsg** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DelegatedAccessTokenApiResult = New-Cloud.Governance.ClientDelegatedAccessTokenApiResult  -Value null `
 -IsSuccess null `
 -ErrorMsg null
```

- Convert the resource to JSON
```powershell
$DelegatedAccessTokenApiResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

