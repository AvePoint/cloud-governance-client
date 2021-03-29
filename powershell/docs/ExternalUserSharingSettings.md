# ExternalUserSharingSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**SharingType** | [**ExternalUserSharingType**](ExternalUserSharingType.md) |  | [optional] 
**AnonymousLinkSettings** | [**AnonymousLinkSettings**](AnonymousLinkSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ExternalUserSharingSettings = New-Cloud.Governance.ClientExternalUserSharingSettings  -Enabled null `
 -SharingType null `
 -AnonymousLinkSettings null
```

- Convert the resource to JSON
```powershell
$ExternalUserSharingSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

