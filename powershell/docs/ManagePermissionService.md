# ManagePermissionService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserScopeSetting** | [**ManagePermissionServiceUserScopeSetting**](ManagePermissionServiceUserScopeSetting.md) |  | [optional] 
**SharePointGroupOptions** | [**ManagePermissionServiceSharePointGroupOptions**](ManagePermissionServiceSharePointGroupOptions.md) |  | [optional] 
**PermissionOptions** | [**ManagePermissionServicePermissionOptions**](ManagePermissionServicePermissionOptions.md) |  | [optional] 
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**RequestTemplate** | [**ManagePermissionServiceRequestTemplate**](ManagePermissionServiceRequestTemplate.md) |  | [optional] 
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
$ManagePermissionService = New-Cloud.Governance.ClientManagePermissionService  -UserScopeSetting null `
 -SharePointGroupOptions null `
 -PermissionOptions null `
 -ScopeSettings null `
 -PeoplePickerFilterProfileId null `
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
$ManagePermissionService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

