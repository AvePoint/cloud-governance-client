# ChangeWebContactByUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**WebId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WebUrl** | **String** |  | [optional] [default to null]
**PrimaryContact** | [**ApiUserChangedProperty**](ApiUserChangedProperty.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUserChangedProperty**](ApiUserChangedProperty.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeWebContactByUrlSetting  -SiteId null `
 -SiteUrl null `
 -WebId null `
 -WebUrl null `
 -PrimaryContact null `
 -SecondaryContact null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

