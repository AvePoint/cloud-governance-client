# ImportEnvironmentModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**Id** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**ContactElectionProfile** | **String** |  | [optional] 
**RenewalProfile** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**Metadatas** | [**ImportMetadataModel[]**](ImportMetadataModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ImportEnvironmentModel = New-Cloud.Governance.ClientImportEnvironmentModel  -ObjectType null `
 -Id null `
 -Url null `
 -Name null `
 -TenantId null `
 -ContactElectionProfile null `
 -RenewalProfile null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Metadatas null
```

- Convert the resource to JSON
```powershell
$ImportEnvironmentModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

