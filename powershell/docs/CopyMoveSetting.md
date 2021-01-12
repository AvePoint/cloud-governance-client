# CopyMoveSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMigrateConfiguration** | **Boolean** |  | [optional] 
**IsKeepLookAndFeel** | **Boolean** |  | [optional] 
**ColumnsAndContentConflictResolution** | [**ItemConflictResolutionType**](ItemConflictResolutionType.md) |  | [optional] 
**IsMigrateSecurity** | **Boolean** |  | [optional] 
**IsMigrateColumnsAndContentTypes** | **Boolean** |  | [optional] 
**IsMigrateContent** | **Boolean** |  | [optional] 
**IsMigrateContentIncludeListAttachment** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CopyMoveSetting = New-Cloud.Governance.ClientCopyMoveSetting  -IsMigrateConfiguration null `
 -IsKeepLookAndFeel null `
 -ColumnsAndContentConflictResolution null `
 -IsMigrateSecurity null `
 -IsMigrateColumnsAndContentTypes null `
 -IsMigrateContent null `
 -IsMigrateContentIncludeListAttachment null
```

- Convert the resource to JSON
```powershell
$CopyMoveSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

