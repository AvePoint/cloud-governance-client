# CreateListUrlSettingsContructUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | **String[]** |  | [optional] 
**Suffix** | **String** |  | [optional] 
**Connection** | **String** |  | [optional] 
**ContructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListUrlSettingsContructUrlSetting = New-Cloud.Governance.ClientCreateListUrlSettingsContructUrlSetting  -Rules null `
 -Suffix null `
 -Connection null `
 -ContructUrlAssignBy null
```

- Convert the resource to JSON
```powershell
$CreateListUrlSettingsContructUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

