# ApplyPolicyRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LocationId** | **Int32** |  | [optional] [default to null]
**FolderUrl** | **String** |  | [optional] [default to null]
**StartDateType** | [**StartDateType**](StartDateType.md) |  | [optional] [default to null]
**IsCheckLock** | **Boolean** |  | [optional] [default to null]
**Filter** | **String** |  | [optional] [default to null]
**SelectedObjectsId** | [**UUID[]**](UUID.md) |  | [optional] [default to null]
**SpecifyDateTicks** | **Int64** |  | [optional] [default to null]
**IsExportLocation** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApplyPolicyRequestModel  -PolicyId null `
 -LocationId null `
 -FolderUrl null `
 -StartDateType null `
 -IsCheckLock null `
 -Filter null `
 -SelectedObjectsId null `
 -SpecifyDateTicks null `
 -IsExportLocation null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

