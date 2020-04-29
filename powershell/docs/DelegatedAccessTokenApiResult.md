# DelegatedAccessTokenApiResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**DelegatedAccessToken**](DelegatedAccessToken.md) |  | [optional] [default to null]
**IsSuccess** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMsg** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDelegatedAccessTokenApiResult  -Value null `
 -IsSuccess null `
 -ErrorMsg null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

