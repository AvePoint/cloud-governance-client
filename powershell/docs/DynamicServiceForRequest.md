# DynamicServiceForRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**ServiceAdminContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**LanguageId** | [**IntModel**](IntModel.md) |  | [optional] 
**Category** | [**GuidModel**](GuidModel.md) |  | [optional] 
**ActivityGalleryFlow** | **String** |  | [optional] 
**ApproveProcessFlow** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$DynamicServiceForRequest = New-Cloud.Governance.ClientDynamicServiceForRequest  -Id null `
 -HideRequestSummary null `
 -Name null `
 -Description null `
 -ServiceAdminContact null `
 -Status null `
 -ShowServiceInCatalog null `
 -LanguageId null `
 -Category null `
 -ActivityGalleryFlow null `
 -ApproveProcessFlow null
```

- Convert the resource to JSON
```powershell
$DynamicServiceForRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

