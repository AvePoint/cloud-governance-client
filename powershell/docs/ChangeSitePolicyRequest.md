# ChangeSitePolicyRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | [**GuidModel**](GuidModel.md) |  | [optional] 
**OriginalPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] 
**IsLeaseEnabled** | **Boolean** |  | [optional] 
**ChangePolicyConfig** | [**AssignBy**](AssignBy.md) |  | [optional] 
**StartDateType** | [**StartDateType**](StartDateType.md) |  | [optional] 
**SpecifyStartDate** | **System.DateTime** |  | [optional] 
**Action** | [**SiteLifecycleActionType**](SiteLifecycleActionType.md) |  | [optional] 
**ActionDescription** | **String** |  | [optional] [readonly] 
**SiteId** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**Department** | **String** |  | [optional] 
**Summary** | **String** |  | [optional] 
**NotesToApprovers** | **String** |  | [optional] 
**QuestionnaireId** | **String** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**TicketNumber** | **Int32** |  | [optional] [readonly] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] [readonly] 
**TypeDescription** | **String** |  | [optional] [readonly] 
**Requester** | **String** |  | [optional] [readonly] 
**RequesterLoginName** | **String** |  | [optional] [readonly] 
**Status** | [**RequestStatus**](RequestStatus.md) |  | [optional] [readonly] 
**ProgressStatus** | **Int32** |  | [optional] [readonly] 
**ProgressStatusDescription** | **String** |  | [optional] [readonly] 
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] 
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] 
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] 
**AssignTo** | **String** |  | [optional] [readonly] 
**FullPath** | **String** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangeSitePolicyRequest = New-Cloud.Governance.ClientChangeSitePolicyRequest  -Policy null `
 -OriginalPolicy null `
 -IsLeaseEnabled null `
 -ChangePolicyConfig null `
 -StartDateType null `
 -SpecifyStartDate null `
 -Action null `
 -ActionDescription null `
 -SiteId null `
 -SiteUrl null `
 -Id null `
 -ServiceId null `
 -Department null `
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
$ChangeSitePolicyRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

