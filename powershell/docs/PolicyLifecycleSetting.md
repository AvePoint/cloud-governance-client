# PolicyLifecycleSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archiver** | [**PolicyArchiverLifecycleItem**](PolicyArchiverLifecycleItem.md) |  | [optional] [default to null]
**Deletion** | [**PolicyDeletionLifecycleItem**](PolicyDeletionLifecycleItem.md) |  | [optional] [default to null]
**Extension** | [**PolicyExtensionLifecycleItem**](PolicyExtensionLifecycleItem.md) |  | [optional] [default to null]
**Change** | [**PolicyChangeLifecycleItem**](PolicyChangeLifecycleItem.md) |  | [optional] [default to null]
**Unlock** | [**PolicyLifecycleItem**](PolicyLifecycleItem.md) |  | [optional] [default to null]
**Lock** | [**PolicyLockLifecycleItem**](PolicyLockLifecycleItem.md) |  | [optional] [default to null]
**Quota** | [**PolicyQuotaLifecycleItem**](PolicyQuotaLifecycleItem.md) |  | [optional] [default to null]
**DefaultProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyLifecycleSetting  -Archiver null `
 -Deletion null `
 -Extension null `
 -Change null `
 -Unlock null `
 -Lock null `
 -Quota null `
 -DefaultProcessId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

