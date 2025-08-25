# ChangeLicenseGalleryLicenseDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicensesInfo** | [**ChangedLicense[]**](ChangedLicense.md) |  | [optional] 
**LicenseUpdateInfo** | [**ChangeLicenseModelLicenseUpdateInfo**](ChangeLicenseModelLicenseUpdateInfo.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeLicenseGalleryLicenseDetails = New-Cloud.Governance.ClientChangeLicenseGalleryLicenseDetails  -LicensesInfo null `
 -LicenseUpdateInfo null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeLicenseGalleryLicenseDetails | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

