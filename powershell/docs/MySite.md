# MySite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullUrl** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Size** | **Int64** |  | [optional] [default to null]
**Type** | [**MySiteType**](MySiteType.md) |  | [optional] [default to null]
**MySiteType** | **String** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**StorageUsed** | **String** |  | [optional] [default to null]
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**AdditionalAdministrator** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
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
New-Cloud.Governance.ClientMySite  -FullUrl null `
 -Title null `
 -Department null `
 -Description null `
 -Size null `
 -Type null `
 -MySiteType null `
 -CreatedTime null `
 -StorageUsed null `
 -PrimaryAdministrator null `
 -AdditionalAdministrator null `
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

