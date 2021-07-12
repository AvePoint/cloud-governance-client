# ChangeSiteSettingService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableChangeTitle** | **Boolean** |  | [optional] [default to $false]
**EnableChangeDescription** | **Boolean** |  | [optional] [default to $false]
**ChangeMetadataSettings** | [**ChangeMetadataActionSetting**](ChangeMetadataActionSetting.md) |  | [optional] 
**DeploymentManagerPlanSettings** | [**DpmServiceSetting**](DpmServiceSetting.md) |  | [optional] 
**EnableChangeHubSite** | **Boolean** |  | [optional] [default to $false]
**ScopeSettings** | [**ServiceScopeSettings**](ServiceScopeSettings.md) |  | [optional] 
**RequestTemplate** | [**ChangeSiteSettingRequest**](ChangeSiteSettingRequest.md) |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**CustomActionSettings**](CustomActionSettings.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingService = New-Cloud.Governance.ClientChangeSiteSettingService  -EnableChangeTitle null `
 -EnableChangeDescription null `
 -ChangeMetadataSettings null `
 -DeploymentManagerPlanSettings null `
 -EnableChangeHubSite null `
 -ScopeSettings null `
 -RequestTemplate null `
 -Metadatas null `
 -HideRequestSummary null `
 -Id null `
 -Name null `
 -Description null `
 -Type null `
 -ServiceContact null `
 -ServiceAdminContact null `
 -ApproversContainManagerRole null `
 -Status null `
 -ShowServiceInCatalog null `
 -CustomActions null `
 -ApprovalProcessId null `
 -LanguageId null `
 -CategoryId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

