# ChangeTeamSettingGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamSettingInfo** | [**ChangeTeamSettingGalleryRequestModelTeamSettingInfo**](ChangeTeamSettingGalleryRequestModelTeamSettingInfo.md) |  | [optional] 
**ChangeTeamDisplayName** | [**ChangeTeamSettingGalleryRequestModelChangeTeamDisplayName**](ChangeTeamSettingGalleryRequestModelChangeTeamDisplayName.md) |  | [optional] 
**ChangeTeamDescription** | [**ChangeTeamSettingGalleryRequestModelChangeTeamDescription**](ChangeTeamSettingGalleryRequestModelChangeTeamDescription.md) |  | [optional] 
**ChangeTeamPrivacySetting** | [**ChangeTeamSettingGalleryRequestModelChangeTeamPrivacySetting**](ChangeTeamSettingGalleryRequestModelChangeTeamPrivacySetting.md) |  | [optional] 
**ChangeTeamClassificationAndSensitivityLabel** | [**ChangeTeamSettingGalleryRequestModelChangeTeamClassificationAndSensitivityLabel**](ChangeTeamSettingGalleryRequestModelChangeTeamClassificationAndSensitivityLabel.md) |  | [optional] 
**ChangeTeamOutlookExperience** | [**ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience**](ChangeTeamSettingGalleryRequestModelChangeTeamOutlookExperience.md) |  | [optional] 
**ChangeGlobalAddressList** | [**ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList**](ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList.md) |  | [optional] 
**FunStuffSettings** | [**ChangeTeamSettingGalleryRequestModelFunStuffSettings**](ChangeTeamSettingGalleryRequestModelFunStuffSettings.md) |  | [optional] 
**Mentions** | [**ChangeTeamSettingGalleryRequestModelMentions**](ChangeTeamSettingGalleryRequestModelMentions.md) |  | [optional] 
**ChangeTeamMemberPermission** | [**ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission**](ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission.md) |  | [optional] 
**GuestPermissions** | [**ChangeTeamSettingGalleryRequestModelGuestPermissions**](ChangeTeamSettingGalleryRequestModelGuestPermissions.md) |  | [optional] 
**ChangeTeamPicture** | [**ChangeTeamSettingGalleryRequestModelChangeTeamPicture**](ChangeTeamSettingGalleryRequestModelChangeTeamPicture.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingGalleryRequestModel = New-Cloud.Governance.ClientChangeTeamSettingGalleryRequestModel  -TeamSettingInfo null `
 -ChangeTeamDisplayName null `
 -ChangeTeamDescription null `
 -ChangeTeamPrivacySetting null `
 -ChangeTeamClassificationAndSensitivityLabel null `
 -ChangeTeamOutlookExperience null `
 -ChangeGlobalAddressList null `
 -FunStuffSettings null `
 -Mentions null `
 -ChangeTeamMemberPermission null `
 -GuestPermissions null `
 -ChangeTeamPicture null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

