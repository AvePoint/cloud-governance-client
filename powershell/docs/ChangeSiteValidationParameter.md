# ChangeSiteValidationParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**Office365TenantId** | **String** |  | [optional] 
**ScopeActivityId** | **String** |  | [optional] 
**ClassificationActivityId** | **String** |  | [optional] 
**SensitivityLabelActivityId** | **String** |  | [optional] 
**StorageActivityId** | **String** |  | [optional] 
**TitleActivityId** | **String** |  | [optional] 
**HubSiteActivityId** | **String** |  | [optional] 
**SharingActivityId** | **String** |  | [optional] 
**DescriptionActivityId** | **String** |  | [optional] 
**LocaleActivityId** | **String** |  | [optional] 
**TimeZoneActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteValidationParameter = New-Cloud.Governance.ClientChangeSiteValidationParameter  -SiteUrl null `
 -Office365TenantId null `
 -ScopeActivityId null `
 -ClassificationActivityId null `
 -SensitivityLabelActivityId null `
 -StorageActivityId null `
 -TitleActivityId null `
 -HubSiteActivityId null `
 -SharingActivityId null `
 -DescriptionActivityId null `
 -LocaleActivityId null `
 -TimeZoneActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteValidationParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

