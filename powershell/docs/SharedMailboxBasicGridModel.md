# SharedMailboxBasicGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**LastModifiedTime** | **System.DateTime** |  | [optional] 
**LastRenewalTime** | **System.DateTime** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] 
**ClaimStatusDescription** | **String** |  | [optional] 
**OngoingTaskCount** | **Int32** |  | [optional] [default to 0]
**TenantId** | **String** |  | [optional] 
**Status** | [**ExchangeResourceStatus**](ExchangeResourceStatus.md) |  | [optional] 
**Members** | **String** |  | [optional] 
**DirectorySyncState** | [**DirectorySyncState**](DirectorySyncState.md) |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactEmail** | **String** |  | [optional] 
**PrimaryContactDisplayName** | **String** |  | [optional] 
**PrimaryContactObjectId** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactEmail** | **String** |  | [optional] 
**SecondaryContactDisplayName** | **String** |  | [optional] 
**SecondaryContactObjectId** | **String** |  | [optional] 
**PrimaryContactJobTitle** | **String** |  | [optional] 
**PrimaryContactDepartment** | **String** |  | [optional] 
**PrimaryContactCompanyName** | **String** |  | [optional] 
**SecondaryContactJobTitle** | **String** |  | [optional] 
**SecondaryContactDepartment** | **String** |  | [optional] 
**SecondaryContactCompanyName** | **String** |  | [optional] 
**LastRenewalBy** | **String** |  | [optional] 
**LastRenewalByEmail** | **String** |  | [optional] 
**LastRenewalByDisplayName** | **String** |  | [optional] 
**PhaseAssigneeDisplayNames** | **String** |  | [optional] 
**PhaseAssigneeObjectIds** | **String** |  | [optional] 
**PhaseAssignees** | **String** |  | [optional] 
**PhaseProfileName** | **String** |  | [optional] 
**PhaseProfileId** | **String** |  | [optional] 
**PhaseStartTime** | **System.DateTime** |  | [optional] 
**RenewalDueDate** | **System.DateTime** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SharedMailboxBasicGridModel = New-Cloud.Governance.ClientSharedMailboxBasicGridModel  -Id null `
 -Name null `
 -Email null `
 -CreatedTime null `
 -LastModifiedTime null `
 -LastRenewalTime null `
 -ElectionProfileName null `
 -ElectionProfileId null `
 -ClaimStatus null `
 -ClaimStatusDescription null `
 -OngoingTaskCount null `
 -TenantId null `
 -Status null `
 -Members null `
 -DirectorySyncState null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -PrimaryContactDisplayName null `
 -PrimaryContactObjectId null `
 -SecondaryContact null `
 -SecondaryContactEmail null `
 -SecondaryContactDisplayName null `
 -SecondaryContactObjectId null `
 -PrimaryContactJobTitle null `
 -PrimaryContactDepartment null `
 -PrimaryContactCompanyName null `
 -SecondaryContactJobTitle null `
 -SecondaryContactDepartment null `
 -SecondaryContactCompanyName null `
 -LastRenewalBy null `
 -LastRenewalByEmail null `
 -LastRenewalByDisplayName null `
 -PhaseAssigneeDisplayNames null `
 -PhaseAssigneeObjectIds null `
 -PhaseAssignees null `
 -PhaseProfileName null `
 -PhaseProfileId null `
 -PhaseStartTime null `
 -RenewalDueDate null `
 -NextRenewalDate null `
 -Phase null `
 -PhaseDescription null `
 -Metadata null
```

- Convert the resource to JSON
```powershell
$SharedMailboxBasicGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

