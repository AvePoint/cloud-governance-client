# TaskList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Requester** | **String** |  | [optional] [default to null]
**RequestTicketNumber** | **Int32** |  | [optional] [default to null]
**RequesterDisplayName** | **String** |  | [optional] [default to null]
**DueDate** | **System.DateTime** |  | [optional] [default to null]
**DueDateType** | [**DueDateType**](DueDateType.md) |  | [optional] [default to null]
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**ServiceTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] [default to null]
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTaskList  -Id null `
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

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

