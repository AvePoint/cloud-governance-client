# ChoiceMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Choices** | **String[]** |  | [optional] 
**Value** | **String[]** |  | [optional] 
**ChoiceType** | [**ChoiceType**](ChoiceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChoiceMetadataSettings = New-Cloud.Governance.ClientChoiceMetadataSettings  -Choices null `
 -Value null `
 -ChoiceType null
```

- Convert the resource to JSON
```powershell
$ChoiceMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

