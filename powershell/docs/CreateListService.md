# CreateListService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableNavigation** | **Boolean** |  | [optional] 
**DefaultListType** | [**ListType**](ListType.md) |  | [optional] 
**VersionSettings** | [**ListVersionSettings**](ListVersionSettings.md) |  | [optional] 
**ListTemplateSettings** | [**ListTemplateSettings**](ListTemplateSettings.md) |  | [optional] 
**UrlSettings** | [**CreateListUrlSettings**](CreateListUrlSettings.md) |  | [optional] 
**AllowBreakPermissionInheritance** | **Boolean** |  | [optional] 
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] 
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**ListVersionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ListTemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ListTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateListRequest**](CreateListRequest.md) |  | [optional] 
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
$CreateListService = New-Cloud.Governance.ClientCreateListService  -EnableNavigation null `
 -DefaultListType null `
 -VersionSettings null `
 -ListTemplateSettings null `
 -UrlSettings null `
 -AllowBreakPermissionInheritance null `
 -PermissionSettings null `
 -ScopeSettings null `
 -ListVersionAssignBy null `
 -ListTemplateAssignBy null `
 -NavigationAssignBy null `
 -ListTypeAssignBy null `
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
$CreateListService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

