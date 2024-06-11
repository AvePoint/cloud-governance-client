# ImportGroupModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**GroupName** | **String** |  | [optional] 
**EmailAddress** | **String** |  | [optional] 
**IsKeepSiteQuota** | **Boolean** |  | [optional] [default to $false]
**AppSetting** | [**AppSettingType**](AppSettingType.md) |  | [optional] 
**ExternalSharingProfile** | **String** |  | [optional] 
**StorageManagementProfile** | **String** |  | [optional] 
**ContactElectionProfile** | **String** |  | [optional] 
**RenewalProfile** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**Metadatas** | [**ImportMetadataModel[]**](ImportMetadataModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ImportGroupModel = New-Cloud.Governance.ClientImportGroupModel  -ObjectType null `
 -GroupName null `
 -EmailAddress null `
 -IsKeepSiteQuota null `
 -AppSetting null `
 -ExternalSharingProfile null `
 -StorageManagementProfile null `
 -ContactElectionProfile null `
 -RenewalProfile null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Metadatas null
```

- Convert the resource to JSON
```powershell
$ImportGroupModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

