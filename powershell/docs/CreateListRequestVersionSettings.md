# CreateListRequestVersionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListType** | [**ListType**](ListType.md) |  | [optional] 
**EnableMajorVersions** | **Boolean** |  | [optional] [default to $false]
**EnableMajorAndMinorVersions** | **Boolean** |  | [optional] [default to $false]
**EnableMajorVersionLimit** | **Boolean** |  | [optional] [default to $false]
**MajorVersionLimit** | **Int32** |  | [optional] [default to 0]
**EnableMinorVersionLimit** | **Boolean** |  | [optional] [default to $false]
**MinorVersionsLimit** | **Int32** |  | [optional] [default to 0]
**RequireContentApproval** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$CreateListRequestVersionSettings = New-Cloud.Governance.ClientCreateListRequestVersionSettings  -ListType null `
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
$CreateListRequestVersionSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

