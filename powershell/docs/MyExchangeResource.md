# MyExchangeResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**Status** | [**ExchangeResourceStatus**](ExchangeResourceStatus.md) |  | [optional] 
**WorkspaceType** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**WorkspaceTypeDes** | **String** |  | [optional] 
**HasSubmitted** | **Boolean** |  | [optional] [default to $false]
**HasPendingApprovalTask** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseStartTime** | **System.DateTime** |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**AutoImportProfileId** | **String** |  | [optional] 
**AutoImportProfileName** | **String** |  | [optional] 
**RenewalProfileId** | **String** |  | [optional] 
**RenewalProfileName** | **String** |  | [optional] 
**RenewalProfileDescription** | **String** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PolicyDescription** | **String** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**ElectionProfileDescription** | **String** |  | [optional] 
**ExternalSharingProfileId** | **String** |  | [optional] 
**ExternalSharingProfileName** | **String** |  | [optional] 
**ExternalSharingProfileDescription** | **String** |  | [optional] 
**QuotaProfileId** | **String** |  | [optional] 
**QuotaProfileName** | **String** |  | [optional] 
**QuotaProfileDescription** | **String** |  | [optional] 
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to $false]
**PhaseAssignees** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PhaseDueDate** | **System.DateTime** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**CreatedSource** | [**WorkspaceCreatedSourceType**](WorkspaceCreatedSourceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MyExchangeResource = New-Cloud.Governance.ClientMyExchangeResource  -Owners null `
 -Name null `
 -Description null `
 -Email null `
 -TenantId null `
 -CreatedTime null `
 -Status null `
 -WorkspaceType null `
 -WorkspaceTypeDes null `
 -HasSubmitted null `
 -HasPendingApprovalTask null `
 -Id null `
 -Phase null `
 -PhaseStartTime null `
 -PhaseDescription null `
 -AutoImportProfileId null `
 -AutoImportProfileName null `
 -RenewalProfileId null `
 -RenewalProfileName null `
 -RenewalProfileDescription null `
 -PolicyId null `
 -PolicyName null `
 -PolicyDescription null `
 -ElectionProfileId null `
 -ElectionProfileName null `
 -ElectionProfileDescription null `
 -ExternalSharingProfileId null `
 -ExternalSharingProfileName null `
 -ExternalSharingProfileDescription null `
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
 -CreatedSource null
```

- Convert the resource to JSON
```powershell
$MyExchangeResource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

