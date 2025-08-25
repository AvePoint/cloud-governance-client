# ChangePrivateChannelRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Team** | [**ChangePrivateChannelRequestTeam**](ChangePrivateChannelRequestTeam.md) |  | [optional] 
**Channel** | [**ChangePrivateChannelRequestChannel**](ChangePrivateChannelRequestChannel.md) |  | [optional] 
**Name** | [**ChangePrivateChannelRequestName**](ChangePrivateChannelRequestName.md) |  | [optional] 
**ChannelDescription** | [**ChangePrivateChannelRequestChannelDescription**](ChangePrivateChannelRequestChannelDescription.md) |  | [optional] 
**Owners** | [**ChangePrivateChannelRequestOwners**](ChangePrivateChannelRequestOwners.md) |  | [optional] 
**Members** | [**ChangePrivateChannelRequestMembers**](ChangePrivateChannelRequestMembers.md) |  | [optional] 
**EnableChangePrivateChannelQuota** | **Boolean** |  | [optional] [default to $false]
**QuotaStorage** | [**ChangePrivateChannelRequestQuotaStorage**](ChangePrivateChannelRequestQuotaStorage.md) |  | [optional] 
**QuotaStorageUsed** | **Double** |  | [optional] 
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
**QuestionnaireResponse** | [**QuestionAnswerResponse[]**](QuestionAnswerResponse.md) | Questionnaire question and answer of request. | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) | Metadata of request. | [optional] 
**TicketNumber** | **Int32** | Ticket number of request. | [optional] [readonly] [default to 0]
**Type** | [**ServiceType**](ServiceType.md) | Service type of request. | [optional] [readonly] 
**TypeDescription** | **String** | Service type description of request. | [optional] [readonly] 
**Requester** | **String** | Requester display name. | [optional] [readonly] 
**RequesterLoginName** | **String** | Requester login name. | [optional] [readonly] 
**Status** | [**RequestStatus**](RequestStatus.md) | Status of request. | [optional] [readonly] 
**ProgressStatus** | **Int32** | Progress status of request. | [optional] [readonly] [default to 0]
**ProgressStatusDescription** | **String** | Progress status description of request. | [optional] [readonly] 
**SubmittedTime** | **System.DateTime** | Submitted time of request. | [optional] [readonly] 
**LastUpdated** | **System.DateTime** | Last updated time of request. | [optional] [readonly] 
**CreatedTime** | **System.DateTime** | Created time of request. | [optional] [readonly] 
**HasSubRequest** | **Boolean** | HasSubRequest | [optional] [default to $false]
**IsEnabledPassback** | **Boolean** |  | [optional] [default to $false]
**RequestResourceType** | [**RequestResourceType**](RequestResourceType.md) | RequestResourceType | [optional] 
**ModifiedBy** | **String** | ModifiedBy | [optional] 
**ModifiedByDisplayName** | **String** | ModifiedByDisplayName | [optional] 
**ModifiedDate** | **System.DateTime** | ModifiedDate | [optional] 
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 
**ApprovalStageName** | **String** | Approval stage name of request. | [optional] [readonly] 
**Participants** | **String** | Participants of request. | [optional] [readonly] 
**ObjectID** | **String** | Object full path/email/private channel of request. | [optional] [readonly] 
**CreatedSource** | **Int32** |  | [optional] [readonly] [default to 0]
**SubRequestType** | [**SubRequestType**](SubRequestType.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelRequest = New-Cloud.Governance.ClientChangePrivateChannelRequest  -Team null `
 -Channel null `
 -Name null `
 -ChannelDescription null `
 -Owners null `
 -Members null `
 -EnableChangePrivateChannelQuota null `
 -QuotaStorage null `
 -QuotaStorageUsed null `
 -Id null `
 -ServiceId null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -QuestionnaireResponse null `
 -Metadatas null `
 -TicketNumber null `
 -Type null `
 -TypeDescription null `
 -Requester null `
 -RequesterLoginName null `
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -HasSubRequest null `
 -IsEnabledPassback null `
 -RequestResourceType null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null `
 -AssignTo null `
 -FullPath null `
 -ApprovalStageName null `
 -Participants null `
 -ObjectID null `
 -CreatedSource null `
 -SubRequestType null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

