# ImpersonationAccountModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Domain** | **String** |  | [default to null]
**User** | [**ApiUser**](ApiUser.md) |  | [default to null]
**Tenant** | [**GuidModel**](GuidModel.md) |  | [default to null]
**Tenants** | [**StringModel[]**](StringModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientImpersonationAccountModel  -Id null `
 -Domain null `
 -User null `
 -Tenant null `
 -Tenants null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

