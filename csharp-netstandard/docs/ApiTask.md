# Cloud.Governance.Client.Model.ApiTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperties** | [**ApiTaskDynamicProperties**](ApiTaskDynamicProperties.md) |  | [optional] 
**Id** | **Guid** |  | [optional] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**RequestGuid** | **Guid** |  | [optional] 
**Status** | **TaskResult** |  | [optional] 
**StatusDescription** | **string** |  | [optional] 
**ServiceType** | **ServiceType** |  | [optional] 
**ServiceTypeDescription** | **string** |  | [optional] 
**Comments** | **string** |  | [optional] 
**AllComments** | [**List&lt;TaskComment&gt;**](TaskComment.md) |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**LastModifiedTime** | **DateTime** |  | [optional] 
**TaskType** | **TaskType** |  | [optional] 
**AllowReassign** | **bool** |  | [optional] [default to false]
**Assignee** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**AllowEdit** | **bool** |  | [optional] [default to false]
**RequestTicketNumber** | **int** |  | [optional] [default to 0]
**DueDate** | **DateTime** |  | [optional] 
**TaskFullPath** | **string** |  | [optional] 
**AppId** | **string** |  | [optional] 
**DynamicActions** | [**List&lt;TaskDynamicActions&gt;**](TaskDynamicActions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

