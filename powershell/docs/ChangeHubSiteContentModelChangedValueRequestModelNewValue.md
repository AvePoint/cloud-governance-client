# ChangeHubSiteContentModelChangedValueRequestModelNewValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnabledUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**HubSiteTitle** | **String** |  | [optional] 
**HubSiteId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeHubSiteContentModelChangedValueRequestModelNewValue = New-Cloud.Governance.ClientChangeHubSiteContentModelChangedValueRequestModelNewValue  -EnabledUsers null `
 -HubSiteTitle null `
 -HubSiteId null
```

- Convert the resource to JSON
```powershell
$ChangeHubSiteContentModelChangedValueRequestModelNewValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

