# LifecycleScopeSettingOffice365Tenant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**ActivityType** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryTitle** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RunAfter** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LifecycleScopeSettingOffice365Tenant = New-Cloud.Governance.ClientLifecycleScopeSettingOffice365Tenant  -Id null `
 -ActivityType null `
 -Type null `
 -GalleryType null `
 -GalleryTitle null `
 -Title null `
 -Description null `
 -RunAfter null `
 -DisplayName null
```

- Convert the resource to JSON
```powershell
$LifecycleScopeSettingOffice365Tenant | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

