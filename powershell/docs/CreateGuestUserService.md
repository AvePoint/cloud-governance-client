# CreateGuestUserService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**EnableInviteOwnersGroup** | **Boolean** |  | [optional] 
**EnableInviteContactGroup** | **Boolean** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableOnTimeRenewal** | **Boolean** |  | [optional] 
**OneTimeDuration** | **Int32** |  | [optional] 
**OneTimeDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**RequestTemplate** | [**CreateGuestUserRequest**](CreateGuestUserRequest.md) |  | [optional] 
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
$CreateGuestUserService = New-Cloud.Governance.ClientCreateGuestUserService  -TenantId null `
 -EnableInviteOwnersGroup null `
 -EnableInviteContactGroup null `
 -PrimaryContact null `
 -PrimaryContactAssignBy null `
 -SecondaryContact null `
 -SecondaryContactAssignBy null `
 -EnableOnTimeRenewal null `
 -OneTimeDuration null `
 -OneTimeDurationType null `
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
$CreateGuestUserService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

