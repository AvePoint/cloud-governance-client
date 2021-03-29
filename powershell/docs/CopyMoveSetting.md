# CopyMoveSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsMigrateConfiguration** | **Boolean** |  | [optional] [default to $false]
**IsKeepLookAndFeel** | **Boolean** |  | [optional] [default to $false]
**ColumnsAndContentConflictResolution** | [**ItemConflictResolutionType**](ItemConflictResolutionType.md) |  | [optional] 
**IsMigrateSecurity** | **Boolean** |  | [optional] [default to $false]
**IsMigrateColumnsAndContentTypes** | **Boolean** |  | [optional] [default to $false]
**IsMigrateContent** | **Boolean** |  | [optional] [default to $false]
**IsMigrateContentIncludeListAttachment** | **Boolean** |  | [optional] [default to $false]

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

