# CreatePrivateChannelService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**OwnersAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**TenantId** | **String** | Tenant id | [optional] 
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
**RequestTemplate** | [**ApiRequest**](ApiRequest.md) | Base model of request. | [optional] 

## Examples

- Prepare the resource
```powershell
$CreatePrivateChannelService = New-Cloud.Governance.ClientCreatePrivateChannelService  -Owners null `
 -OwnersAssignBy null `
 -TenantId null `
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
 -CategoryId null `
 -RequestTemplate null
```

- Convert the resource to JSON
```powershell
$CreatePrivateChannelService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

