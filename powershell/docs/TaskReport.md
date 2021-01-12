# TaskReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Requester** | **String** |  | [optional] 
**RequesterLoginName** | **String** |  | [optional] 
**RequesterDisplayName** | **String** |  | [optional] 
**RequestTicketNumber** | **Int32** |  | [optional] 
**DueDate** | **System.DateTime** |  | [optional] 
**DueDateType** | [**DueDateType**](DueDateType.md) |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] 
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**IsApproveTask** | **Boolean** |  | [optional] 
**Assignee** | **String** |  | [optional] 
**AssigneeLoginName** | **String** |  | [optional] 
**AssigneeDisplayName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TaskReport = New-Cloud.Governance.ClientTaskReport  -Id null `
 -Title null `
 -Requester null `
 -RequesterLoginName null `
 -RequesterDisplayName null `
 -RequestTicketNumber null `
 -DueDate null `
 -DueDateType null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -CreatedTime null `
 -TaskType null `
 -Status null `
 -StatusDescription null `
 -IsApproveTask null `
 -Assignee null `
 -AssigneeLoginName null `
 -AssigneeDisplayName null
```

- Convert the resource to JSON
```powershell
$TaskReport | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

