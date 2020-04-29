# CopyMoveSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMigrateConfiguration** | **Boolean** |  | [optional] [default to null]
**IsKeepLookAndFeel** | **Boolean** |  | [optional] [default to null]
**ColumnsAndContentConflictResolution** | [**ItemConflictResolutionType**](ItemConflictResolutionType.md) |  | [optional] [default to null]
**IsMigrateSecurity** | **Boolean** |  | [optional] [default to null]
**IsMigrateColumnsAndContentTypes** | **Boolean** |  | [optional] [default to null]
**IsMigrateContent** | **Boolean** |  | [optional] [default to null]
**IsMigrateContentIncludeListAttachment** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCopyMoveSetting  -IsMigrateConfiguration null `
 -IsKeepLookAndFeel null `
 -ColumnsAndContentConflictResolution null `
 -IsMigrateSecurity null `
 -IsMigrateColumnsAndContentTypes null `
 -IsMigrateContent null `
 -IsMigrateContentIncludeListAttachment null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

