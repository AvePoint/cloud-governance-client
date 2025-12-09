# CheckSiteStorageSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageUsage** | **Double** |  | [optional] 
**MaxStorage** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$CheckSiteStorageSettingModel = New-Cloud.Governance.ClientCheckSiteStorageSettingModel  -StorageUsage null `
 -MaxStorage null
```

- Convert the resource to JSON
```powershell
$CheckSiteStorageSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

