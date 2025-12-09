# Cloud.Governance.Client.Model.ChangeSiteSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **Guid** |  | [optional] 
**Office365TenantId** | **Guid** |  | [optional] 
**PictureUri** | **string** |  | [optional] 
**GroupId** | **Guid** |  | [optional] 
**IsManagedbyGAO** | **bool** |  | [optional] [default to false]
**SiteUrl** | **string** |  | [optional] 
**AdminCenterUrl** | **string** |  | [optional] 
**IsGroupSite** | **bool** |  | [optional] [default to false]
**SiteTitle** | **string** |  | [optional] 
**SiteDescription** | **string** |  | [optional] 
**SiteTemplate** | **string** |  | [optional] 
**SiteTimeZoneId** | **int** |  | [optional] [default to 0]
**SiteLocaleId** | **int** |  | [optional] [default to 0]
**SiteStorageSetting** | [**CheckSiteStorageSettingModel**](CheckSiteStorageSettingModel.md) |  | [optional] 
**Classification** | **string** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**HubSiteSetting** | [**CheckSiteHubSiteSettingModel**](CheckSiteHubSiteSettingModel.md) |  | [optional] 
**SiteSharingSetting** | [**SiteSharingModel**](SiteSharingModel.md) |  | [optional] 
**IsEnableSensitivityLabel** | **bool** |  | [optional] [default to false]
**GroupEmail** | **string** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Owners** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**Members** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**CoOwners** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**TenantId** | **string** |  | [optional] 
**Privacy** | **bool** |  | [optional] [default to false]
**EnvironmentName** | **string** |  | [optional] 
**WorkspaceTypeWithValidated** | **WorkspaceType** |  | [optional] 
**IsHybrid** | **bool** |  | [optional] [default to false]
**IsValid** | **bool** |  | [optional] [default to false]
**ErrorMessage** | **string** |  | [optional] 
**MessageCode** | **MessageCode** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

