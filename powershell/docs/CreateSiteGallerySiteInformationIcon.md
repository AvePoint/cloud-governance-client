# CreateSiteGallerySiteInformationIcon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InformationIconImageUrl** | **String** |  | [optional] 
**InformationDetailReferenceUrl** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteGallerySiteInformationIcon = New-Cloud.Governance.ClientCreateSiteGallerySiteInformationIcon  -InformationIconImageUrl null `
 -InformationDetailReferenceUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSiteGallerySiteInformationIcon | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

