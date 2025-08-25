# Cloud.Governance.Client.Model.ChangeSiteSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **string** |  | [optional] 
**SiteId** | **Guid** |  | [optional] 
**SiteTitle** | **string** |  | [optional] 
**SiteDescription** | **string** |  | [optional] 
**IsEnableChangeHubSite** | **bool** |  | [optional] [default to false]
**IsModernSite** | **bool** |  | [optional] [default to false]
**IsHubSite** | **bool** |  | [optional] [default to false]
**AssociatedHubSiteId** | **Guid?** |  | [optional] 
**Metadatas** | [**List&lt;CustomMetadata&gt;**](CustomMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**TenantId** | **Guid** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**IsValid** | **bool** |  | [optional] [default to false]
**ErrorMessage** | **string** |  | [optional] 
**MessageCode** | **MessageCode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

