# SPList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Url** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**IsLibrary** | **Boolean** |  | [optional] [readonly] [default to null]
**IsOnQuickLaunch** | **Boolean** |  | [optional] [default to null]
**IsEnableModeration** | **Boolean** |  | [optional] [default to null]
**IsEnableVersioning** | **Boolean** |  | [optional] [default to null]
**IsEnableMinorVersion** | **Boolean** |  | [optional] [default to null]
**MajorVersionLimit** | **Int32** |  | [optional] [default to null]
**MajorWithMinorVersionsLimit** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPList  -Id null `
 -Title null `
 -Url null `
 -Description null `
 -IsLibrary null `
 -IsOnQuickLaunch null `
 -IsEnableModeration null `
 -IsEnableVersioning null `
 -IsEnableMinorVersion null `
 -MajorVersionLimit null `
 -MajorWithMinorVersionsLimit null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

