# CreateSiteRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitle** | **String** |  | [optional] 
**SiteDescription** | **String** |  | [optional] 
**SiteUrl** | [**SiteUrl**](SiteUrl.md) |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**TimeZone** | **Int32** |  | [optional] 
**Language** | **Int32** |  | [optional] 
**Template** | **String** |  | [optional] 
**DeploymentManagerPlanName** | **String** |  | [optional] 
**PrimaryAdmin** | [**ApiUser**](ApiUser.md) |  | [optional] 
**AdditionalAdmins** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SiteDesign** | [**StringModel**](StringModel.md) |  | [optional] 
**TeamSiteDesign** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] 
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) |  | [optional] 
**LeasePeriodSettings** | [**SiteLeasePeriodRequestSettings**](SiteLeasePeriodRequestSettings.md) |  | [optional] 
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] 
**InputTitle** | **String** |  | [optional] 
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
 -HubSiteSettings null `
 -UserPermissions null `
 -GroupPermissions null `
 -YammerGroupSettings null `
 -LeasePeriodSettings null `
 -MultiGeoLocation null `
 -InputTitle null `
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
$CreateSiteRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

