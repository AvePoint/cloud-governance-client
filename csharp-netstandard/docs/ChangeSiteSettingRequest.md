# Cloud.Governance.Client.Model.ChangeSiteSettingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **Guid** |  | [optional] 
**SiteUrl** | **string** |  | [optional] 
**SiteTitleSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**SiteDescriptionSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**EnableChangedMetadata** | **bool** |  | [optional] [readonly] 
**ChangedMetadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**OriginalSiteMetadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] [readonly] 
**DeploymentPlanName** | **string** |  | [optional] 
**HubSiteSettings** | [**HubSiteChangedSettings**](HubSiteChangedSettings.md) |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**ServiceId** | **Guid** |  | [optional] 
**Department** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] 
**NotesToApprovers** | **string** |  | [optional] 
**QuestionnaireId** | **Guid?** |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **int?** |  | [optional] [readonly] 
**Type** | **ServiceType** |  | [optional] [readonly] 
**TypeDescription** | **string** |  | [optional] [readonly] 
**Requester** | **string** |  | [optional] [readonly] 
**RequesterLoginName** | **string** |  | [optional] [readonly] 
**Status** | **RequestStatus** |  | [optional] [readonly] 
**ProgressStatus** | **int** |  | [optional] [readonly] 
**ProgressStatusDescription** | **string** |  | [optional] [readonly] 
**SubmittedTime** | **DateTime?** |  | [optional] [readonly] 
**LastUpdated** | **DateTime?** |  | [optional] [readonly] 
**CreatedTime** | **DateTime?** |  | [optional] [readonly] 
**AssignTo** | **string** |  | [optional] [readonly] 
**FullPath** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

