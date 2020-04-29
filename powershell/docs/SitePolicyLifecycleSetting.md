# SitePolicyLifecycleSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archive** | [**SiteArchiveLifecycleItem**](SiteArchiveLifecycleItem.md) |  | [optional] [default to null]
**Deletion** | [**SiteDeletionLifecycleItem**](SiteDeletionLifecycleItem.md) |  | [optional] [default to null]
**Extension** | [**SiteExtensionLifecycleItem**](SiteExtensionLifecycleItem.md) |  | [optional] [default to null]
**ChangePolicy** | [**SiteChangePolicyLifecycleItem**](SiteChangePolicyLifecycleItem.md) |  | [optional] [default to null]
**Unlock** | [**SiteUnlockingLifecycleItem**](SiteUnlockingLifecycleItem.md) |  | [optional] [default to null]
**Lock** | [**SiteLockLifecycleItem**](SiteLockLifecycleItem.md) |  | [optional] [default to null]
**Quota** | [**SiteQuotaLifecycleItem**](SiteQuotaLifecycleItem.md) |  | [optional] [default to null]
**DefaultProcess** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicyLifecycleSetting  -Archive null `
 -Deletion null `
 -Extension null `
 -ChangePolicy null `
 -Unlock null `
 -Lock null `
 -Quota null `
 -DefaultProcess null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

