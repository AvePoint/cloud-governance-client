# ChangeGroupSettingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**GroupRestriction** | [**GroupRestrictionType**](GroupRestrictionType.md) |  | [optional] 
**EnableChangeName** | **Boolean** |  | [optional] [default to $false]
**PreventDuplicateName** | **Boolean** |  | [optional] [default to $false]
**EnableChangeDescription** | **Boolean** |  | [optional] [default to $false]
**EnableChangeMemberSubscription** | **Boolean** |  | [optional] [default to $false]
**EnableChangeOutsideSenders** | **Boolean** |  | [optional] [default to $false]
**EnableChangePrimaryContact** | **Boolean** |  | [optional] [default to $false]
**EnableChangeSecondaryContact** | **Boolean** |  | [optional] [default to $false]
**EnableAddOwners** | **Boolean** |  | [optional] [default to $false]
**AddOwnerRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**EnableRemoveOwners** | **Boolean** |  | [optional] [default to $false]
**EnableAddMembers** | **Boolean** |  | [optional] [default to $false]
**AddMemberRestriction** | [**UserLevelRestrictionType**](UserLevelRestrictionType.md) |  | [optional] 
**EnableRemoveMembers** | **Boolean** |  | [optional] [default to $false]
**EnableChangeDynamicMembershipRules** | **Boolean** |  | [optional] [default to $false]
**EnableChangeTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
**EnableChangeHubSite** | **Boolean** |  | [optional] [default to $false]
**EnableChangeClassification** | **Boolean** |  | [optional] [default to $false]
**ClassificationList** | **String[]** |  | [optional] 
**EnableChangeSensitivity** | **Boolean** |  | [optional] [default to $false]
**SensitivityList** | [**StringModel[]**](StringModel.md) |  | [optional] 
**EnableChangeMetadata** | **Boolean** |  | [optional] [default to $false]
**EnableAddOrDeleteMetadata** | **Boolean** |  | [optional] [default to $false]
**MetadataList** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**EnableChangeMembershipType** | **Boolean** |  | [optional] [default to $false]
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**EnableChangeYammerGroupInfo** | **Boolean** |  | [optional] [default to $false]
**ScopePeoplePickerFilterProfileId** | **String** |  | [optional] 
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**RequestTemplate** | [**ChangeGroupSettingRequest**](ChangeGroupSettingRequest.md) |  | [optional] 
**IsChangeTimeZoneEnabled** | **Boolean** |  | [optional] [default to $false]
**IsChangeLocaleEnabled** | **Boolean** |  | [optional] [default to $false]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupSettingService = New-Cloud.Governance.ClientChangeGroupSettingService  -TenantId null `
 -NetworkId null `
 -GroupRestriction null `
 -EnableChangeName null `
 -PreventDuplicateName null `
 -EnableChangeDescription null `
 -EnableChangeMemberSubscription null `
 -EnableChangeOutsideSenders null `
 -EnableChangePrimaryContact null `
 -EnableChangeSecondaryContact null `
 -EnableAddOwners null `
 -AddOwnerRestriction null `
 -EnableRemoveOwners null `
 -EnableAddMembers null `
 -AddMemberRestriction null `
 -EnableRemoveMembers null `
 -EnableChangeDynamicMembershipRules null `
 -EnableChangeTeamCollaboration null `
 -EnableChangeHubSite null `
 -EnableChangeClassification null `
 -ClassificationList null `
 -EnableChangeSensitivity null `
 -SensitivityList null `
 -EnableChangeMetadata null `
 -EnableAddOrDeleteMetadata null `
 -MetadataList null `
 -EnableChangeMembershipType null `
 -GroupObjectType null `
 -EnableChangeYammerGroupInfo null `
 -ScopePeoplePickerFilterProfileId null `
 -PeoplePickerFilterProfileId null `
 -RequestTemplate null `
 -IsChangeTimeZoneEnabled null `
 -IsChangeLocaleEnabled null `
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
 -ServiceContact null `
 -ServiceAdminContact null `
 -ApproversContainManagerRole null `
 -Status null `
 -ShowServiceInCatalog null `
 -CustomActions null `
 -ApprovalProcessId null `
 -LanguageId null `
 -CategoryId null
```

- Convert the resource to JSON
```powershell
$ChangeGroupSettingService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

