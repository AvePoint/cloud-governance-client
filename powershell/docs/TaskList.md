# TaskList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Requester** | **String** |  | [optional] 
**RequestTicketNumber** | **Int32** |  | [optional] [default to 0]
**RequesterDisplayName** | **String** |  | [optional] 
**DueDate** | **System.DateTime** |  | [optional] 
**DueDateType** | [**DueDateType**](DueDateType.md) |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] 
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TaskList = New-Cloud.Governance.ClientTaskList  -Id null `
 -Title null `
 -Requester null `
 -RequestTicketNumber null `
 -RequesterDisplayName null `
 -DueDate null `
 -DueDateType null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -CreatedTime null `
 -TaskType null `
 -Status null `
 -StatusDescription null
```

- Convert the resource to JSON
```powershell
$TaskList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

