# SensitivityLabelModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Tenant** | **String** |  | [optional] 
**TenantName** | **String** |  | [optional] 
**ParentId** | **String** |  | [optional] 
**ParentName** | **String** |  | [optional] 
**FullName** | **String** |  | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**AllowGuestSharing** | **Boolean** |  | [optional] [default to $false]
**SiteSharing** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SensitivityLabelModel = New-Cloud.Governance.ClientSensitivityLabelModel  -Id null `
 -Name null `
 -Tenant null `
 -TenantName null `
 -ParentId null `
 -ParentName null `
 -FullName null `
 -Privacy null `
 -AllowGuestSharing null `
 -SiteSharing null
```

- Convert the resource to JSON
```powershell
$SensitivityLabelModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

