# ListVersionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListType** | [**ListType**](ListType.md) |  | [optional] [default to null]
**EnableMajorVersions** | **Boolean** |  | [optional] [default to null]
**EnableMajorAndMinorVersions** | **Boolean** |  | [optional] [default to null]
**EnableMajorVersionLimit** | **Boolean** |  | [optional] [default to null]
**MajorVersionLimit** | **Int32** |  | [optional] [default to null]
**EnableMinorVersionLimit** | **Boolean** |  | [optional] [default to null]
**MinorVersionsLimit** | **Int32** |  | [optional] [default to null]
**RequireContentApproval** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientListVersionSettings  -ListType null `
 -EnableMajorVersions null `
 -EnableMajorAndMinorVersions null `
 -EnableMajorVersionLimit null `
 -MajorVersionLimit null `
 -EnableMinorVersionLimit null `
 -MinorVersionsLimit null `
 -RequireContentApproval null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

