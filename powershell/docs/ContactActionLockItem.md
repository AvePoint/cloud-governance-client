# ContactActionLockItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | [**UUID**](UUID.md) |  | [optional] [readonly] [default to null]
**ContactActionInstanceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**IsEnabledText** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContactActionLockItem  -InstanceId null `
 -ContactActionInstanceId null `
 -IsEnabled null `
 -IsEnabledText null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

