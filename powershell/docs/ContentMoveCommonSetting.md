# ContentMoveCommonSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsIncludeVersions** | **Boolean** |  | [optional] [default to null]
**IsIncludeWorkflowDefinition** | **Boolean** |  | [optional] [default to null]
**IsDisableInformationRightsManagement** | **Boolean** |  | [optional] [default to null]
**IsPreserveNullColumnValues** | **Boolean** |  | [optional] [default to null]
**IsKeepModifiedByAndModifiedTime** | **Boolean** |  | [optional] [default to null]
**ProfileMappings** | [**ContentMoveProfileMappings**](ContentMoveProfileMappings.md) |  | [optional] [default to null]
**BackupSettings** | [**BackupEnvironmentSetting**](BackupEnvironmentSetting.md) |  | [optional] [default to null]
**ConflictResolutionSettings** | [**ConflictResolutionSetting**](ConflictResolutionSetting.md) |  | [optional] [default to null]
**FilterPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**DeleteType** | [**DeleteType**](DeleteType.md) |  | [optional] [default to null]
**IsDeleteCheckedFiles** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveCommonSetting  -IsIncludeVersions null `
 -IsIncludeWorkflowDefinition null `
 -IsDisableInformationRightsManagement null `
 -IsPreserveNullColumnValues null `
 -IsKeepModifiedByAndModifiedTime null `
 -ProfileMappings null `
 -BackupSettings null `
 -ConflictResolutionSettings null `
 -FilterPolicy null `
 -DeleteType null `
 -IsDeleteCheckedFiles null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

