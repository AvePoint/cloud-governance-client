# ListVersionSettingsChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | [**CreateListRequestVersionSettings**](CreateListRequestVersionSettings.md) |  | [optional] 
**OriginalValue** | [**CreateListRequestVersionSettings**](CreateListRequestVersionSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ListVersionSettingsChangedProperty = New-Cloud.Governance.ClientListVersionSettingsChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$ListVersionSettingsChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

