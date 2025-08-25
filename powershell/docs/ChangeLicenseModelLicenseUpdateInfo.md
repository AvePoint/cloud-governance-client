# ChangeLicenseModelLicenseUpdateInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemovedLicenses** | [**LicenseInfo[]**](LicenseInfo.md) |  | [optional] 
**RemovedApps** | [**AppInfo[]**](AppInfo.md) |  | [optional] 
**NewlyAddLicenses** | [**LicenseInfo[]**](LicenseInfo.md) |  | [optional] 
**NewlyAddApps** | [**AppInfo[]**](AppInfo.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeLicenseModelLicenseUpdateInfo = New-Cloud.Governance.ClientChangeLicenseModelLicenseUpdateInfo  -RemovedLicenses null `
 -RemovedApps null `
 -NewlyAddLicenses null `
 -NewlyAddApps null
```

- Convert the resource to JSON
```powershell
$ChangeLicenseModelLicenseUpdateInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

