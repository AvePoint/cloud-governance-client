# SiteExtensionLifecycleItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**PolicyExtensionType**](PolicyExtensionType.md) |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**DurationType**](DurationType.md) |  | [optional] [default to null]
**ExtendBasedOnPoint** | [**ExtendBasedOnPoint**](ExtendBasedOnPoint.md) |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**IsDefaultProcess** | **Boolean** |  | [optional] [default to null]
**Process** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteExtensionLifecycleItem  -Type null `
 -Duration null `
 -DurationType null `
 -ExtendBasedOnPoint null `
 -IsEnabled null `
 -IsDefaultProcess null `
 -Process null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

