# ChangeSiteSettingGalleryRequestModelSiteInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**GroupId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**IsManagedByGAO** | **Boolean** |  | [optional] [default to $false]
**IsGroupSite** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingGalleryRequestModelSiteInfo = New-Cloud.Governance.ClientChangeSiteSettingGalleryRequestModelSiteInfo  -Id null `
 -GroupId null `
 -TenantId null `
 -Url null `
 -IsManagedByGAO null `
 -IsGroupSite null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingGalleryRequestModelSiteInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

