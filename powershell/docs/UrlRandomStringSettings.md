# UrlRandomStringSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **String** |  | [optional] 
**MaxLength** | **Int32** |  | [optional] 
**MinLength** | **Int32** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UrlRandomStringSettings = New-Cloud.Governance.ClientUrlRandomStringSettings  -Prefix null `
 -MaxLength null `
 -MinLength null
```

- Convert the resource to JSON
```powershell
$UrlRandomStringSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

