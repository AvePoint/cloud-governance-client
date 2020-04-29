# PolicyQuotaLifecycleItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Option** | [**QuotaOption**](QuotaOption.md) |  | [optional] [default to null]
**Size** | **Int32** |  | [optional] [default to null]
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to null]
**NotifyUser** | **String** |  | [optional] [default to null]
**NotifyTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**IsDefaultProcess** | **Boolean** |  | [optional] [default to null]
**ProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyQuotaLifecycleItem  -Option null `
 -Size null `
 -IsNotifyEnabled null `
 -NotifyUser null `
 -NotifyTemplate null `
 -IsEnabled null `
 -IsDefaultProcess null `
 -ProcessId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

