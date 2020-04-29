# ExternalUserSharingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**SharingType** | [**ExternalUserSharingType**](ExternalUserSharingType.md) |  | [optional] [default to null]
**AnonymousLinkSettings** | [**AnonymousLinkSettings**](AnonymousLinkSettings.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientExternalUserSharingSettings  -Enabled null `
 -SharingType null `
 -AnonymousLinkSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

