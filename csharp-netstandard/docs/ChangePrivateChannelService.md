# Cloud.Governance.Client.Model.ChangePrivateChannelService
Change PrivateChannel Service
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangePrivateChannelFields** | [**List&lt;ChangePrivateChannelFieldModel&gt;**](ChangePrivateChannelFieldModel.md) | Change PrivateChannel fields | [optional] 
**ChangePrivateChannelQuotaSetting** | [**ChangePrivateChannelQuotaModel**](ChangePrivateChannelQuotaModel.md) |  | [optional] 
**TenantId** | **Guid** | Tenant id | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **bool** |  | [optional] [default to false]
**Id** | **Guid** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **ServiceType** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ApproversContainManagerRole** | **bool** |  | [optional] [default to false]
**Status** | **CommonStatus** |  | [optional] 
**ShowServiceInCatalog** | **bool** |  | [optional] [default to false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **Guid** |  | [optional] 
**LanguageId** | **int** |  | [optional] [default to 0]
**CategoryId** | **string** |  | [optional] 
**RequestTemplate** | [**ApiRequest**](ApiRequest.md) | Base model of request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

