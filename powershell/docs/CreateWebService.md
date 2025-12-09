# CreateWebService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScopeSettings** | [**CreateWebScopeSettings**](CreateWebScopeSettings.md) |  | [optional] 
**WebLanguages** | [**IntModel[]**](IntModel.md) |  | [optional] 
**LanguageIdsAndTemplates** | [**LanguageWithTemplates[]**](LanguageWithTemplates.md) |  | [optional] 
**TemplateIdsAndPermissions** | [**TemplateWithPermissions[]**](TemplateWithPermissions.md) |  | [optional] 
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] 
**UseUniquePermissions** | **Boolean** |  | [optional] [default to $false]
**DeploymentManagerPlanSettings** | [**DeploymentManagerPlanSettings**](DeploymentManagerPlanSettings.md) |  | [optional] 
**YammerGroupSettings** | [**YammerGroupServiceSettings**](YammerGroupServiceSettings.md) |  | [optional] 
**TemplateStoreUrl** | **String** |  | [optional] 
**AppSettings** | [**AppSettings**](AppSettings.md) |  | [optional] 
**NotifyPrimaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] 
**NotifySecondaryContactSettings** | [**GuidBooleanModel**](GuidBooleanModel.md) |  | [optional] 
**DefaultPrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsOnQuickLaunch** | **Boolean** |  | [optional] [default to $false]
**IsOnTopLinkBar** | **Boolean** |  | [optional] [default to $false]
**IsNavigationInheritance** | **Boolean** |  | [optional] [default to $false]
**DefaultWebLanguage** | **Int32** |  | [optional] [default to 0]
**ScopeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**WebLanguageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationInheritanceAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**PermissionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateWebRequest**](CreateWebRequest.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 

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
$CreateWebService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

