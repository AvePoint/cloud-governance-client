# ChangePrivateChannelService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangePrivateChannelFields** | [**ChangePrivateChannelFieldModel[]**](ChangePrivateChannelFieldModel.md) | Change PrivateChannel fields | [optional] 
**ChangePrivateChannelQuotaSetting** | [**ChangePrivateChannelServiceChangePrivateChannelQuotaSetting**](ChangePrivateChannelServiceChangePrivateChannelQuotaSetting.md) |  | [optional] 
**TenantId** | **String** | Tenant id | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**HideRequestSummary** | **Boolean** |  | [optional] [default to $false]
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ServiceAdminContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ApproversContainManagerRole** | **Boolean** |  | [optional] [default to $false]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**ShowServiceInCatalog** | **Boolean** |  | [optional] [default to $false]
**CustomActions** | [**ChangeGroupSettingServiceCustomActions**](ChangeGroupSettingServiceCustomActions.md) |  | [optional] 
**ApprovalProcessId** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**CategoryId** | **String** |  | [optional] 
**RequestTemplate** | [**ChangePrivateChannelServiceRequestTemplate**](ChangePrivateChannelServiceRequestTemplate.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelService = New-Cloud.Governance.ClientChangePrivateChannelService  -ChangePrivateChannelFields null `
 -ChangePrivateChannelQuotaSetting null `
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
$ChangePrivateChannelService | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

