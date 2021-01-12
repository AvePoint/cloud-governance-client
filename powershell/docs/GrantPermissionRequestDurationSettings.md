# GrantPermissionRequestDurationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] 
**IsGrantPermissionLevel** | **Boolean** |  | [optional] 
**ExpirationType** | [**ExpirationType**](ExpirationType.md) |  | [optional] 
**DurationInterval** | **Int32** |  | [optional] 
**DurationDateType** | [**DurationDateType**](DurationDateType.md) |  | [optional] 
**StartTime** | **System.DateTime** |  | [optional] 
**EndTime** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionRequestDurationSettings = New-Cloud.Governance.ClientGrantPermissionRequestDurationSettings  -IsGrantTemporaryPermission null `
 -IsGrantPermissionLevel null `
 -ExpirationType null `
 -DurationInterval null `
 -DurationDateType null `
 -StartTime null `
 -EndTime null
```

- Convert the resource to JSON
```powershell
$GrantPermissionRequestDurationSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

