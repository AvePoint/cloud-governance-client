# SiteLifecycleService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**SiteLifecycleActionType**](SiteLifecycleActionType.md) |  | [optional] 
**DisplayMetadataInAutoLifecycleTask** | **Boolean** |  | [optional] [default to $false]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**SiteLifecycleRequest**](SiteLifecycleRequest.md) |  | [optional] 
**ChangePolicySetting** | [**ChangePolicyActionSetting**](ChangePolicyActionSetting.md) |  | [optional] 
**DepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**Department** | **String** |  | [optional] 
**LoadDepartmentFromUps** | **Boolean** |  | [optional] [default to $false]
**Departments** | **String[]** |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
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
$SiteLifecycleService = New-Cloud.Governance.ClientSiteLifecycleService  -Action null `
 -DisplayMetadataInAutoLifecycleTask null `
 -ScopeSettings null `
 -RequestTemplate null `
 -ChangePolicySetting null `
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

- Convert the resource to JSON
```powershell
$SiteLifecycleService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

