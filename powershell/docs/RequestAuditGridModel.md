# RequestAuditGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**TicketNumber** | **Int32** |  | [optional] [default to null]
**RequestSummary** | **String** |  | [optional] [default to null]
**Requester** | **String** |  | [optional] [default to null]
**RequesterDisplayName** | **String** |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**SubmittedTime** | **System.DateTime** |  | [optional] [default to null]
**ProgressStatusDetail** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] [default to null]
**ProgressStatusDetailDescription** | **String** |  | [optional] [readonly] [default to null]
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**AssignTo** | **String** |  | [optional] [default to null]
**AssignToDisplayName** | **String** |  | [optional] [default to null]
**LastUpdated** | **System.DateTime** |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceType** | **Int32** |  | [optional] [default to null]
**ServiceName** | **String** |  | [optional] [default to null]
**CreatedTime** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestAuditGridModel  -RequestId null `
 -TicketNumber null `
 -RequestSummary null `
 -Requester null `
 -RequesterDisplayName null `
 -Department null `
 -Description null `
 -SubmittedTime null `
 -ProgressStatusDetail null `
 -ProgressStatusDetailDescription null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -AssignTo null `
 -AssignToDisplayName null `
 -LastUpdated null `
 -ServiceId null `
 -ServiceType null `
 -ServiceName null `
 -CreatedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

