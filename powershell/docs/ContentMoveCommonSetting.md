# ContentMoveCommonSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsIncludeVersions** | **Boolean** |  | [optional] 
**IsIncludeWorkflowDefinition** | **Boolean** |  | [optional] 
**IsDisableInformationRightsManagement** | **Boolean** |  | [optional] 
**IsPreserveNullColumnValues** | **Boolean** |  | [optional] 
**IsKeepModifiedByAndModifiedTime** | **Boolean** |  | [optional] 
**ProfileMappings** | [**ContentMoveProfileMappings**](ContentMoveProfileMappings.md) |  | [optional] 
**BackupSettings** | [**BackupEnvironmentSetting**](BackupEnvironmentSetting.md) |  | [optional] 
**ConflictResolutionSettings** | [**ConflictResolutionSetting**](ConflictResolutionSetting.md) |  | [optional] 
**FilterPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] 
**DeleteType** | [**DeleteType**](DeleteType.md) |  | [optional] 
**IsDeleteCheckedFiles** | **Boolean** |  | [optional] 

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

