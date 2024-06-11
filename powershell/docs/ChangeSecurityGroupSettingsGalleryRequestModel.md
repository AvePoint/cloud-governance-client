# ChangeSecurityGroupSettingsGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeGroupVisibility** | [**ChangeGroupRequestVisibility**](ChangeGroupRequestVisibility.md) |  | [optional] 
**GroupSettingInfo** | [**ChangeGroupSettingsModel**](ChangeGroupSettingsModel.md) |  | [optional] 
**ChangeGroupName** | [**ChangeGroupRequestName**](ChangeGroupRequestName.md) |  | [optional] 
**ChangeGroupDescription** | [**ChangeGroupRequestDescription**](ChangeGroupRequestDescription.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModel = New-Cloud.Governance.ClientChangeSecurityGroupSettingsGalleryRequestModel  -ChangeGroupVisibility null `
 -GroupSettingInfo null `
 -ChangeGroupName null `
 -ChangeGroupDescription null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

