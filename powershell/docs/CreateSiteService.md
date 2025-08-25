# CreateSiteService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**AdminCenterUrl** | **String** |  | [optional] 
**SiteLanguages** | [**IntModel[]**](IntModel.md) |  | [optional] 
**RootSiteAndManagedPaths** | [**RootSiteWithManagedPaths[]**](RootSiteWithManagedPaths.md) |  | [optional] 
**SiteUrlSetting** | [**CreateSiteServiceSiteUrlSetting**](CreateSiteServiceSiteUrlSetting.md) |  | [optional] 
**MultiGeoSetting** | [**CreateSiteServiceMultiGeoSetting**](CreateSiteServiceMultiGeoSetting.md) |  | [optional] 
**SiteTitleSetting** | [**CreateSiteServiceSiteTitleSetting**](CreateSiteServiceSiteTitleSetting.md) |  | [optional] 
**Policies** | [**SitePolicyRef[]**](SitePolicyRef.md) |  | [optional] 
**DeploymentManagerPlanSettings** | [**CreateSiteServiceDeploymentManagerPlanSettings**](CreateSiteServiceDeploymentManagerPlanSettings.md) |  | [optional] 
**PolicyIdsAndTemplates** | [**PolicyWithTemplates[]**](PolicyWithTemplates.md) |  | [optional] 
**TemplateIdsAndPermissions** | [**TemplateWithPermissions[]**](TemplateWithPermissions.md) |  | [optional] 
**PermissionSettings** | [**CreateListServicePermissionSettings**](CreateListServicePermissionSettings.md) |  | [optional] 
**LeasePeriodSettings** | [**CreateSiteServiceLeasePeriodSettings**](CreateSiteServiceLeasePeriodSettings.md) |  | [optional] 
**TimeZones** | [**IntModel[]**](IntModel.md) |  | [optional] 
**SiteDesigns** | [**StringModel[]**](StringModel.md) |  | [optional] 
**SiteDesign** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**DefaultTeamSiteDesignId** | **String** |  | [optional] 
**SiteDesignAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**YammerGroupSettings** | [**CreateSiteServiceYammerGroupSettings**](CreateSiteServiceYammerGroupSettings.md) |  | [optional] 
**Classifications** | **String[]** |  | [optional] 
**Sensitivities** | [**StringModel[]**](StringModel.md) |  | [optional] 
**AllSensitivities** | [**StringModel[]**](StringModel.md) |  | [optional] 
**HubSiteSettings** | [**CreateGroupServiceHubSiteSettings**](CreateGroupServiceHubSiteSettings.md) |  | [optional] 
**EnabledCustomTemplate** | **Boolean** |  | [optional] [default to $false]
**CustomSiteTemplateListURL** | **String** |  | [optional] 
**DefaultPrimaryAdmin** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultAdditionalAdmins** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultPrimaryAdminReal** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultAdditionalAdminsReal** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**DefaultPrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultSecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**DefaultSiteLanguage** | **Int32** |  | [optional] [default to 0]
**DefaultRootSite** | **String** |  | [optional] 
**DefaultManagedPath** | **String** |  | [optional] 
**DefaultPolicy** | **String** |  | [optional] 
**DefaultTemplate** | **String** |  | [optional] 
**DefaultTimeZone** | **Int32** |  | [optional] [default to 0]
**DefaultClassification** | **String** |  | [optional] 
**DefaultSensitivity** | **String** |  | [optional] 
**DefaultDesignType** | **String** |  | [optional] 
**SiteLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PolicyAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RootSiteAndManagedPathAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TimeZoneAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrimaryAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**AdditionalAdminAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**DesignTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ClassificationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SensitivityAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**HubSiteAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateSiteServiceRequestTemplate**](CreateSiteServiceRequestTemplate.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ServiceAdminContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**ChangeGroupSettingServiceCustomActions**](ChangeGroupSettingServiceCustomActions.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteService = New-Cloud.Governance.ClientCreateSiteService  -ScopeSettings null `
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
 -SiteDesigns null `
 -SiteDesign null `
 -DefaultTeamSiteDesignId null `
 -SiteDesignAssignBy null `
 -YammerGroupSettings null `
 -Classifications null `
 -Sensitivities null `
 -AllSensitivities null `
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
 -DefaultSensitivity null `
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
 -SensitivityAssignBy null `
 -HubSiteAssignBy null `
 -RequestTemplate null `
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
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

- Convert the resource to JSON
```powershell
$CreateSiteService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

