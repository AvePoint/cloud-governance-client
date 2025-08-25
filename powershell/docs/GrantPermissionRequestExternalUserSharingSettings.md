# GrantPermissionRequestExternalUserSharingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**SharingType** | [**ExternalUserSharingType**](ExternalUserSharingType.md) |  | [optional] 
**AnonymousLinkSettings** | [**ExternalUserSharingSettingsAnonymousLinkSettings**](ExternalUserSharingSettingsAnonymousLinkSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GrantPermissionRequestExternalUserSharingSettings = New-Cloud.Governance.ClientGrantPermissionRequestExternalUserSharingSettings  -Enabled null `
 -SharingType null `
 -AnonymousLinkSettings null
```

- Convert the resource to JSON
```powershell
$GrantPermissionRequestExternalUserSharingSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

