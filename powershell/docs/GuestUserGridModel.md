# GuestUserGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Mail** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactEmail** | **String** |  | [optional] 
**PrimaryContactDisplayName** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactEmail** | **String** |  | [optional] 
**SecondaryContactDisplayName** | **String** |  | [optional] 
**PrimaryContactJobTitle** | **String** |  | [optional] 
**PrimaryContactDepartment** | **String** |  | [optional] 
**PrimaryContactCompanyName** | **String** |  | [optional] 
**SecondaryContactJobTitle** | **String** |  | [optional] 
**SecondaryContactDepartment** | **String** |  | [optional] 
**SecondaryContactCompanyName** | **String** |  | [optional] 
**Status** | [**GuestUserStatus**](GuestUserStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**PhaseProfileId** | **String** |  | [optional] 
**ProfileName** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**RenewalAssignees** | **String** |  | [optional] 
**RenewalAssigneeDisplayNames** | **String** |  | [optional] 
**LastRenewalBy** | **String** |  | [optional] 
**LastRenewalByEmail** | **String** |  | [optional] 
**LastRenewalByDisplayName** | **String** |  | [optional] 
**ExternalUserState** | [**ExternalUserState**](ExternalUserState.md) |  | [optional] 
**ExternalUserStateDescription** | **String** |  | [optional] 
**LastSyncTime** | **System.DateTime** |  | [optional] 
**InviteTime** | **System.DateTime** |  | [optional] 
**LastRenewalTime** | **System.DateTime** |  | [optional] 
**RenewalStartTime** | **System.DateTime** |  | [optional] 
**RenewalDueDate** | **System.DateTime** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] 
**OngoingTaskCount** | **Int32** |  | [optional] [default to 0]
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestUserGridModel = New-Cloud.Governance.ClientGuestUserGridModel  -Id null `
 -DisplayName null `
 -Mail null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactEmail null `
 -SecondaryContactDisplayName null `
 -PrimaryContactJobTitle null `
 -PrimaryContactDepartment null `
 -PrimaryContactCompanyName null `
 -SecondaryContactJobTitle null `
 -SecondaryContactDepartment null `
 -SecondaryContactCompanyName null `
 -Status null `
 -StatusDescription null `
 -PhaseProfileId null `
 -ProfileName null `
 -TenantId null `
 -NextRenewalDate null `
 -RenewalAssignees null `
 -RenewalAssigneeDisplayNames null `
 -LastRenewalBy null `
 -LastRenewalByEmail null `
 -LastRenewalByDisplayName null `
 -ExternalUserState null `
 -ExternalUserStateDescription null `
 -LastSyncTime null `
 -InviteTime null `
 -LastRenewalTime null `
 -RenewalStartTime null `
 -RenewalDueDate null `
 -ElectionProfileId null `
 -ElectionProfileName null `
 -Phase null `
 -ClaimStatus null `
 -OngoingTaskCount null `
 -Metadata null
```

- Convert the resource to JSON
```powershell
$GuestUserGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

