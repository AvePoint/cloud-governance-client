# ApplyProfilesModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarFilter** | **String** |  | [optional] 
**Search** | **String** |  | [optional] 
**EnableModernRenewalProfile** | **Boolean** |  | [optional] [default to $false]
**ModernRenewalProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**EnableElectionProfile** | **Boolean** |  | [optional] [default to $false]
**ElectionProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**EnableQuotaProfile** | **Boolean** |  | [optional] [default to $false]
**QuotaProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**IsKeepQuota** | **Boolean** |  | [optional] [default to $false]
**EnableExternalSharingProfile** | **Boolean** |  | [optional] [default to $false]
**ExternalSharingProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**ProfileObjectType** | [**ApiProfileObjectType**](ApiProfileObjectType.md) |  | [optional] 
**SelectedObjects** | **String[]** |  | [optional] 
**HandleOngoingType** | [**HandleOngoingType**](HandleOngoingType.md) |  | [optional] 
**HandleTaskType** | [**HandleTaskType**](HandleTaskType.md) |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**IsConfirmed** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ApplyProfilesModel = New-Cloud.Governance.ClientApplyProfilesModel  -VarFilter null `
 -Search null `
 -EnableModernRenewalProfile null `
 -ModernRenewalProfile null `
 -EnableElectionProfile null `
 -ElectionProfile null `
 -EnableQuotaProfile null `
 -QuotaProfile null `
 -IsKeepQuota null `
 -EnableExternalSharingProfile null `
 -ExternalSharingProfile null `
 -ProfileObjectType null `
 -SelectedObjects null `
 -HandleOngoingType null `
 -HandleTaskType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -IsConfirmed null
```

- Convert the resource to JSON
```powershell
$ApplyProfilesModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

