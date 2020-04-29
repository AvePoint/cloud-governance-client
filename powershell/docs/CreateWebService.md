# CreateWebService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeSettings** | [**CreateWebScopeSettings**](CreateWebScopeSettings.md) |  | [optional] [default to null]
**WebLanguages** | [**IntModel[]**](IntModel.md) |  | [optional] [default to null]
**LanguageIdsAndTemplates** | [**LanguageWithTemplates[]**](LanguageWithTemplates.md) |  | [optional] [default to null]
**TemplateIdsAndPermissions** | [**TemplateWithPermissions[]**](TemplateWithPermissions.md) |  | [optional] [default to null]
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] [default to null]
**UseUniquePermissions** | **Boolean** |  | [optional] [default to null]
**DeploymentManagerPlanSettings** | [**DeploymentManagerPlanSettings**](DeploymentManagerPlanSettings.md) |  | [optional] [default to null]
**YammerGroupSettings** | [**YammerGroupServiceSettings**](YammerGroupServiceSettings.md) |  | [optional] [default to null]
**TemplateStoreUrl** | **String** |  | [optional] [default to null]
**AppSettings** | [**AppSettings**](AppSettings.md) |  | [optional] [default to null]
**NotifyPrimaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] [default to null]
**NotifySecondaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] [default to null]
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**IsOnQuickLaunch** | **Boolean** |  | [optional] [default to null]
**IsOnTopLinkBar** | **Boolean** |  | [optional] [default to null]
**IsNavigationInheritance** | **Boolean** |  | [optional] [default to null]
**DefaultWebLanguage** | **Int32** |  | [optional] [default to null]
**ScopeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**WebLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**TemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**NavigationInheritanceAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**PermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientCreateWebService  -ScopeSettings null `
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

