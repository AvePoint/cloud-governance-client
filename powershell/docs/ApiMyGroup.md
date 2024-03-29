# ApiMyGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Language** | **String** |  | [optional] 
**ApplyPolicyStatus** | **Int32** |  | [optional] [default to 0]
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
**DynamicGroupRules** | [**DynamicGroupRuleModel[]**](DynamicGroupRuleModel.md) |  | [optional] 
**GroupType** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PreferredDataLocation** | **String** |  | [optional] 
**PreferredDataLocationName** | **String** |  | [optional] 
**EnableDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**GroupTeamSiteUrl** | **String** |  | [optional] 
**QuotaSize** | **Int64** |  | [optional] [default to 0]
**StorageUsed** | **String** |  | [optional] 
**TeamLink** | **String** |  | [optional] 
**NoteBookLink** | **String** |  | [optional] 
**PlannerLink** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**GroupObjectType** | [**GroupObjectType**](GroupObjectType.md) |  | [optional] 
**GroupObjectId** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**GroupStatus** | [**GroupStatus**](GroupStatus.md) |  | [optional] 
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
**HasSubmitted** | **Boolean** |  | [optional] [default to $false]
**HasPendingApprovalTask** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ApiMyGroup = New-Cloud.Governance.ClientApiMyGroup  -ObjectId null `
 -TenantId null `
 -GroupName null `
 -Email null `
 -Language null `
 -ApplyPolicyStatus null `
 -EnableTeamCollaboration null `
 -DynamicGroupRules null `
 -GroupType null `
 -CreatedTime null `
 -Owners null `
 -PreferredDataLocation null `
 -PreferredDataLocationName null `
 -EnableDynamicMembership null `
 -GroupTeamSiteUrl null `
 -QuotaSize null `
 -StorageUsed null `
 -TeamLink null `
 -NoteBookLink null `
 -PlannerLink null `
 -Classification null `
 -GroupObjectType null `
 -GroupObjectId null `
 -NetworkId null `
 -Sensitivity null `
 -GroupStatus null `
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
 -CreatedSource null `
 -HasSubmitted null `
 -HasPendingApprovalTask null
```

- Convert the resource to JSON
```powershell
$ApiMyGroup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

