# ApiMyGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**GroupName** | **String** |  | [optional] [default to null]
**Email** | **String** |  | [optional] [default to null]
**Language** | **String** |  | [optional] [default to null]
**ApplyPolicyStatus** | **Int32** |  | [optional] [default to null]
**EnableTeamCollaboration** | **Boolean** |  | [optional] [default to null]
**GroupType** | **String** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**PreferredDataLocation** | **String** |  | [optional] [default to null]
**PreferredDataLocationName** | **String** |  | [optional] [readonly] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**PhaseStartTime** | **System.DateTime** |  | [optional] [default to null]
**PhaseDescription** | **String** |  | [optional] [readonly] [default to null]
**AutoImportProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AutoImportProfileName** | **String** |  | [optional] [default to null]
**PolicyName** | **String** |  | [optional] [default to null]
**PolicyDescription** | **String** |  | [optional] [default to null]
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to null]
**PhaseAssignees** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**PhaseDueDate** | **System.DateTime** |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApiMyGroup  -ObjectId null `
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
 -SecondaryContact null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

