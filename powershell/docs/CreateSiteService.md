# CreateSiteService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] [default to null]
**AdminCenterUrl** | **String** |  | [optional] [default to null]
**SiteLanguages** | [**IntModel[]**](IntModel.md) |  | [optional] [default to null]
**RootSiteAndManagedPaths** | [**RootSiteWithManagedPaths[]**](RootSiteWithManagedPaths.md) |  | [optional] [default to null]
**SiteUrlSetting** | [**SiteUrlSetting**](SiteUrlSetting.md) |  | [optional] [default to null]
**MultiGeoSetting** | [**MultiGeoSerivceSetting**](MultiGeoSerivceSetting.md) |  | [optional] [default to null]
**SiteTitleSetting** | [**SiteTitleSetting**](SiteTitleSetting.md) |  | [optional] [default to null]
**Policies** | [**PolicyRef[]**](PolicyRef.md) |  | [optional] [default to null]
**DeploymentManagerPlanSettings** | [**DeploymentManagerPlanSettings**](DeploymentManagerPlanSettings.md) |  | [optional] [default to null]
**PolicyIdsAndTemplates** | [**PolicyWithTemplates[]**](PolicyWithTemplates.md) |  | [optional] [default to null]
**TemplateIdsAndPermissions** | [**TemplateWithPermissions[]**](TemplateWithPermissions.md) |  | [optional] [default to null]
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] [default to null]
**LeasePeriodSettings** | [**SiteLeasePeriodServiceSettings**](SiteLeasePeriodServiceSettings.md) |  | [optional] [default to null]
**TimeZones** | [**IntModel[]**](IntModel.md) |  | [optional] [default to null]
**YammerGroupSettings** | [**YammerGroupServiceSettings**](YammerGroupServiceSettings.md) |  | [optional] [default to null]
**Classifications** | **String[]** |  | [optional] [default to null]
**HubSiteSettings** | [**HubSiteSettings**](HubSiteSettings.md) |  | [optional] [default to null]
**EnabledCustomTemplate** | **Boolean** |  | [optional] [default to null]
**CustomSiteTemplateListURL** | **String** |  | [optional] [default to null]
**DefaultPrimaryAdmin** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultAdditionalAdmins** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DefaultPrimaryAdminReal** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultAdditionalAdminsReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultSiteLanguage** | **Int32** |  | [optional] [default to null]
**DefaultRootSite** | **String** |  | [optional] [default to null]
**DefaultManagedPath** | **String** |  | [optional] [default to null]
**DefaultPolicy** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DefaultTemplate** | **String** |  | [optional] [default to null]
**DefaultTimeZone** | **Int32** |  | [optional] [default to null]
**DefaultClassification** | **String** |  | [optional] [default to null]
**DefaultDesignType** | **String** |  | [optional] [default to null]
**SiteLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**TemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**RootSiteAndManagedPathAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**TimeZoneAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PrimaryAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**AdditionalAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**DesignTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ClassificationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**HubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**DepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]
**HideRequestSummary** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**LoadDepartmentFromUps** | **Boolean** |  | [optional] [default to null]
**Departments** | **String[]** |  | [optional] [default to null]
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to null]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] [default to null]
**ApprovalProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LanguageId** | **Int32** |  | [optional] [default to null]
**CategoryId** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCreateSiteService  -ScopeSettings null `
 -AdminCenterUrl null `
 -SiteLanguages null `
 -RootSiteAndManagedPaths null `
 -SiteUrlSetting null `
 -MultiGeoSetting null `
 -SiteTitleSetting null `
 -Policies null `
 -DeploymentManagerPlanSettings null `
 -PolicyIdsAndTemplates null `
 -TemplateIdsAndPermissions null `
 -PermissionSettings null `
 -LeasePeriodSettings null `
 -TimeZones null `
 -YammerGroupSettings null `
 -Classifications null `
 -HubSiteSettings null `
 -EnabledCustomTemplate null `
 -CustomSiteTemplateListURL null `
 -DefaultPrimaryAdmin null `
 -DefaultAdditionalAdmins null `
 -DefaultPrimaryAdminReal null `
 -DefaultAdditionalAdminsReal null `
 -DefaultPrimaryContact null `
 -DefaultSecondaryContact null `
 -DefaultSiteLanguage null `
 -DefaultRootSite null `
 -DefaultManagedPath null `
 -DefaultPolicy null `
 -DefaultTemplate null `
 -DefaultTimeZone null `
 -DefaultClassification null `
 -DefaultDesignType null `
 -SiteLanguageAssignBy null `
 -TemplateAssignBy null `
 -PolicyAssignBy null `
 -PermissionAssignBy null `
 -RootSiteAndManagedPathAssignBy null `
 -TimeZoneAssignBy null `
 -PrimaryAdminAssignBy null `
 -AdditionalAdminAssignBy null `
 -PrimaryContactAssignBy null `
 -SecondaryContactAssignBy null `
 -DesignTypeAssignBy null `
 -ClassificationAssignBy null `
 -HubSiteAssignBy null `
 -DepartmentAssignBy null `
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
 -Department null `
 -LoadDepartmentFromUps null `
 -Departments null `
 -ServiceContact null `
 -ServiceAdminContact null `
 -ApproversContainManagerRole null `
 -Status null `
 -ShowServiceInCatalog null `
 -CustomActions null `
 -ApprovalProcessId null `
 -LanguageId null `
 -CategoryId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

