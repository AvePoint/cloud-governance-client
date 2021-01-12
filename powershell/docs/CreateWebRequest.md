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
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) |  | [optional] 
**IsOnQuickLaunch** | **Boolean** |  | [optional] 
**IsOnTopLinkBar** | **Boolean** |  | [optional] 
**IsInheritance** | **Boolean** |  | [optional] 
**DeploymentManagerPlanName** | **String** |  | [optional] 
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
$CreateWebRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

