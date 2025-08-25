# CreateSharedMailboxGalleryLanguageDataTime
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**DateFormat** | **String** |  | [optional] 
**TimeFormat** | **String** |  | [optional] 
**EnableLocalizeDefaultFolderName** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedMailboxGalleryLanguageDataTime = New-Cloud.Governance.ClientCreateSharedMailboxGalleryLanguageDataTime  -Language null `
 -LanguageId null `
 -DateFormat null `
 -TimeFormat null `
 -EnableLocalizeDefaultFolderName null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSharedMailboxGalleryLanguageDataTime | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

