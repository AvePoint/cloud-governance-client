# TemporaryPermissionRequestSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to $false]
**IsGrantAdminGroup** | **Boolean** |  | [optional] [default to $false]
**ExpirationType** | [**ExpirationType**](ExpirationType.md) |  | [optional] 
**DurationInterval** | **Int32** |  | [optional] [default to 0]
**DurationDateType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**StartTime** | **System.DateTime** |  | [optional] 
**EndTime** | **System.DateTime** |  | [optional] 
**TempPermissionGroupIdentity** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TemporaryPermissionRequestSetting = New-Cloud.Governance.ClientTemporaryPermissionRequestSetting  -IsGrantTemporaryPermission null `
 -IsGrantAdminGroup null `
 -ExpirationType null `
 -DurationInterval null `
 -DurationDateType null `
 -StartTime null `
 -EndTime null `
 -TempPermissionGroupIdentity null
```

- Convert the resource to JSON
```powershell
$TemporaryPermissionRequestSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

