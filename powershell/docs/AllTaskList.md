# AllTaskList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comments** | **String** |  | [optional] [default to null]
**TaskStatus** | [**TaskResult**](TaskResult.md) |  | [optional] [default to null]
**TaskStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceName** | **String** |  | [optional] [default to null]
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**ServiceTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**TicketNumber** | **Int32** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**Requester** | **String** |  | [optional] [default to null]
**RequesterDisplayName** | **String** |  | [optional] [default to null]
**DetailStatus** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] [default to null]
**DetailStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Modified** | **System.DateTime** |  | [optional] [default to null]
**AssignTo** | **String** |  | [optional] [default to null]
**AssignToDisplayName** | **String** |  | [optional] [default to null]
**ServiceAdmin** | **String** |  | [optional] [default to null]
**ObjectUrl** | **String** |  | [optional] [default to null]
**CreatedTime** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAllTaskList  -Comments null `
 -TaskStatus null `
 -TaskStatusDescription null `
 -Id null `
 -ServiceId null `
 -ServiceName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -TicketNumber null `
 -Summary null `
 -Requester null `
 -RequesterDisplayName null `
 -DetailStatus null `
 -DetailStatusDescription null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -Modified null `
 -AssignTo null `
 -AssignToDisplayName null `
 -ServiceAdmin null `
 -ObjectUrl null `
 -CreatedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

