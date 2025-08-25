# AutoGenerateUrlSettingRandomStringSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **String** |  | [optional] 
**MaxLength** | **Int32** |  | [optional] [default to 0]
**MinLength** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$AutoGenerateUrlSettingRandomStringSettings = New-Cloud.Governance.ClientAutoGenerateUrlSettingRandomStringSettings  -Prefix null `
 -MaxLength null `
 -MinLength null
```

- Convert the resource to JSON
```powershell
$AutoGenerateUrlSettingRandomStringSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

