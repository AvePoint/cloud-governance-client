# ChangeContactByUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**OriginalPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**NewPrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**OriginalSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**NewSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**OriginalPrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**NewPrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**OriginalAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**NewAdditionalAdministrators** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeContactByUrlSetting  -SiteId null `
 -SiteUrl null `
 -OriginalPrimaryContact null `
 -NewPrimaryContact null `
 -OriginalSecondaryContact null `
 -NewSecondaryContact null `
 -OriginalPrimaryAdministrator null `
 -NewPrimaryAdministrator null `
 -OriginalAdditionalAdministrators null `
 -NewAdditionalAdministrators null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

