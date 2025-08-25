# AutoGenerateUrlSettingSequentialNumberingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **String** |  | [optional] 
**Delimiter** | **String** |  | [optional] 
**SequenceNumber** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AutoGenerateUrlSettingSequentialNumberingSettings = New-Cloud.Governance.ClientAutoGenerateUrlSettingSequentialNumberingSettings  -Prefix null `
 -Delimiter null `
 -SequenceNumber null
```

- Convert the resource to JSON
```powershell
$AutoGenerateUrlSettingSequentialNumberingSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

