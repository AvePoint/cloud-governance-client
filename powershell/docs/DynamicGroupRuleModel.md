# DynamicGroupRuleModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Order** | **Int32** |  | [optional] [default to 0]
**Relation** | [**LogicalOperator**](LogicalOperator.md) |  | [optional] 
**RelationDescription** | **String** |  | [optional] 
**Category** | [**CategoryType**](CategoryType.md) |  | [optional] 
**CategoryDescription** | **String** |  | [optional] 
**MetadataName** | **String** |  | [optional] 
**MetadataDisplayValue** | **String** |  | [optional] 
**Condition** | [**DynamicRuleCondition**](DynamicRuleCondition.md) |  | [optional] 
**ConditionDescription** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicGroupRuleModel = New-Cloud.Governance.ClientDynamicGroupRuleModel  -Id null `
 -Order null `
 -Relation null `
 -RelationDescription null `
 -Category null `
 -CategoryDescription null `
 -MetadataName null `
 -MetadataDisplayValue null `
 -Condition null `
 -ConditionDescription null
```

- Convert the resource to JSON
```powershell
$DynamicGroupRuleModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

