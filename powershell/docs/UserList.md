# UserList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to null]
**LoginName** | **String** |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**Email** | **String** |  | [optional] [default to null]
**IsDomainGroup** | **Boolean** |  | [optional] [default to null]
**AuthenticationType** | [**AuthenticationType**](AuthenticationType.md) |  | [optional] [default to null]
**UserTypeDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientUserList  -Id null `
 -LoginName null `
 -DisplayName null `
 -Email null `
 -IsDomainGroup null `
 -AuthenticationType null `
 -UserTypeDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

