# ChangeSiteHubSiteRequestModelChangeHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewValue** | [**ChangeHubSiteContentModelChangedValueRequestModelNewValue**](ChangeHubSiteContentModelChangedValueRequestModelNewValue.md) |  | [optional] 
**OriginalValue** | [**ChangeHubSiteContentModelChangedValueRequestModelNewValue**](ChangeHubSiteContentModelChangedValueRequestModelNewValue.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteHubSiteRequestModelChangeHubSite = New-Cloud.Governance.ClientChangeSiteHubSiteRequestModelChangeHubSite  -NewValue null `
 -OriginalValue null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteHubSiteRequestModelChangeHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

