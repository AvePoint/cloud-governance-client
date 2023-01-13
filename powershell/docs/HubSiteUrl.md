# HubSiteUrl
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **String** |  | [optional] 
**PermissionGroupCount** | **Int32** |  | [optional] [default to 0]
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HubSiteUrl = New-Cloud.Governance.ClientHubSiteUrl  -Url null `
 -PermissionGroupCount null `
 -Id null `
 -Title null
```

- Convert the resource to JSON
```powershell
$HubSiteUrl | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

