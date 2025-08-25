# CreateGroupServiceGroupIdConstructureSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleType** | [**GroupIdRuleType**](GroupIdRuleType.md) |  | [optional] 
**EnableAutoSequenceNumber** | **Boolean** |  | [optional] [default to $false]
**AutoSequenceNumber** | **String** |  | [optional] 
**Enabled** | **Boolean** |  | [optional] [default to $false]
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Prefixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 
**Suffixs** | [**GroupConstructureRule[]**](GroupConstructureRule.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGroupServiceGroupIdConstructureSettings = New-Cloud.Governance.ClientCreateGroupServiceGroupIdConstructureSettings  -RuleType null `
 -EnableAutoSequenceNumber null `
 -AutoSequenceNumber null `
 -Enabled null `
 -AssignBy null `
 -Prefixs null `
 -Suffixs null
```

- Convert the resource to JSON
```powershell
$CreateGroupServiceGroupIdConstructureSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

