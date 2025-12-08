# SiteSharingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalSharing** | [**SharingCapabilities**](SharingCapabilities.md) |  | [optional] 
**GuestAccessExpireSetting** | [**SharingExpireSettingModel**](SharingExpireSettingModel.md) |  | [optional] 
**SharingAdvanceSetting** | [**SharingAdvanceSettingModel**](SharingAdvanceSettingModel.md) |  | [optional] 
**SharingLinkType** | [**SharingLinkType**](SharingLinkType.md) |  | [optional] 
**AnyoneLinksExpireSetting** | [**SharingExpireSettingModel**](SharingExpireSettingModel.md) |  | [optional] 
**LinkPermissionType** | [**LinkPermissionType**](LinkPermissionType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteSharingModel = New-Cloud.Governance.ClientSiteSharingModel  -ExternalSharing null `
 -GuestAccessExpireSetting null `
 -SharingAdvanceSetting null `
 -SharingLinkType null `
 -AnyoneLinksExpireSetting null `
 -LinkPermissionType null
```

- Convert the resource to JSON
```powershell
$SiteSharingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

