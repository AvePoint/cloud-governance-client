# BackupEnvironmentSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBackupSource** | **Boolean** |  | [optional] [default to null]
**IsBackupDestination** | **Boolean** |  | [optional] [default to null]
**StoragePolicy** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientBackupEnvironmentSetting  -IsBackupSource null `
 -IsBackupDestination null `
 -StoragePolicy null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

