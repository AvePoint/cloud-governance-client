# ChangeWebContactService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedNodes** | **String** |  | [optional] 
**UnCheckedNodesInfo** | **String** |  | [optional] 
**ChangeMethod** | [**ChangeContactMethod**](ChangeContactMethod.md) |  | [optional] 
**ChangeMethodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableNotifyNewContact** | **Boolean** |  | [optional] [default to $false]
**NewContactNotifiedEmail** | **String** |  | [optional] 
**ScopeSettings** | [**ChangePermissionServiceScopeSettings**](ChangePermissionServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ChangeWebContactServiceRequestTemplate**](ChangeWebContactServiceRequestTemplate.md) |  | [optional] 
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
$ChangeWebContactService = New-Cloud.Governance.ClientChangeWebContactService  -SelectedNodes null `
 -UnCheckedNodesInfo null `
 -ChangeMethod null `
 -ChangeMethodAssignBy null `
 -EnableNotifyNewContact null `
 -NewContactNotifiedEmail null `
 -ScopeSettings null `
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
$ChangeWebContactService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

