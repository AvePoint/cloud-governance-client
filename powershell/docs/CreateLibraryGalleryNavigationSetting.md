# CreateLibraryGalleryNavigationSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsDisplayOnQuickLaunch** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateLibraryGalleryNavigationSetting = New-Cloud.Governance.ClientCreateLibraryGalleryNavigationSetting  -IsDisplayOnQuickLaunch null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateLibraryGalleryNavigationSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

