# ApiMyGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**PolicyId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Language** | **String** |  | [optional] 
**ApplyPolicyStatus** | **Int32** |  | [optional] [default to 0]
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to $false]
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
**Id** | **String** |  | [optional] 
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] 
**PhaseStartTime** | **System.DateTime** |  | [optional] 
**PhaseDescription** | **String** |  | [optional] 
**AutoImportProfileId** | **String** |  | [optional] 
**AutoImportProfileName** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PolicyDescription** | **String** |  | [optional] 
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to $false]
**PhaseAssignees** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PhaseDueDate** | **System.DateTime** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ErrorMessage** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiMyGroup = New-Cloud.Governance.ClientApiMyGroup  -ObjectId null `
 -PolicyId null `
 -TenantId null `
 -GroupName null `
 -Email null `
 -Language null `
 -ApplyPolicyStatus null `
 -EnableTeamCollaboration null `
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
 -Id null `
 -Phase null `
 -PhaseStartTime null `
 -PhaseDescription null `
 -AutoImportProfileId null `
 -AutoImportProfileName null `
 -PolicyName null `
 -PolicyDescription null `
 -IsCurrentRenewer null `
 -PhaseAssignees null `
 -PhaseDueDate null `
 -Metadatas null `
 -PrimaryContact null `
 -SecondaryContact null `
 -ErrorMessage null
```

- Convert the resource to JSON
```powershell
$ApiMyGroup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

