# ContentMoveCommonSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsIncludeVersions** | **Boolean** |  | [optional] [default to $false]
**IsIncludeWorkflowDefinition** | **Boolean** |  | [optional] [default to $false]
**IsDisableInformationRightsManagement** | **Boolean** |  | [optional] [default to $false]
**IsPreserveNullColumnValues** | **Boolean** |  | [optional] [default to $false]
**IsKeepModifiedByAndModifiedTime** | **Boolean** |  | [optional] [default to $false]
**ProfileMappings** | [**ContentMoveProfileMappings**](ContentMoveProfileMappings.md) |  | [optional] 
**BackupSettings** | [**BackupEnvironmentSetting**](BackupEnvironmentSetting.md) |  | [optional] 
**ConflictResolutionSettings** | [**ConflictResolutionSetting**](ConflictResolutionSetting.md) |  | [optional] 
**FilterPolicy** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**DeleteType** | [**DeleteType**](DeleteType.md) |  | [optional] 
**IsDeleteCheckedFiles** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ContentMoveCommonSetting = New-Cloud.Governance.ClientContentMoveCommonSetting  -IsIncludeVersions null `
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

- Convert the resource to JSON
```powershell
$ContentMoveCommonSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

