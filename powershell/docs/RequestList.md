# RequestList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**ServiceName** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**Category** | **String** |  | [optional] 
**CategoryName** | **String** |  | [optional] 
**ApprovalStageName** | **String** |  | [optional] 
**Participants** | **String** |  | [optional] 
**ParticipantDisplayName** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectID** | **String** |  | [optional] 
**HasSubRequest** | **Boolean** |  | [optional] [default to $false]
**ModifiedBy** | **String** |  | [optional] 
**ModifiedByDisplayName** | **String** |  | [optional] 
**ModifiedDate** | **System.DateTime** |  | [optional] 
**TicketNumber** | **Int32** |  | [optional] [default to 0]
**Summary** | **String** |  | [optional] 
**Status** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] 
**ProcessStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Modified** | **System.DateTime** |  | [optional] 
**SubmitStatus** | **Int32** |  | [optional] [default to 0]
**Assigned** | **String** |  | [optional] 
**AssignedLoginName** | **String** |  | [optional] 
**ServiceAdmin** | **String** |  | [optional] 
**EnabledCopy** | **Boolean** |  | [optional] [default to $false]
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] 
**QuestionnaireId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestList = New-Cloud.Governance.ClientRequestList  -Id null `
 -ServiceId null `
 -ServiceName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -Category null `
 -CategoryName null `
 -ApprovalStageName null `
 -Participants null `
 -ParticipantDisplayName null `
 -ObjectUrl null `
 -ObjectID null `
 -HasSubRequest null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null `
 -TicketNumber null `
 -Summary null `
 -Status null `
 -ProcessStatus null `
 -StatusDescription null `
 -Modified null `
 -SubmitStatus null `
 -Assigned null `
 -AssignedLoginName null `
 -ServiceAdmin null `
 -EnabledCopy null `
 -Metadata null `
 -QuestionnaireId null
```

- Convert the resource to JSON
```powershell
$RequestList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

