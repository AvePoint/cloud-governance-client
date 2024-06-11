# LicenseInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseId** | **String** |  | [optional] 
**LicenseName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseInfo = New-Cloud.Governance.ClientLicenseInfo  -LicenseId null `
 -LicenseName null
```

- Convert the resource to JSON
```powershell
$LicenseInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

