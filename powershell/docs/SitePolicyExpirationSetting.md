# SitePolicyExpirationSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**DurationType**](DurationType.md) |  | [optional] [default to null]
**Process** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsAutoLockEnabled** | **Boolean** |  | [optional] [default to null]
**AutoLockProfile** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to null]
**NotifyTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicyExpirationSetting  -IsEnabled null `
 -Duration null `
 -DurationType null `
 -Process null `
 -IsAutoLockEnabled null `
 -AutoLockProfile null `
 -IsNotifyEnabled null `
 -NotifyTemplate null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

