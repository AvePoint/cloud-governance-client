# TaskList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Requester** | **String** |  | [optional] 
**RequestId** | **String** |  | [optional] 
**RequestTicketNumber** | **Int32** |  | [optional] [default to 0]
**RequesterDisplayName** | **String** |  | [optional] 
**RequesterEmail** | **String** |  | [optional] 
**DueDate** | **System.DateTime** |  | [optional] 
**DueDateType** | [**DueDateType**](DueDateType.md) |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**TaskType** | [**TaskType**](TaskType.md) |  | [optional] 
**Status** | [**TaskResult**](TaskResult.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**TaskFullPath** | **String** |  | [optional] 
**LastUpdated** | **System.DateTime** |  | [optional] 
**Category** | **String** |  | [optional] 
**CategoryDisplayName** | **String** |  | [optional] 
**ServiceName** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**ProfileId** | **String** |  | [optional] 
**AllowEdit** | **Boolean** |  | [optional] [default to $false]
**ProgressStatus** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] 
**BatchId** | **String** |  | [optional] 
**IsEnabledPassback** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$TaskList = New-Cloud.Governance.ClientTaskList  -Id null `
 -Title null `
 -Requester null `
 -RequestId null `
 -RequestTicketNumber null `
 -RequesterDisplayName null `
 -RequesterEmail null `
 -DueDate null `
 -DueDateType null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -CreatedTime null `
 -TaskType null `
 -Status null `
 -StatusDescription null `
 -TaskFullPath null `
 -LastUpdated null `
 -Category null `
 -CategoryDisplayName null `
 -ServiceName null `
 -ObjectId null `
 -ProfileId null `
 -AllowEdit null `
 -ProgressStatus null `
 -BatchId null `
 -IsEnabledPassback null
```

- Convert the resource to JSON
```powershell
$TaskList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

