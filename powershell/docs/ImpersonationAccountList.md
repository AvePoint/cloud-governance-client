# ImpersonationAccountList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**TenantName** | **String** |  | [optional] [default to null]
**Domain** | **String** |  | [optional] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientImpersonationAccountList  -Id null `
 -DisplayName null `
 -TenantId null `
 -TenantName null `
 -Domain null `
 -ModifiedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

