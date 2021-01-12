# CreateWebService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeSettings** | [**CreateWebScopeSettings**](CreateWebScopeSettings.md) |  | [optional] 
**WebLanguages** | [**IntModel[]**](IntModel.md) |  | [optional] 
**LanguageIdsAndTemplates** | [**LanguageWithTemplates[]**](LanguageWithTemplates.md) |  | [optional] 
**TemplateIdsAndPermissions** | [**TemplateWithPermissions[]**](TemplateWithPermissions.md) |  | [optional] 
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] 
**UseUniquePermissions** | **Boolean** |  | [optional] 
**DeploymentManagerPlanSettings** | [**DeploymentManagerPlanSettings**](DeploymentManagerPlanSettings.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupServiceSettings**](YammerGroupServiceSettings.md) |  | [optional] 
**TemplateStoreUrl** | **String** |  | [optional] 
**AppSettings** | [**AppSettings**](AppSettings.md) |  | [optional] 
**NotifyPrimaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] 
**NotifySecondaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] 
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**IsOnQuickLaunch** | **Boolean** |  | [optional] 
**IsOnTopLinkBar** | **Boolean** |  | [optional] 
**IsNavigationInheritance** | **Boolean** |  | [optional] 
**DefaultWebLanguage** | **Int32** |  | [optional] 
**ScopeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**WebLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationInheritanceAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateWebRequest**](CreateWebRequest.md) |  | [optional] 
**DepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] 
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**Department** | **String** |  | [optional] 
**LoadDepartmentFromUps** | **Boolean** |  | [optional] 
**Departments** | **String[]** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] 
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] 
**CategoryId** | **String** |  | [optional] 
**Details** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateWebService = New-Cloud.Governance.ClientCreateWebService  -ScopeSettings null `
 -WebLanguages null `
 -LanguageIdsAndTemplates null `
 -TemplateIdsAndPermissions null `
 -PermissionSettings null `
 -UseUniquePermissions null `
 -DeploymentManagerPlanSettings null `
 -YammerGroupSettings null `
 -TemplateStoreUrl null `
 -AppSettings null `
 -NotifyPrimaryContactSettings null `
 -NotifySecondaryContactSettings null `
 -DefaultPrimaryContact null `
 -DefaultSecondaryContact null `
 -IsOnQuickLaunch null `
 -IsOnTopLinkBar null `
 -IsNavigationInheritance null `
 -DefaultWebLanguage null `
 -ScopeAssignBy null `
 -WebLanguageAssignBy null `
 -TemplateAssignBy null `
 -NavigationInheritanceAssignBy null `
 -NavigationAssignBy null `
 -PrimaryContactAssignBy null `
 -SecondaryContactAssignBy null `
 -PermissionAssignBy null `
 -RequestTemplate null `
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
 -CategoryId null `
 -Details null
```

- Convert the resource to JSON
```powershell
$CreateWebService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

