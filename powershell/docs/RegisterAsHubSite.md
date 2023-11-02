# RegisterAsHubSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnabledUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**HubSiteName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RegisterAsHubSite = New-Cloud.Governance.ClientRegisterAsHubSite  -EnabledUsers null `
 -HubSiteName null
```

- Convert the resource to JSON
```powershell
$RegisterAsHubSite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

