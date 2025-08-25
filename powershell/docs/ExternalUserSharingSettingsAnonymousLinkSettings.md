# ExternalUserSharingSettingsAnonymousLinkSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Permisssion** | [**AnnoymouslinkPermissions**](AnnoymouslinkPermissions.md) |  | [optional] 
**ExpirationDate** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExternalUserSharingSettingsAnonymousLinkSettings = New-Cloud.Governance.ClientExternalUserSharingSettingsAnonymousLinkSettings  -Permisssion null `
 -ExpirationDate null
```

- Convert the resource to JSON
```powershell
$ExternalUserSharingSettingsAnonymousLinkSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

