# CreateSiteRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitle** | **String** | Site collection title | [optional] 
**SiteDescription** | **String** | Site collection description | [optional] 
**SiteUrl** | [**SiteUrl**](SiteUrl.md) | Site collection url information | [optional] 
**PolicyId** | **String** | Site collection policy id, you can use GetCreateSiteService api to get all the available policy ids and names. | [optional] 
**TimeZone** | **Int32** | Site collection time zone id, you can use GetCreateSiteService api to get all the available time zone ids and names. | [optional] [default to 0]
**Language** | **Int32** | Site collection language id, you can use GetCreateSiteService api to get all the available language ids and names. | [optional] [default to 0]
**Template** | **String** | Site collection template id, you can use GetCreateSiteService api to get all the available template ids and names. | [optional] 
**DeploymentManagerPlanName** | **String** | Deployment manager plan name, you can use GetCreateSiteService api to get all the available deployment manager plan names. | [optional] 
**PrimaryAdmin** | [**ApiUser**](ApiUser.md) | Primary site collection administrator | [optional] 
**AdditionalAdmins** | [**ApiUser[]**](ApiUser.md) | Additional site collection administrator | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | Primary site collection contact | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | Secondary site collection contact | [optional] 
**SiteDesign** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**TeamSiteDesign** | **String** | Team site design | [optional] 
**Classification** | **String** | Communication site Classification | [optional] 
**Sensitivity** | **String** | Sensitive lable | [optional] 
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) | Hub site setting | [optional] 
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) | Granted user/group permission setting | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) | Site collection SharePoint group setting | [optional] 
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) | Yammer group setting | [optional] 
**LeasePeriodSettings** | [**SiteLeasePeriodRequestSettings**](SiteLeasePeriodRequestSettings.md) | Lease period setting | [optional] 
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) | Multi-geo location | [optional] 
**InputTitle** | **String** | Site collection title without prefix and sufix when service enables constructing title | [optional] 
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
$CreateSiteRequest = New-Cloud.Governance.ClientCreateSiteRequest  -SiteTitle null `
 -SiteDescription null `
 -SiteUrl null `
 -PolicyId null `
 -TimeZone null `
 -Language null `
 -Template null `
 -DeploymentManagerPlanName null `
 -PrimaryAdmin null `
 -AdditionalAdmins null `
 -PrimaryContact null `
 -SecondaryContact null `
 -SiteDesign null `
 -TeamSiteDesign null `
 -Classification null `
 -Sensitivity null `
 -HubSiteSettings null `
 -UserPermissions null `
 -GroupPermissions null `
 -YammerGroupSettings null `
 -LeasePeriodSettings null `
 -MultiGeoLocation null `
 -InputTitle null `
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
$CreateSiteRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

