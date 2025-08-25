# CreateSiteGallerySiteLanguage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Language** | **Int32** |  | [optional] [default to 0]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteGallerySiteLanguage = New-Cloud.Governance.ClientCreateSiteGallerySiteLanguage  -Language null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSiteGallerySiteLanguage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

