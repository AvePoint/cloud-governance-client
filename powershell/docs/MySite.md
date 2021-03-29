# MySite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FullUrl** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Department** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Size** | **Int64** |  | [optional] [default to 0]
**QuotaSize** | **Int64** |  | [optional] [default to 0]
**Type** | [**MySiteType**](MySiteType.md) |  | [optional] 
**MySiteType** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**Sensitivity** | **String** |  | [optional] 
**IsCommunicationSite** | **Boolean** |  | [optional] [default to $false]
**CreatedTime** | **System.DateTime** |  | [optional] 
**StorageUsed** | **String** |  | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**AdditionalAdministrator** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PreferredDataLocation** | **String** |  | [optional] 
**PreferredDataLocationName** | **String** |  | [optional] 
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
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MySite = New-Cloud.Governance.ClientMySite  -FullUrl null `
 -Title null `
 -Department null `
 -Description null `
 -Size null `
 -QuotaSize null `
 -Type null `
 -MySiteType null `
 -Classification null `
 -Sensitivity null `
 -IsCommunicationSite null `
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
 -SecondaryContact null `
 -ErrorMessage null
```

- Convert the resource to JSON
```powershell
$MySite | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

