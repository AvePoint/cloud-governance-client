# ChangeSiteSettingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteTitleSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] [default to null]
**SiteDescriptionSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] [default to null]
**EnableChangedMetadata** | **Boolean** |  | [optional] [readonly] [default to null]
**ChangedMetadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**OriginalSiteMetadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [readonly] [default to null]
**DeploymentPlanName** | **String** |  | [optional] [default to null]
**HubSiteSettings** | [**HubSiteChangedSettings**](HubSiteChangedSettings.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**NotesToApprovers** | **String** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**TicketNumber** | **Int32** |  | [optional] [readonly] [default to null]
**Type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Requester** | **String** |  | [optional] [readonly] [default to null]
**Status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] [default to null]
**ProgressStatus** | **Int32** |  | [optional] [readonly] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**AssignTo** | **String** |  | [optional] [readonly] [default to null]
**FullPath** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeSiteSettingRequest  -SiteId null `
 -SiteUrl null `
 -SiteTitleSetting null `
 -SiteDescriptionSetting null `
 -EnableChangedMetadata null `
 -ChangedMetadatas null `
 -OriginalSiteMetadatas null `
 -DeploymentPlanName null `
 -HubSiteSettings null `
 -Id null `
 -ServiceId null `
 -Department null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -Metadatas null `
 -TicketNumber null `
 -Type null `
 -TypeDescription null `
 -Requester null `
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

