# AllRequestList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**ServiceName** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**TicketNumber** | **Int32** |  | [optional] [default to 0]
**Summary** | **String** |  | [optional] 
**Requester** | **String** |  | [optional] 
**RequesterDisplayName** | **String** |  | [optional] 
**DetailStatus** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] 
**DetailStatusDescription** | **String** |  | [optional] 
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] 
**ProgressStatusDescription** | **String** |  | [optional] 
**Modified** | **System.DateTime** |  | [optional] 
**AssignTo** | **String** |  | [optional] 
**AssignToDisplayName** | **String** |  | [optional] 
**ServiceAdmin** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**CreatedTime** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AllRequestList = New-Cloud.Governance.ClientAllRequestList  -Id null `
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

- Convert the resource to JSON
```powershell
$AllRequestList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

