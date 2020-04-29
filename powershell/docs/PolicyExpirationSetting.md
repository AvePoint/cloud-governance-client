# PolicyExpirationSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**DurationType**](DurationType.md) |  | [optional] [default to null]
**ProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsAutoLockEnabled** | **Boolean** |  | [optional] [default to null]
**AutoLockProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to null]
**NotifyTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyExpirationSetting  -IsEnabled null `
 -Duration null `
 -DurationType null `
 -ProcessId null `
 -IsAutoLockEnabled null `
 -AutoLockProfileId null `
 -IsNotifyEnabled null `
 -NotifyTemplateId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

