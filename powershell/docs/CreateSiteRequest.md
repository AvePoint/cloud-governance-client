# CreateSiteRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteTitle** | **String** |  | [optional] [default to null]
**SiteDescription** | **String** |  | [optional] [default to null]
**SiteUrl** | [**SiteUrl**](SiteUrl.md) |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**TimeZone** | **Int32** |  | [optional] [default to null]
**Language** | **Int32** |  | [optional] [default to null]
**Template** | **String** |  | [optional] [default to null]
**DeploymentManagerPlanName** | **String** |  | [optional] [default to null]
**PrimaryAdmin** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**AdditionalAdmins** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**IsShownClassificationAndDesing** | **Boolean** |  | [optional] [readonly] [default to null]
**SiteDesign** | [**StringModel**](StringModel.md) |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**IsShownHubsiteSettings** | **Boolean** |  | [optional] [readonly] [default to null]
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] [default to null]
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] [default to null]
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] [default to null]
**YammerGroupSettings** | [**YammerGroupRequestSettings**](YammerGroupRequestSettings.md) |  | [optional] [default to null]
**LeasePeriodSettings** | [**SiteLeasePeriodRequestSettings**](SiteLeasePeriodRequestSettings.md) |  | [optional] [default to null]
**MultiGeoLocation** | [**GeoLocationBase**](GeoLocationBase.md) |  | [optional] [default to null]
**InputTitle** | **String** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**NotesToApprovers** | **String** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**TicketNumber** | **Int32** |  | [optional] [readonly] [default to null]
**Type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Requester** | **String** |  | [optional] [readonly] [default to null]
**Status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] [default to null]
**ProgressStatus** | **Int32** |  | [optional] [readonly] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**AssignTo** | **String** |  | [optional] [readonly] [default to null]
**FullPath** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateSiteRequest  -SiteTitle null `
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
 -IsShownClassificationAndDesing null `
 -SiteDesign null `
 -Classification null `
 -IsShownHubsiteSettings null `
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
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

