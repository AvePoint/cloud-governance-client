# CreateGuestUserService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**EnableInviteOwnersGroup** | **Boolean** |  | [optional] [default to $false]
**EnableInviteContactGroup** | **Boolean** |  | [optional] [default to $false]
**EnableAddToGroups** | **Boolean** |  | [optional] [default to $false]
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**PrimaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContactAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Manager** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ManagerAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableOnTimeRenewal** | **Boolean** |  | [optional] [default to $false]
**OneTimeDuration** | **Int32** |  | [optional] [default to 0]
**OneTimeDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**EnableDomainList** | **Boolean** |  | [optional] [default to $false]
**DomainListType** | [**ExternalDomainListType**](ExternalDomainListType.md) |  | [optional] 
**Domains** | **String[]** |  | [optional] 
**UsageLocationAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**JobTitleAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**JobDepartmentAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**WelcomeEmailMessageAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**UsageLocation** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**JobDepartment** | **String** |  | [optional] 
**WelcomeEmailMessage** | **String** |  | [optional] 
**DisplayNameAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**FirstNameAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**LastNameAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**RequestTemplate** | [**CreateGuestUserRequest**](CreateGuestUserRequest.md) |  | [optional] 
**EnableInviteMultiple** | **Boolean** |  | [optional] [default to $false]
**CompanyName** | **String** |  | [optional] 
**CompanyNameAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
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
$CreateGuestUserService = New-Cloud.Governance.ClientCreateGuestUserService  -TenantId null `
 -EnableInviteOwnersGroup null `
 -EnableInviteContactGroup null `
 -EnableAddToGroups null `
 -PrimaryContact null `
 -PrimaryContactAssignBy null `
 -SecondaryContact null `
 -SecondaryContactAssignBy null `
 -Manager null `
 -ManagerAssignBy null `
 -EnableOnTimeRenewal null `
 -OneTimeDuration null `
 -OneTimeDurationType null `
 -PeoplePickerFilterProfileId null `
 -EnableDomainList null `
 -DomainListType null `
 -Domains null `
 -UsageLocationAssignBy null `
 -JobTitleAssignBy null `
 -JobDepartmentAssignBy null `
 -WelcomeEmailMessageAssignBy null `
 -UsageLocation null `
 -JobTitle null `
 -JobDepartment null `
 -WelcomeEmailMessage null `
 -DisplayNameAssignBy null `
 -FirstNameAssignBy null `
 -LastNameAssignBy null `
 -RequestTemplate null `
 -EnableInviteMultiple null `
 -CompanyName null `
 -CompanyNameAssignBy null `
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
$CreateGuestUserService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

