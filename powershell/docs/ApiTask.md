# ApiTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperties** | [**ApiTaskDynamicProperties**](ApiTaskDynamicProperties.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**RequestGuid** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**ServiceTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Comments** | **String** |  | [optional] [default to null]
**AllComments** | [**TaskComment[]**](TaskComment.md) |  | [optional] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]
**LastModifiedTime** | **System.DateTime** |  | [optional] [default to null]
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] [default to null]
**AllowReassign** | **Boolean** |  | [optional] [default to null]
**AllowEdit** | **Boolean** |  | [optional] [default to null]
**DynamicActions** | [**TaskDynamicActions[]**](TaskDynamicActions.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApiTask  -DynamicProperties null `
 -Id null `
 -Title null `
 -Description null `
 -RequestGuid null `
 -Status null `
 -StatusDescription null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -Comments null `
 -AllComments null `
 -ErrorMessage null `
 -LastModifiedTime null `
 -TaskType null `
 -AllowReassign null `
 -AllowEdit null `
 -DynamicActions null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

