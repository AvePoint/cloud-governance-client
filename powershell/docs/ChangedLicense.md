# ChangedLicense
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseId** | **String** |  | [optional] 
**LicenseName** | **String** |  | [optional] 
**SelectedAllForShow** | **Boolean** |  | [optional] [default to $false]
**SelectedApps** | [**ServicePlanModel[]**](ServicePlanModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangedLicense = New-Cloud.Governance.ClientChangedLicense  -LicenseId null `
 -LicenseName null `
 -SelectedAllForShow null `
 -SelectedApps null
```

- Convert the resource to JSON
```powershell
$ChangedLicense | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

