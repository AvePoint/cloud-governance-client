# WorkspaceGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Status** | [**WorkspaceStatus**](WorkspaceStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**TypeDescription** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**PrivacyDescription** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PolicyDisplay** | **String** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**EnableDynamicMembershipDescription** | **String** |  | [optional] 
**PrimaryAdministrators** | **String** |  | [optional] 
**PrimaryAdministratorDisplayNames** | **String** |  | [optional] 
**AdditionalAdministrators** | **String** |  | [optional] 
**AdditionalAdministratorDisplayNames** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactEmail** | **String** |  | [optional] 
**PrimaryContactDisplayName** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactEmail** | **String** |  | [optional] 
**SecondaryContactDisplayName** | **String** |  | [optional] 
**HubType** | [**HubSiteType**](HubSiteType.md) |  | [optional] 
**AssociateHubTitle** | **String** |  | [optional] 
**GeoLocation** | **String** |  | [optional] 
**GeoLocationDescription** | **String** |  | [optional] 
**StorageLimit** | **Int64** |  | [optional] [default to 0]
**StorageUsed** | **Double** |  | [optional] 
**SiteSharing** | [**SiteSharingStatus**](SiteSharingStatus.md) |  | [optional] 
**SiteSharingDescription** | **String** |  | [optional] 
**GroupSharing** | [**GroupEnableSharingStatus**](GroupEnableSharingStatus.md) |  | [optional] 
**GroupSharingDescription** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**ClaimStatus** | [**ClaimStatus**](ClaimStatus.md) |  | [optional] 
**ClaimStatusDescription** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**LeaseExpirationTime** | **System.DateTime** |  | [optional] 
**InactivityThresholdTime** | **System.DateTime** |  | [optional] 
**LastRenewalTime** | **System.DateTime** |  | [optional] 
**LastAccessedTime** | **System.DateTime** |  | [optional] 
**ApplyPolicyStatus** | [**ApplyPolicyStatus**](ApplyPolicyStatus.md) |  | [optional] 
**HasOngoingTasks** | **Boolean** |  | [optional] [default to $false]
**HasOngoingTasksDescription** | **String** |  | [optional] 
**HasElectionOngoingTasks** | **Boolean** |  | [optional] [default to $false]
**LastRenewalBy** | **String** |  | [optional] 
**LastRenewalByEmail** | **String** |  | [optional] 
**LastRenewalByDisplayName** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**InsightsStatus** | [**InsightsStatus**](InsightsStatus.md) |  | [optional] 
**SiteStatus** | [**TeamSiteStatus**](TeamSiteStatus.md) |  | [optional] 
**SiteStatusDescription** | **String** |  | [optional] 
**LockedBy** | [**LockedBy**](LockedBy.md) |  | [optional] 
**LastSyncTime** | **System.DateTime** |  | [optional] 
**LockedByDescription** | **String** |  | [optional] 
**CreatedSource** | [**WorkspaceCreatedSourceType**](WorkspaceCreatedSourceType.md) |  | [optional] 
**SiteTemplate** | **String** |  | [optional] 
**SiteTemplateTitle** | **String** |  | [optional] 
**QuotaProfileName** | **String** |  | [optional] 
**QuotaProfileId** | **String** |  | [optional] 
**ExternalSharingProfileName** | **String** |  | [optional] 
**ExternalSharingProfileId** | **String** |  | [optional] 
**ElectionProfileName** | **String** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**PhaseAssigneeDisplayNames** | **String** |  | [optional] 
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
$WorkspaceGridModel = New-Cloud.Governance.ClientWorkspaceGridModel  -Id null `
 -Name null `
 -Description null `
 -Status null `
 -StatusDescription null `
 -Type null `
 -TypeDescription null `
 -Url null `
 -Email null `
 -Privacy null `
 -PrivacyDescription null `
 -PolicyName null `
 -PolicyDisplay null `
 -PolicyId null `
 -EnableDynamicMembership null `
 -EnableDynamicMembershipDescription null `
 -PrimaryAdministrators null `
 -PrimaryAdministratorDisplayNames null `
 -AdditionalAdministrators null `
 -AdditionalAdministratorDisplayNames null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactEmail null `
 -SecondaryContactDisplayName null `
 -HubType null `
 -AssociateHubTitle null `
 -GeoLocation null `
 -GeoLocationDescription null `
 -StorageLimit null `
 -StorageUsed null `
 -SiteSharing null `
 -SiteSharingDescription null `
 -GroupSharing null `
 -GroupSharingDescription null `
 -Classification null `
 -ClaimStatus null `
 -ClaimStatusDescription null `
 -CreatedTime null `
 -LeaseExpirationTime null `
 -InactivityThresholdTime null `
 -LastRenewalTime null `
 -LastAccessedTime null `
 -ApplyPolicyStatus null `
 -HasOngoingTasks null `
 -HasOngoingTasksDescription null `
 -HasElectionOngoingTasks null `
 -LastRenewalBy null `
 -LastRenewalByEmail null `
 -LastRenewalByDisplayName null `
 -Sensitivity null `
 -InsightsStatus null `
 -SiteStatus null `
 -SiteStatusDescription null `
 -LockedBy null `
 -LastSyncTime null `
 -LockedByDescription null `
 -CreatedSource null `
 -SiteTemplate null `
 -SiteTemplateTitle null `
 -QuotaProfileName null `
 -QuotaProfileId null `
 -ExternalSharingProfileName null `
 -ExternalSharingProfileId null `
 -ElectionProfileName null `
 -ElectionProfileId null `
 -PhaseAssigneeDisplayNames null `
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
$WorkspaceGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

