# SiteDetailModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullUrl** | **String** |  | [optional] 
**Status** | [**SiteStatus**](SiteStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**SiteStatus** | [**TeamSiteStatus**](TeamSiteStatus.md) |  | [optional] 
**SiteStatusDescription** | **String** |  | [optional] 
**LegalHold** | **Boolean** |  | [optional] [default to $false]
**PrimarySCAdministrator** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**AdditionalSCAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Sharing** | [**SiteSharingStatus**](SiteSharingStatus.md) |  | [optional] 
**SharingDescription** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**SiteTemplate** | **String** |  | [optional] 
**SiteTemplateTitle** | **String** |  | [optional] 
**HasPendingApprovalTask** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PolicyDescription** | **String** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**HubSite** | **String** |  | [optional] 
**HubType** | [**HubSiteType**](HubSiteType.md) |  | [optional] 
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] 
**ClaimStatusDescription** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**TypeDescription** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**LockedBy** | [**LockedBy**](LockedBy.md) |  | [optional] 
**LockedByDescription** | **String** |  | [optional] 
**GeoLocation** | **String** |  | [optional] 
**GeoLocationDescription** | **String** |  | [optional] 
**StorageLimit** | **String** |  | [optional] 
**StorageUsed** | **String** |  | [optional] 
**RenewalProfileName** | **String** |  | [optional] 
**RenewalProfileId** | **String** |  | [optional] 
**QuotaProfileName** | **String** |  | [optional] 
**QuotaProfileId** | **String** |  | [optional] 
**ExternalSharingProfileName** | **String** |  | [optional] 
**ExternalSharingProfileId** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**LeaseExpirationTime** | **System.DateTime** |  | [optional] 
**InactivityThresholdTime** | **System.DateTime** |  | [optional] 
**PhaseAssignees** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**RenewalStartTime** | **System.DateTime** |  | [optional] 
**RenewDueDate** | **System.DateTime** |  | [optional] 
**LastRenewalDate** | **System.DateTime** |  | [optional] 
**LastAccessedTime** | **System.DateTime** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**LastRenewalBy** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**HasOngoingTasks** | **Boolean** |  | [optional] [default to $false]
**InsightsStatus** | [**InsightsStatus**](InsightsStatus.md) |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**LastSyncTime** | **System.DateTime** |  | [optional] 
**CreatedSource** | [**WorkspaceCreatedSourceType**](WorkspaceCreatedSourceType.md) |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteDetailModel = New-Cloud.Governance.ClientSiteDetailModel  -FullUrl null `
 -Status null `
 -StatusDescription null `
 -SiteStatus null `
 -SiteStatusDescription null `
 -LegalHold null `
 -PrimarySCAdministrator null `
 -AdditionalSCAdministrators null `
 -Sharing null `
 -SharingDescription null `
 -Sensitivity null `
 -SiteTemplate null `
 -SiteTemplateTitle null `
 -HasPendingApprovalTask null `
 -Id null `
 -Name null `
 -Description null `
 -Phase null `
 -PhaseDescription null `
 -PolicyName null `
 -PolicyDescription null `
 -PolicyId null `
 -PrimaryContact null `
 -SecondaryContact null `
 -HubSite null `
 -HubType null `
 -ClaimStatus null `
 -ClaimStatusDescription null `
 -Type null `
 -TypeDescription null `
 -Classification null `
 -LockedBy null `
 -LockedByDescription null `
 -GeoLocation null `
 -GeoLocationDescription null `
 -StorageLimit null `
 -StorageUsed null `
 -RenewalProfileName null `
 -RenewalProfileId null `
 -QuotaProfileName null `
 -QuotaProfileId null `
 -ExternalSharingProfileName null `
 -ExternalSharingProfileId null `
 -CreatedTime null `
 -LeaseExpirationTime null `
 -InactivityThresholdTime null `
 -PhaseAssignees null `
 -RenewalStartTime null `
 -RenewDueDate null `
 -LastRenewalDate null `
 -LastAccessedTime null `
 -NextRenewalDate null `
 -LastRenewalBy null `
 -Metadatas null `
 -HasOngoingTasks null `
 -InsightsStatus null `
 -ElectionProfileId null `
 -ElectionProfileName null `
 -LastSyncTime null `
 -CreatedSource null `
 -ErrorMessage null
```

- Convert the resource to JSON
```powershell
$SiteDetailModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

