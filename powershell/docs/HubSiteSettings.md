# HubSiteSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**Action** | [**ConvertHubSiteActionType**](ConvertHubSiteActionType.md) |  | [optional] [default to null]
**AssociatedHubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AssociatedHubSiteTitle** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientHubSiteSettings  -Enabled null `
 -Action null `
 -AssociatedHubSiteId null `
 -AssociatedHubSiteTitle null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

