# PolicyWithTemplates
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyId** | **String** |  | [optional] 
**DefaultTemplate** | **String** |  | [optional] 
**Templates** | [**SiteTemplate[]**](SiteTemplate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyWithTemplates = New-Cloud.Governance.ClientPolicyWithTemplates  -PolicyId null `
 -DefaultTemplate null `
 -Templates null
```

- Convert the resource to JSON
```powershell
$PolicyWithTemplates | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

