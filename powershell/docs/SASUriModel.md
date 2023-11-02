# SASUriModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 
**ExpiredTime** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$SASUriModel = New-Cloud.Governance.ClientSASUriModel  -Uri null `
 -FileName null `
 -ExpiredTime null
```

- Convert the resource to JSON
```powershell
$SASUriModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

