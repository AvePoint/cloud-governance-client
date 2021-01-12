# ChangeListSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**Lists** | [**SPList[]**](SPList.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeListSettingValidateResult = New-Cloud.Governance.ClientChangeListSettingValidateResult  -SiteUrl null `
 -SiteId null `
 -WebUrl null `
 -WebId null `
 -Lists null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeListSettingValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

