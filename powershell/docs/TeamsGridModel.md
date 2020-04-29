# TeamsGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamsId** | **String** |  | [optional] [default to null]
**TeamsName** | **String** |  | [optional] [default to null]
**TeamsSharing** | [**GroupEnableSharingStatus**](GroupEnableSharingStatus.md) |  | [optional] [default to null]
**GroupSharingDescription** | **String** |  | [optional] [readonly] [default to null]
**EnableTeamsArchive** | **Boolean** |  | [optional] [default to null]
**EnableTeamsRestore** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectId** | **String** |  | [optional] [default to null]
**PrimaryContact** | **String** |  | [optional] [default to null]
**PrimaryContactDisplayName** | **String** |  | [optional] [default to null]
**SecondaryContact** | **String** |  | [optional] [default to null]
**SecondaryContactDisplayName** | **String** |  | [optional] [default to null]
**Owners** | **String** |  | [optional] [default to null]
**OwnersDisplayName** | **String** |  | [optional] [default to null]
**PolicyName** | **String** |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Privacy** | **Boolean** |  | [optional] [default to null]
**PrivacyDescription** | **String** |  | [optional] [readonly] [default to null]
**SubscribeMembers** | **Boolean** |  | [optional] [default to null]
**TeamsSiteSharing** | [**TeamSiteEnableSharingStatus**](TeamSiteEnableSharingStatus.md) |  | [optional] [default to null]
**TeamsSharingDescription** | **String** |  | [optional] [readonly] [default to null]
**SubscribeMembersDescription** | **String** |  | [optional] [readonly] [default to null]
**OutsideSenders** | **Boolean** |  | [optional] [default to null]
**OutsideSendersDescription** | **String** |  | [optional] [readonly] [default to null]
**Language** | **String** |  | [optional] [default to null]
**LanguageDescription** | **String** |  | [optional] [readonly] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteQuota** | **String** |  | [optional] [default to null]
**SiteUsage** | **String** |  | [optional] [default to null]
**LeaseExpirationTime** | **System.DateTime** |  | [optional] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**EnableLeaseExtension** | **Boolean** |  | [optional] [default to null]
**EnablePolicyChange** | **Boolean** |  | [optional] [default to null]
**EnableDeletion** | **Boolean** |  | [optional] [default to null]
**EnableSiteQuotaChange** | **Boolean** |  | [optional] [default to null]
**EnableLeaseManagement** | **Boolean** |  | [optional] [default to null]
**EnableInactivityThreshold** | **Boolean** |  | [optional] [default to null]
**InactivityThresholdTime** | **System.DateTime** |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**EnableHiddenMembership** | **Boolean** |  | [optional] [default to null]
**PermissionRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**PermissionRecertificationStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**MembershipRecertificationStatus** | [**RecertificationStatus**](RecertificationStatus.md) |  | [optional] [default to null]
**MembershipRecertificationStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Status** | [**GroupStatus**](GroupStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Hub** | **String** |  | [optional] [default to null]
**GeoLocation** | **String** |  | [optional] [default to null]
**GeoLocationDescription** | **String** |  | [optional] [readonly] [default to null]
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**PhaseDescription** | **String** |  | [optional] [readonly] [default to null]
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTeamsGridModel  -TeamsId null `
 -TeamsName null `
 -TeamsSharing null `
 -GroupSharingDescription null `
 -EnableTeamsArchive null `
 -EnableTeamsRestore null `
 -Id null `
 -ObjectId null `
 -PrimaryContact null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactDisplayName null `
 -Owners null `
 -OwnersDisplayName null `
 -PolicyName null `
 -PolicyId null `
 -Privacy null `
 -PrivacyDescription null `
 -SubscribeMembers null `
 -TeamsSiteSharing null `
 -TeamsSharingDescription null `
 -SubscribeMembersDescription null `
 -OutsideSenders null `
 -OutsideSendersDescription null `
 -Language null `
 -LanguageDescription null `
 -SiteUrl null `
 -SiteQuota null `
 -SiteUsage null `
 -LeaseExpirationTime null `
 -CreatedTime null `
 -EnableLeaseExtension null `
 -EnablePolicyChange null `
 -EnableDeletion null `
 -EnableSiteQuotaChange null `
 -EnableLeaseManagement null `
 -EnableInactivityThreshold null `
 -InactivityThresholdTime null `
 -Classification null `
 -EnableHiddenMembership null `
 -PermissionRecertificationStatus null `
 -PermissionRecertificationStatusDescription null `
 -MembershipRecertificationStatus null `
 -MembershipRecertificationStatusDescription null `
 -Status null `
 -StatusDescription null `
 -Hub null `
 -GeoLocation null `
 -GeoLocationDescription null `
 -Phase null `
 -PhaseDescription null `
 -Metadata null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

