# CreateListService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableNavigation** | **Boolean** |  | [optional] [default to $false]
**DefaultListType** | [**ListType**](ListType.md) |  | [optional] 
**VersionSettings** | [**CreateListRequestVersionSettings**](CreateListRequestVersionSettings.md) |  | [optional] 
**ListTemplateSettings** | [**CreateListServiceListTemplateSettings**](CreateListServiceListTemplateSettings.md) |  | [optional] 
**UrlSettings** | [**CreateListServiceUrlSettings**](CreateListServiceUrlSettings.md) |  | [optional] 
**AllowBreakPermissionInheritance** | **Boolean** |  | [optional] [default to $false]
**PermissionSettings** | [**CreateListServicePermissionSettings**](CreateListServicePermissionSettings.md) |  | [optional] 
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**ListVersionAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ListTemplateAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NavigationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**ListTypeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateListServiceRequestTemplate**](CreateListServiceRequestTemplate.md) |  | [optional] 
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
$CreateListService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

