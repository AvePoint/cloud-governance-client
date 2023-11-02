# DynamicGroupRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Order** | **Int32** |  | [optional] [default to 0]
**Relation** | [**LogicalOperatorType**](LogicalOperatorType.md) |  | [optional] 
**Category** | [**ApiCategoryType**](ApiCategoryType.md) |  | [optional] 
**MetadataId** | **String** |  | [optional] 
**MetadataName** | **String** |  | [optional] 
**MetadataValue** | **String** |  | [optional] 
**DisableEditRule** | **Boolean** |  | [optional] [default to $false]
**DisableEditRuleValue** | **Boolean** |  | [optional] [default to $false]
**MetadataDisplayValue** | **String** |  | [optional] 
**Condition** | [**DynamicRuleConditionType**](DynamicRuleConditionType.md) |  | [optional] 
**MetadataValueAzureUserType** | **String** |  | [optional] 
**MetadataUserList** | [**ApiUser[]**](ApiUser.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicGroupRule = New-Cloud.Governance.ClientDynamicGroupRule  -Id null `
 -Order null `
 -Relation null `
 -Category null `
 -MetadataId null `
 -MetadataName null `
 -MetadataValue null `
 -DisableEditRule null `
 -DisableEditRuleValue null `
 -MetadataDisplayValue null `
 -Condition null `
 -MetadataValueAzureUserType null `
 -MetadataUserList null
```

- Convert the resource to JSON
```powershell
$DynamicGroupRule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

