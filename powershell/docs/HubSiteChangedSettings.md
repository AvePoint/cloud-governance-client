# HubSiteChangedSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [readonly] [default to null]
**IsModernSite** | **Boolean** |  | [optional] [default to null]
**Action** | [**ChangeHubsiteActionType**](ChangeHubsiteActionType.md) |  | [optional] [default to null]
**AssociatedHubSiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AssociatedHubSiteTitle** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientHubSiteChangedSettings  -Enabled null `
 -IsModernSite null `
 -Action null `
 -AssociatedHubSiteId null `
 -AssociatedHubSiteTitle null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

