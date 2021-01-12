# ContentMoveProfiles
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackupEnvironmentStoragePolices** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**ColumnMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**ContentTypeMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**UserMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**LanguageMappings** | [**GuidModel[]**](GuidModel.md) |  | [optional] 
**FilterPolices** | [**GuidModel[]**](GuidModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveProfiles = New-Cloud.Governance.ClientContentMoveProfiles  -BackupEnvironmentStoragePolices null `
 -ColumnMappings null `
 -ContentTypeMappings null `
 -UserMappings null `
 -LanguageMappings null `
 -FilterPolices null
```

- Convert the resource to JSON
```powershell
$ContentMoveProfiles | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

