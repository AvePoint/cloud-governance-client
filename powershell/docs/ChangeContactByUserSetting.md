# ChangeContactByUserSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**NewUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**AlternativeUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeContactByUserSetting  -CurrentUser null `
 -NewUser null `
 -AlternativeUser null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

