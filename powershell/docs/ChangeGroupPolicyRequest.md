# ChangeGroupPolicyRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**OriginalPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] [readonly] 
**IsLeaseEnabled** | **Boolean** | Whether to enable the group/team lease extension. | [optional] [default to $false]
**ChangePolicyConfig** | [**AssignBy**](AssignBy.md) | Set how to assign the group policy. | [optional] 
**StartDateType** | [**StartDateType**](StartDateType.md) | Group lease start date configuration after a policy change | [optional] 
**SpecifyStartDate** | **System.DateTime** | New lease start date | [optional] 
**GroupId** | **String** | Object ID | [optional] 
**GroupName** | **String** | Group name | [optional] [readonly] 
**GroupEmail** | **String** | Group e-mail address | [optional] [readonly] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) | Group type | [optional] 
**Id** | **String** | Id of request. | [optional] 
**ServiceId** | **String** | Id of service. | [optional] 
**Summary** | **String** | Summary of request. | [optional] 
**NotesToApprovers** | **String** | Notes to approvers. | [optional] 
**QuestionnaireId** | **String** | Id of questionnaire | [optional] 
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
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupPolicyRequest = New-Cloud.Governance.ClientChangeGroupPolicyRequest  -Policy null `
 -OriginalPolicy null `
 -IsLeaseEnabled null `
 -ChangePolicyConfig null `
 -StartDateType null `
 -SpecifyStartDate null `
 -GroupId null `
 -GroupName null `
 -GroupEmail null `
 -GroupObjectType null `
 -Id null `
 -ServiceId null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
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
 -AssignTo null `
 -FullPath null
```

- Convert the resource to JSON
```powershell
$ChangeGroupPolicyRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

