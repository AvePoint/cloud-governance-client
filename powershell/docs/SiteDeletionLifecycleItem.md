# SiteDeletionLifecycleItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPermanentlyDelete** | **Boolean** |  | [optional] [default to null]
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to null]
**NotifyUser** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**NotifyTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**IsDefaultProcess** | **Boolean** |  | [optional] [default to null]
**Process** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteDeletionLifecycleItem  -IsPermanentlyDelete null `
 -IsNotifyEnabled null `
 -NotifyUser null `
 -NotifyTemplate null `
 -IsEnabled null `
 -IsDefaultProcess null `
 -Process null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

