# LifecycleScopeSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsLimitGroup** | **Boolean** |  | [optional] [default to $false]
**PeoplePickerFilterProfileId** | **String** |  | [optional] 
**ScopeType** | [**GroupScopeType**](GroupScopeType.md) |  | [optional] 
**Office365Tenant** | [**Office365Tenant**](Office365Tenant.md) | This class is used to deserialize the activity tree node in service ActivityGalleryFlow | [optional] 
**TenantId** | **String** |  | [optional] 
**Containers** | [**ContainerScopeSetting[]**](ContainerScopeSetting.md) |  | [optional] 
**Gallery** | [**GallerySetting**](GallerySetting.md) |  | [optional] 
**ActivityType** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RunAfter** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LifecycleScopeSetting = New-Cloud.Governance.ClientLifecycleScopeSetting  -IsLimitGroup null `
 -PeoplePickerFilterProfileId null `
 -ScopeType null `
 -Office365Tenant null `
 -TenantId null `
 -Containers null `
 -Gallery null `
 -ActivityType null `
 -Type null `
 -Title null `
 -Description null `
 -RunAfter null
```

- Convert the resource to JSON
```powershell
$LifecycleScopeSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

