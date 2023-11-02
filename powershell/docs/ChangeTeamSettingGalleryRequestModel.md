# ChangeTeamSettingGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamSettingInfo** | [**ChangeTeamSettingModel**](ChangeTeamSettingModel.md) |  | [optional] 
**ChangeTeamDisplayName** | [**ChangeTeamDisplayName**](ChangeTeamDisplayName.md) |  | [optional] 
**ChangeTeamDescription** | [**ChangeTeamRequestDescription**](ChangeTeamRequestDescription.md) |  | [optional] 
**ChangeTeamPrivacySetting** | [**ChangeTeamPrivacySetting**](ChangeTeamPrivacySetting.md) |  | [optional] 
**ChangeTeamClassificationAndSensitivityLabel** | [**ChangeTeamClassificationAndSensitivityLabel**](ChangeTeamClassificationAndSensitivityLabel.md) |  | [optional] 
**ChangeTeamOutlookExperience** | [**OutlookExperience**](OutlookExperience.md) |  | [optional] 
**ChangeGlobalAddressList** | [**GlobalAddressList**](GlobalAddressList.md) |  | [optional] 
**FunStuffSettings** | [**ChangeTeamFunStuff**](ChangeTeamFunStuff.md) |  | [optional] 
**Mentions** | [**ChangeTeamMentions**](ChangeTeamMentions.md) |  | [optional] 
**ChangeTeamMemberPermission** | [**ChangeTeamMemberPermission**](ChangeTeamMemberPermission.md) |  | [optional] 
**GuestPermissions** | [**GuestPermissions**](GuestPermissions.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

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
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

