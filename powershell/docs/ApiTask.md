# ApiTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperties** | [**ApiTaskDynamicProperties**](ApiTaskDynamicProperties.md) |  | [optional] 
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RequestGuid** | **String** |  | [optional] 
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**Comments** | **String** |  | [optional] 
**AllComments** | [**TaskComment[]**](TaskComment.md) |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**LastModifiedTime** | **System.DateTime** |  | [optional] 
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] 
**AllowReassign** | **Boolean** |  | [optional] [default to $false]
**Assignee** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**AllowEdit** | **Boolean** |  | [optional] [default to $false]
**RequestTicketNumber** | **Int32** |  | [optional] [default to 0]
**DueDate** | **System.DateTime** |  | [optional] 
**TaskFullPath** | **String** |  | [optional] 
**DynamicActions** | [**TaskDynamicActions[]**](TaskDynamicActions.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiTask = New-Cloud.Governance.ClientApiTask  -DynamicProperties null `
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
 -Assignee null `
 -AllowEdit null `
 -RequestTicketNumber null `
 -DueDate null `
 -TaskFullPath null `
 -DynamicActions null
```

- Convert the resource to JSON
```powershell
$ApiTask | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

