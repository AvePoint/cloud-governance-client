# DynamicGroupRuleInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Order** | **Int32** |  | [optional] [default to 0]
**Relation** | [**LogicalOperator**](LogicalOperator.md) |  | [optional] 
**Category** | [**CategoryType**](CategoryType.md) |  | [optional] 
**MetadataId** | **String** |  | [optional] 
**MetadataName** | **String** |  | [optional] 
**MetadataValue** | **String** |  | [optional] 
**MetadataDisplayValue** | **String** |  | [optional] 
**MetadataValueAzureUserType** | **String** |  | [optional] 
**Condition** | [**DynamicRuleCondition**](DynamicRuleCondition.md) |  | [optional] 
**DisableEditRule** | **Boolean** |  | [optional] [default to $false]
**DisableEditRuleValue** | **Boolean** |  | [optional] [default to $false]
**MetadataUserList** | [**UserInfo[]**](UserInfo.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicGroupRuleInfo = New-Cloud.Governance.ClientDynamicGroupRuleInfo  -Id null `
 -Order null `
 -Relation null `
 -Category null `
 -MetadataId null `
 -MetadataName null `
 -MetadataValue null `
 -MetadataDisplayValue null `
 -MetadataValueAzureUserType null `
 -Condition null `
 -DisableEditRule null `
 -DisableEditRuleValue null `
 -MetadataUserList null
```

- Convert the resource to JSON
```powershell
$DynamicGroupRuleInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

