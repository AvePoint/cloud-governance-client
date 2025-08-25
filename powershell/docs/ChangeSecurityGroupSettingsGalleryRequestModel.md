# ChangeSecurityGroupSettingsGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeGroupVisibility** | [**ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility**](ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupVisibility.md) |  | [optional] 
**GroupSettingInfo** | [**ChangeSecurityGroupSettingsGalleryRequestModelGroupSettingInfo**](ChangeSecurityGroupSettingsGalleryRequestModelGroupSettingInfo.md) |  | [optional] 
**ChangeGroupName** | [**ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupName**](ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupName.md) |  | [optional] 
**ChangeGroupDescription** | [**ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupDescription**](ChangeSecurityGroupSettingsGalleryRequestModelChangeGroupDescription.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModel = New-Cloud.Governance.ClientChangeSecurityGroupSettingsGalleryRequestModel  -ChangeGroupVisibility null `
 -GroupSettingInfo null `
 -ChangeGroupName null `
 -ChangeGroupDescription null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeSecurityGroupSettingsGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

