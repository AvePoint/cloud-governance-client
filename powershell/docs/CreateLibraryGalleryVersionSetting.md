# CreateLibraryGalleryVersionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableModeration** | **Boolean** |  | [optional] [default to $false]
**EnableVersioning** | **Boolean** |  | [optional] [default to $false]
**EnableMinorVersions** | **Boolean** |  | [optional] [default to $false]
**EnableMajorVersionLimit** | **Boolean** |  | [optional] [default to $false]
**MajorVersionLimit** | **Int32** |  | [optional] [default to 0]
**EnableMajorWithMinorVersionsLimit** | **Boolean** |  | [optional] [default to $false]
**MajorWithMinorVersionsLimit** | **Int32** |  | [optional] [default to 0]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateLibraryGalleryVersionSetting = New-Cloud.Governance.ClientCreateLibraryGalleryVersionSetting  -EnableModeration null `
 -EnableVersioning null `
 -EnableMinorVersions null `
 -EnableMajorVersionLimit null `
 -MajorVersionLimit null `
 -EnableMajorWithMinorVersionsLimit null `
 -MajorWithMinorVersionsLimit null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateLibraryGalleryVersionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

