# ChangeSiteSettingCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | **String** |  | [optional] 
**Office365TenantId** | **String** |  | [optional] 
**PictureUri** | **String** |  | [optional] 
**GroupId** | **String** |  | [optional] 
**IsManagedbyGAO** | **Boolean** |  | [optional] [default to $false]
**SiteUrl** | **String** |  | [optional] 
**AdminCenterUrl** | **String** |  | [optional] 
**IsGroupSite** | **Boolean** |  | [optional] [default to $false]
**SiteTitle** | **String** |  | [optional] 
**SiteDescription** | **String** |  | [optional] 
**SiteTemplate** | **String** |  | [optional] 
**SiteTimeZoneId** | **Int32** |  | [optional] [default to 0]
**SiteLocaleId** | **Int32** |  | [optional] [default to 0]
**SiteStorageSetting** | [**CheckSiteStorageSettingModel**](CheckSiteStorageSettingModel.md) |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**HubSiteSetting** | [**CheckSiteHubSiteSettingModel**](CheckSiteHubSiteSettingModel.md) |  | [optional] 
**SiteSharingSetting** | [**SiteSharingModel**](SiteSharingModel.md) |  | [optional] 
**IsEnableSensitivityLabel** | **Boolean** |  | [optional] [default to $false]
**GroupEmail** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**CoOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**EnvironmentName** | **String** |  | [optional] 
**WorkspaceTypeWithValidated** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsHybrid** | **Boolean** |  | [optional] [default to $false]
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingCheckResult = New-Cloud.Governance.ClientChangeSiteSettingCheckResult  -SiteId null `
 -Office365TenantId null `
 -PictureUri null `
 -GroupId null `
 -IsManagedbyGAO null `
 -SiteUrl null `
 -AdminCenterUrl null `
 -IsGroupSite null `
 -SiteTitle null `
 -SiteDescription null `
 -SiteTemplate null `
 -SiteTimeZoneId null `
 -SiteLocaleId null `
 -SiteStorageSetting null `
 -Classification null `
 -Sensitivity null `
 -HubSiteSetting null `
 -SiteSharingSetting null `
 -IsEnableSensitivityLabel null `
 -GroupEmail null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Owners null `
 -Members null `
 -CoOwners null `
 -TenantId null `
 -Privacy null `
 -EnvironmentName null `
 -WorkspaceTypeWithValidated null `
 -IsHybrid null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

