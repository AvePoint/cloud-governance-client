# GroupNameConstructureSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Prefixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 
**Suffixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupNameConstructureSettings = New-Cloud.Governance.ClientGroupNameConstructureSettings  -Enabled null `
 -AssignBy null `
 -Prefixs null `
 -Suffixs null
```

- Convert the resource to JSON
```powershell
$GroupNameConstructureSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

