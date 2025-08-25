# WorkspaceList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ObjectId** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**GroupEmail** | **String** |  | [optional] 
**TypeDescription** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactEmail** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to $false]
**CreatedTime** | **System.DateTime** |  | [optional] 
**Status** | [**SiteStatus**](SiteStatus.md) |  | [optional] 
**AutoImportProfileId** | **String** |  | [optional] 
**PendingAction** | **Int32** |  | [optional] [default to 0]
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactEmail** | **String** |  | [optional] 
**Policy** | **String** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**RenewalProfile** | **String** |  | [optional] 
**RenewalProfileId** | **String** |  | [optional] 
**ElectionProfile** | **String** |  | [optional] 
**ElectionProfileId** | **String** |  | [optional] 
**QuotaProfile** | **String** |  | [optional] 
**QuotaProfileId** | **String** |  | [optional] 
**ExternalSharingProfile** | **String** |  | [optional] 
**ExternalSharingProfileId** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**PrimaryAdmin** | **String** |  | [optional] 
**PrimaryAdminEmail** | **String** |  | [optional] 
**AdditionalAdmin** | **String** |  | [optional] 
**AdditionalAdminEmail** | **String** |  | [optional] 
**GeoLocation** | **String** |  | [optional] 
**GeoLocationDescription** | **String** |  | [optional] 
**StorageLimit** | **String** |  | [optional] 
**StorageUsage** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**Sensitivity** | **String** |  | [optional] 
**PrivacyDescription** | **String** |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**WebLink** | **String** |  | [optional] 
**CreatedSource** | [**WorkspaceCreatedSourceType**](WorkspaceCreatedSourceType.md) |  | [optional] 
**LastActivityTime** | **System.DateTime** |  | [optional] 
**SharePointSiteId** | **String** |  | [optional] 
**PrimaryContactStatusOfEnpower** | [**EnpowerContactStatus**](EnpowerContactStatus.md) |  | [optional] 
**SecondaryContactStatusOfEnpower** | [**EnpowerContactStatus**](EnpowerContactStatus.md) |  | [optional] 
**EnableDynamicMembershipDescription** | **String** |  | [optional] 
**Metadata** | [**EndUserReportMetadata[]**](EndUserReportMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceList = New-Cloud.Governance.ClientWorkspaceList  -Id null `
 -ObjectId null `
 -Name null `
 -Type null `
 -SiteUrl null `
 -GroupEmail null `
 -TypeDescription null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -Phase null `
 -PhaseDescription null `
 -IsCurrentRenewer null `
 -CreatedTime null `
 -Status null `
 -AutoImportProfileId null `
 -PendingAction null `
 -SecondaryContact null `
 -SecondaryContactEmail null `
 -Policy null `
 -PolicyId null `
 -RenewalProfile null `
 -RenewalProfileId null `
 -ElectionProfile null `
 -ElectionProfileId null `
 -QuotaProfile null `
 -QuotaProfileId null `
 -ExternalSharingProfile null `
 -ExternalSharingProfileId null `
 -Description null `
 -PrimaryAdmin null `
 -PrimaryAdminEmail null `
 -AdditionalAdmin null `
 -AdditionalAdminEmail null `
 -GeoLocation null `
 -GeoLocationDescription null `
 -StorageLimit null `
 -StorageUsage null `
 -Classification null `
 -Privacy null `
 -Sensitivity null `
 -PrivacyDescription null `
 -EnableDynamicMembership null `
 -WebLink null `
 -CreatedSource null `
 -LastActivityTime null `
 -SharePointSiteId null `
 -PrimaryContactStatusOfEnpower null `
 -SecondaryContactStatusOfEnpower null `
 -EnableDynamicMembershipDescription null `
 -Metadata null
```

- Convert the resource to JSON
```powershell
$WorkspaceList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

