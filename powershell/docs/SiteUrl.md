# SiteUrl
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Root** | **String** | Site collection root site url | [optional] 
**ManagedPath** | **String** | Managed path | [optional] 
**Name** | **String** | Site collection name | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteUrl = New-Cloud.Governance.ClientSiteUrl  -Root null `
 -ManagedPath null `
 -Name null
```

- Convert the resource to JSON
```powershell
$SiteUrl | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

