# BackupEnvironmentSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBackupSource** | **Boolean** |  | [optional] [default to $false]
**IsBackupDestination** | **Boolean** |  | [optional] [default to $false]
**StoragePolicy** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$BackupEnvironmentSetting = New-Cloud.Governance.ClientBackupEnvironmentSetting  -IsBackupSource null `
 -IsBackupDestination null `
 -StoragePolicy null
```

- Convert the resource to JSON
```powershell
$BackupEnvironmentSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

