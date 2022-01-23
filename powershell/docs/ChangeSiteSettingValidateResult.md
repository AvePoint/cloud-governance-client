# ChangeSiteSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**SiteTitle** | **String** |  | [optional] 
**SiteDescription** | **String** |  | [optional] 
**IsEnableChangeHubSite** | **Boolean** |  | [optional] [default to $false]
**IsModernSite** | **Boolean** |  | [optional] [default to $false]
**IsHubSite** | **Boolean** |  | [optional] [default to $false]
**AssociatedHubSiteId** | **String** |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**TenantId** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingValidateResult = New-Cloud.Governance.ClientChangeSiteSettingValidateResult  -SiteUrl null `
 -SiteId null `
 -SiteTitle null `
 -SiteDescription null `
 -IsEnableChangeHubSite null `
 -IsModernSite null `
 -IsHubSite null `
 -AssociatedHubSiteId null `
 -Metadatas null `
 -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryAdministrator null `
 -TenantId null `
 -Sensitivity null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

