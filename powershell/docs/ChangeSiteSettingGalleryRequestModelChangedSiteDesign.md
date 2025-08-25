# ChangeSiteSettingGalleryRequestModelChangedSiteDesign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**ChangedSiteDesignModelChangedValueRequestModelNewValue**](ChangedSiteDesignModelChangedValueRequestModelNewValue.md) |  | [optional] 
**OriginalValue** | [**ChangedSiteDesignModelChangedValueRequestModelNewValue**](ChangedSiteDesignModelChangedValueRequestModelNewValue.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingGalleryRequestModelChangedSiteDesign = New-Cloud.Governance.ClientChangeSiteSettingGalleryRequestModelChangedSiteDesign  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingGalleryRequestModelChangedSiteDesign | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

