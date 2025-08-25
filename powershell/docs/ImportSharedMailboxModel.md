# ImportSharedMailboxModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**SharedMailboxName** | **String** |  | [optional] 
**EmailAddress** | **String** |  | [optional] 
**ContactElectionProfile** | **String** |  | [optional] 
**RenewalProfile** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**Metadatas** | [**ImportMetadataModel[]**](ImportMetadataModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ImportSharedMailboxModel = New-Cloud.Governance.ClientImportSharedMailboxModel  -ObjectType null `
 -SharedMailboxName null `
 -EmailAddress null `
 -ContactElectionProfile null `
 -RenewalProfile null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Metadatas null
```

- Convert the resource to JSON
```powershell
$ImportSharedMailboxModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

