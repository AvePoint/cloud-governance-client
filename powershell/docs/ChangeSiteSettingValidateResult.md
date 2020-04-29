# ChangeSiteSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteTitle** | **String** |  | [optional] [default to null]
**SiteDescription** | **String** |  | [optional] [default to null]
**IsEnableChangeHubSite** | **Boolean** |  | [optional] [default to null]
**IsModernSite** | **Boolean** |  | [optional] [default to null]
**IsHubSite** | **Boolean** |  | [optional] [default to null]
**AssociatedHubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeSiteSettingValidateResult  -SiteUrl null `
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
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

