# SiteTitleConstructureRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**SiteConstructTitleType**](SiteConstructTitleType.md) |  | [optional] 
**Value** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteTitleConstructureRule = New-Cloud.Governance.ClientSiteTitleConstructureRule  -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$SiteTitleConstructureRule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

