# SPTenantSharingSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharingCapability** | [**SharingCapabilities**](SharingCapabilities.md) |  | [optional] 
**ExternalUserExpirationInDays** | **Int32** |  | [optional] [default to 0]
**DefaultSharingLinkType** | [**SharingLinkType**](SharingLinkType.md) |  | [optional] 
**DefaultLinkPermission** | [**LinkPermissionType**](LinkPermissionType.md) |  | [optional] 
**RequireAnonymousLinksExpireInDays** | **Int32** |  | [optional] [default to 0]
**SharingDomainRestrictionMode** | [**SharingDomainRestrictionMode**](SharingDomainRestrictionMode.md) |  | [optional] 
**LimitDomainList** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPTenantSharingSettingModel = New-Cloud.Governance.ClientSPTenantSharingSettingModel  -SharingCapability null `
 -ExternalUserExpirationInDays null `
 -DefaultSharingLinkType null `
 -DefaultLinkPermission null `
 -RequireAnonymousLinksExpireInDays null `
 -SharingDomainRestrictionMode null `
 -LimitDomainList null
```

- Convert the resource to JSON
```powershell
$SPTenantSharingSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

