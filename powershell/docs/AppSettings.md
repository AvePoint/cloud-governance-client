# AppSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableInstallApp** | **Boolean** |  | [optional] [default to $false]
**EnableAddSiteInfoCard** | **Boolean** |  | [optional] [default to $false]
**EnableAddTimeLine** | **Boolean** |  | [optional] [default to $false]
**EnableAddPanel** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$AppSettings = New-Cloud.Governance.ClientAppSettings  -EnableInstallApp null `
 -EnableAddSiteInfoCard null `
 -EnableAddTimeLine null `
 -EnableAddPanel null
```

- Convert the resource to JSON
```powershell
$AppSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

