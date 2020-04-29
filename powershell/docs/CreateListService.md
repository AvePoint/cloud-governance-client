# CreateListService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableNavigation** | **Boolean** |  | [optional] [default to null]
**DefaultListType** | [**ListType**](ListType.md) |  | [optional] [default to null]
**VersionSettings** | [**ListVersionSettings**](ListVersionSettings.md) |  | [optional] [default to null]
**ListTemplateSettings** | [**ListTemplateSettings**](ListTemplateSettings.md) |  | [optional] [default to null]
**UrlSettings** | [**CreateListUrlSettings**](CreateListUrlSettings.md) |  | [optional] [default to null]
**AllowBreakPermissionInheritance** | **Boolean** |  | [optional] [default to null]
**PermissionSettings** | [**PermissionSettings**](PermissionSettings.md) |  | [optional] [default to null]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] [default to null]
**ListVersionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ListTemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**ListTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientCreateListService  -EnableNavigation null `
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

