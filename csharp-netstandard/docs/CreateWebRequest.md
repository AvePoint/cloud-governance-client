# Cloud.Governance.Client.Model.CreateWebRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebName** | **string** |  | [optional] 
**WebTitle** | **string** |  | [optional] 
**WebDescription** | **string** |  | [optional] 
**WebLanguage** | [**IntModel**](IntModel.md) |  | [optional] 
**WebTemplate** | **string** |  | [optional] 
**ParentSiteUrl** | **string** |  | [optional] 
**ParentWebUrl** | **string** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**UserPermissions** | [**List&lt;RequestUserWithPermissions&gt;**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**List&lt;RequestGroupWithPermissions&gt;**](RequestGroupWithPermissions.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) |  | [optional] 
**IsOnQuickLaunch** | **bool** |  | [optional] 
**IsOnTopLinkBar** | **bool** |  | [optional] 
**IsInheritance** | **bool** |  | [optional] 
**DeploymentManagerPlanName** | **string** |  | [optional] 
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

