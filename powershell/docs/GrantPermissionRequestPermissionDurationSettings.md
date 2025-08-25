# GrantPermissionRequestPermissionDurationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to $false]
**IsGrantPermissionLevel** | **Boolean** |  | [optional] [default to $false]
**ExpirationType** | [**ExpirationType**](ExpirationType.md) |  | [optional] 
**DurationInterval** | **Int32** |  | [optional] [default to 0]
**DurationDateType** | [**DurationDateType**](DurationDateType.md) |  | [optional] 
**StartTime** | **System.DateTime** |  | [optional] 
**EndTime** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionRequestPermissionDurationSettings = New-Cloud.Governance.ClientGrantPermissionRequestPermissionDurationSettings  -IsGrantTemporaryPermission null `
 -IsGrantPermissionLevel null `
 -ExpirationType null `
 -DurationInterval null `
 -DurationDateType null `
 -StartTime null `
 -EndTime null
```

- Convert the resource to JSON
```powershell
$GrantPermissionRequestPermissionDurationSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

