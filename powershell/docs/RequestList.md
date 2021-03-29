# RequestList
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
**Status** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] 
**ProcessStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Modified** | **System.DateTime** |  | [optional] 
**SubmitStatus** | **Int32** |  | [optional] [default to 0]
**Assigned** | **String** |  | [optional] 
**ServiceAdmin** | **String** |  | [optional] 
**EnabledCopy** | **Boolean** |  | [optional] [default to $false]
**QuestionnaireId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestList = New-Cloud.Governance.ClientRequestList  -Id null `
 -ServiceId null `
 -ServiceName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -TicketNumber null `
 -Summary null `
 -Status null `
 -ProcessStatus null `
 -StatusDescription null `
 -Modified null `
 -SubmitStatus null `
 -Assigned null `
 -ServiceAdmin null `
 -EnabledCopy null `
 -QuestionnaireId null
```

- Convert the resource to JSON
```powershell
$RequestList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

