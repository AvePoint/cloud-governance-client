# CreateWebRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebName** | **String** |  | [optional] 
**WebTitle** | **String** |  | [optional] 
**WebDescription** | **String** |  | [optional] 
**WebLanguage** | [**IntModel**](IntModel.md) |  | [optional] 
**WebTemplate** | **String** |  | [optional] 
**ParentSiteUrl** | **String** |  | [optional] 
**ParentWebUrl** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) | Yammer community request settings model | [optional] 
**IsOnQuickLaunch** | **Boolean** |  | [optional] [default to $false]
**IsOnTopLinkBar** | **Boolean** |  | [optional] [default to $false]
**IsInheritance** | **Boolean** |  | [optional] [default to $false]
**DeploymentManagerPlanName** | **String** |  | [optional] 
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
**AssignTo** | **String** | Task assignee of request. | [optional] [readonly] 
**FullPath** | **String** | Object full path of request. | [optional] [readonly] 
**ApprovalStageName** | **String** | Approval stage name of request. | [optional] [readonly] 
**Participants** | **String** | Participants of request. | [optional] [readonly] 
**ObjectID** | **String** | Object full path/email/private channel of request. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$CreateWebRequest = New-Cloud.Governance.ClientCreateWebRequest  -WebName null `
 -WebTitle null `
 -WebDescription null `
 -WebLanguage null `
 -WebTemplate null `
 -ParentSiteUrl null `
 -ParentWebUrl null `
 -PrimaryContact null `
 -SecondaryContact null `
 -UserPermissions null `
 -GroupPermissions null `
 -YammerGroupSettings null `
 -IsOnQuickLaunch null `
 -IsOnTopLinkBar null `
 -IsInheritance null `
 -DeploymentManagerPlanName null `
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
 -AssignTo null `
 -FullPath null `
 -ApprovalStageName null `
 -Participants null `
 -ObjectID null
```

- Convert the resource to JSON
```powershell
$CreateWebRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

