# CreateSiteRequestSiteUrl
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Root** | **String** | Site collection root site url | [optional] 
**ManagedPath** | **String** | Managed path | [optional] 
**Name** | **String** | Site collection name | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteRequestSiteUrl = New-Cloud.Governance.ClientCreateSiteRequestSiteUrl  -Root null `
 -ManagedPath null `
 -Name null
```

- Convert the resource to JSON
```powershell
$CreateSiteRequestSiteUrl | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

