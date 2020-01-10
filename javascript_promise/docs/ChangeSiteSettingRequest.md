# CgClient.ChangeSiteSettingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**siteId** | **String** |  | [optional] 
**siteUrl** | **String** |  | [optional] 
**siteTitleSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**siteDescriptionSetting** | [**StringChangedProperty**](StringChangedProperty.md) |  | [optional] 
**enableChangedMetadata** | **Boolean** |  | [optional] [readonly] 
**changedMetadatas** | [**[RequestMetadata]**](RequestMetadata.md) |  | [optional] 
**originalSiteMetadatas** | [**[RequestMetadata]**](RequestMetadata.md) |  | [optional] [readonly] 
**deploymentPlanName** | **String** |  | [optional] 
**hubSiteSettings** | [**HubSiteChangedSettings**](HubSiteChangedSettings.md) |  | [optional] 
**id** | **String** |  | [optional] 
**serviceId** | **String** |  | [optional] 
**department** | **String** |  | [optional] 
**summary** | **String** |  | [optional] 
**notesToApprovers** | **String** |  | [optional] 
**questionnaireId** | **String** |  | [optional] 
**metadatas** | [**[RequestMetadata]**](RequestMetadata.md) |  | [optional] 
**ticketNumber** | **Number** |  | [optional] [readonly] 
**type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] 
**typeDescription** | **String** |  | [optional] [readonly] 
**requester** | **String** |  | [optional] [readonly] 
**status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] 
**progressStatus** | **Number** |  | [optional] [readonly] 
**progressStatusDescription** | **String** |  | [optional] [readonly] 
**submittedTime** | **Date** |  | [optional] [readonly] 
**lastUpdated** | **Date** |  | [optional] [readonly] 
**createdTime** | **Date** |  | [optional] [readonly] 
**assignTo** | **String** |  | [optional] [readonly] 
**fullPath** | **String** |  | [optional] [readonly] 


