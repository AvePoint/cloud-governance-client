# MySharedMailbox
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreferredDataLocation** | **String** |  | [optional] 
**PreferredDataLocationName** | **String** |  | [optional] 
**Alias** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**Status** | [**ExchangeResourceStatus**](ExchangeResourceStatus.md) |  | [optional] 
**WorkspaceType** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**WorkspaceTypeDes** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseStartTime** | **System.DateTime** |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**AutoImportProfileId** | **String** |  | [optional] 
**AutoImportProfileName** | **String** |  | [optional] 
**RenewalProfileId** | **String** |  | [optional] 
**RenewalProfileName** | **String** |  | [optional] 
**RenewalProfileDescription** | **String** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PolicyDescription** | **String** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**ElectionProfileDescription** | **String** |  | [optional] 
**ElectionProfileIsTriggerTaskWhenSecondaryEmpty** | **Boolean** |  | [optional] [default to $false]
**ExternalSharingProfileId** | **String** |  | [optional] 
**ExternalSharingProfileName** | **String** |  | [optional] 
**ExternalSharingProfileDescription** | **String** |  | [optional] 
**ExternalSharingProfileSharingCapabilities** | [**SharingCapabilities**](SharingCapabilities.md) |  | [optional] 
**QuotaProfileId** | **String** |  | [optional] 
**QuotaProfileName** | **String** |  | [optional] 
**QuotaProfileDescription** | **String** |  | [optional] 
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to $false]
**PhaseAssignees** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PhaseDueDate** | **System.DateTime** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**CreatedSource** | [**WorkspaceCreatedSourceType**](WorkspaceCreatedSourceType.md) |  | [optional] 
**HasSubmitted** | **Boolean** |  | [optional] [default to $false]
**HasPendingApprovalTask** | **Boolean** |  | [optional] [default to $false]
**RenewalTaskSummary** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MySharedMailbox = New-Cloud.Governance.ClientMySharedMailbox  -PreferredDataLocation null `
 -PreferredDataLocationName null `
 -Alias null `
 -Name null `
 -Description null `
 -Email null `
 -TenantId null `
 -CreatedTime null `
 -Status null `
 -WorkspaceType null `
 -WorkspaceTypeDes null `
 -Id null `
 -Phase null `
 -PhaseStartTime null `
 -PhaseDescription null `
 -AutoImportProfileId null `
 -AutoImportProfileName null `
 -RenewalProfileId null `
 -RenewalProfileName null `
 -RenewalProfileDescription null `
 -NextRenewalDate null `
 -PolicyId null `
 -PolicyName null `
 -PolicyDescription null `
 -ElectionProfileId null `
 -ElectionProfileName null `
 -ElectionProfileDescription null `
 -ElectionProfileIsTriggerTaskWhenSecondaryEmpty null `
 -ExternalSharingProfileId null `
 -ExternalSharingProfileName null `
 -ExternalSharingProfileDescription null `
 -ExternalSharingProfileSharingCapabilities null `
 -QuotaProfileId null `
 -QuotaProfileName null `
 -QuotaProfileDescription null `
 -IsCurrentRenewer null `
 -PhaseAssignees null `
 -PhaseDueDate null `
 -Metadatas null `
 -PrimaryContact null `
 -SecondaryContact null `
 -ErrorMessage null `
 -CreatedSource null `
 -HasSubmitted null `
 -HasPendingApprovalTask null `
 -RenewalTaskSummary null
```

- Convert the resource to JSON
```powershell
$MySharedMailbox | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

