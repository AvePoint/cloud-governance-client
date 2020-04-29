# GrantPermissionRequestDurationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsGrantTemporaryPermission** | **Boolean** |  | [optional] [default to null]
**ExpirationType** | [**ExpirationType**](ExpirationType.md) |  | [optional] [default to null]
**DurationInterval** | **Int32** |  | [optional] [default to null]
**DurationDateType** | [**DurationDateTypeNullable**](DurationDateTypeNullable.md) |  | [optional] [default to null]
**StartTime** | **System.DateTime** |  | [optional] [default to null]
**EndTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGrantPermissionRequestDurationSettings  -IsGrantTemporaryPermission null `
 -ExpirationType null `
 -DurationInterval null `
 -DurationDateType null `
 -StartTime null `
 -EndTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

