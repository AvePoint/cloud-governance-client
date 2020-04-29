# ChangeListSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] [default to null]
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WebUrl** | **String** |  | [optional] [default to null]
**WebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Lists** | [**SPList[]**](SPList.md) |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeListSettingValidateResult  -SiteUrl null `
 -SiteId null `
 -WebUrl null `
 -WebId null `
 -Lists null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

