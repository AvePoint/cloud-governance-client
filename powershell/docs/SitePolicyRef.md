# SitePolicyRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Category** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**Detail** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SitePolicyRef = New-Cloud.Governance.ClientSitePolicyRef  -SiteSharingOptions null `
 -Id null `
 -Name null `
 -Description null `
 -Category null `
 -TenantId null `
 -Status null `
 -Detail null
```

- Convert the resource to JSON
```powershell
$SitePolicyRef | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

