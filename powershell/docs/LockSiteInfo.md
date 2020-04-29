# LockSiteInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockPermissionAction** | [**PermissionActionLockItem**](PermissionActionLockItem.md) |  | [optional] [default to null]
**LockContactAction** | [**ContactActionLockItem**](ContactActionLockItem.md) |  | [optional] [default to null]
**LockMetadataAction** | [**MetadataActionLockItem**](MetadataActionLockItem.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientLockSiteInfo  -LockPermissionAction null `
 -LockContactAction null `
 -LockMetadataAction null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

