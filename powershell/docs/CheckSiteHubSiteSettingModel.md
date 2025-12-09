# CheckSiteHubSiteSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsHubSite** | **Boolean** |  | [optional] [default to $false]
**HubSiteTitle** | **String** |  | [optional] 
**AssociatedHubSiteId** | **String** |  | [optional] 
**EnabledUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CheckSiteHubSiteSettingModel = New-Cloud.Governance.ClientCheckSiteHubSiteSettingModel  -IsHubSite null `
 -HubSiteTitle null `
 -AssociatedHubSiteId null `
 -EnabledUsers null
```

- Convert the resource to JSON
```powershell
$CheckSiteHubSiteSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

