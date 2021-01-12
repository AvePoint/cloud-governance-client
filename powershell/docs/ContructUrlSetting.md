# ContructUrlSetting
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
$ContructUrlSetting = New-Cloud.Governance.ClientContructUrlSetting  -Rules null `
 -Suffix null `
 -Connection null `
 -ContructUrlAssignBy null
```

- Convert the resource to JSON
```powershell
$ContructUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

