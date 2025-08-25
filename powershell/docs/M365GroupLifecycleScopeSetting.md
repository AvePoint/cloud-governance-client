# M365GroupLifecycleScopeSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsLimitGroup** | **Boolean** |  | [optional] [default to $false]
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**ScopeType** | [**GroupScopeType**](GroupScopeType.md) |  | [optional] 
**Office365Tenant** | [**LifecycleScopeSettingOffice365Tenant**](LifecycleScopeSettingOffice365Tenant.md) |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Containers** | [**ContainerScopeSetting[]**](ContainerScopeSetting.md) |  | [optional] 
**Gallery** | [**LifecycleScopeSettingGallery**](LifecycleScopeSettingGallery.md) |  | [optional] 
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
$M365GroupLifecycleScopeSetting = New-Cloud.Governance.ClientM365GroupLifecycleScopeSetting  -IsLimitGroup null `
 -PeoplePickerFilterProfileId null `
 -ScopeType null `
 -Office365Tenant null `
 -TenantId null `
 -Containers null `
 -Gallery null `
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
$M365GroupLifecycleScopeSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

