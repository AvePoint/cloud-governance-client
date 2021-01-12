# ListVersionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListType** | [**ListType**](ListType.md) |  | [optional] 
**EnableMajorVersions** | **Boolean** |  | [optional] 
**EnableMajorAndMinorVersions** | **Boolean** |  | [optional] 
**EnableMajorVersionLimit** | **Boolean** |  | [optional] 
**MajorVersionLimit** | **Int32** |  | [optional] 
**EnableMinorVersionLimit** | **Boolean** |  | [optional] 
**MinorVersionsLimit** | **Int32** |  | [optional] 
**RequireContentApproval** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ListVersionSettings = New-Cloud.Governance.ClientListVersionSettings  -ListType null `
 -EnableMajorVersions null `
 -EnableMajorAndMinorVersions null `
 -EnableMajorVersionLimit null `
 -MajorVersionLimit null `
 -EnableMinorVersionLimit null `
 -MinorVersionsLimit null `
 -RequireContentApproval null
```

- Convert the resource to JSON
```powershell
$ListVersionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

