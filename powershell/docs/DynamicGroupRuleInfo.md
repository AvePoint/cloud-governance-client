# DynamicGroupRuleInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Order** | **Int32** |  | [optional] [default to null]
**Relation** | [**LogicalOperator**](LogicalOperator.md) |  | [optional] [default to null]
**Category** | [**CategoryType**](CategoryType.md) |  | [optional] [default to null]
**MetadataId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**MetadataName** | **String** |  | [optional] [default to null]
**MetadataValue** | **String** |  | [optional] [default to null]
**MetadataDisplayValue** | **String** |  | [optional] [default to null]
**Condition** | [**DynamicRuleCondition**](DynamicRuleCondition.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDynamicGroupRuleInfo  -Id null `
 -Order null `
 -Relation null `
 -Category null `
 -MetadataId null `
 -MetadataName null `
 -MetadataValue null `
 -MetadataDisplayValue null `
 -Condition null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

