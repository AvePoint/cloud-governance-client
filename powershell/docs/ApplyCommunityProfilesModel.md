# ApplyCommunityProfilesModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarFilter** | **String** |  | [optional] 
**Search** | **String** |  | [optional] 
**EnableModernRenewalProfile** | **Boolean** |  | [optional] [default to $false]
**ModernRenewalProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**EnableElectionProfile** | **Boolean** |  | [optional] [default to $false]
**ElectionProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**EnableQuotaProfile** | **Boolean** |  | [optional] [default to $false]
**QuotaProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
**IsKeepQuota** | **Boolean** |  | [optional] [default to $false]
**EnableExternalSharingProfile** | **Boolean** |  | [optional] [default to $false]
**ExternalSharingProfile** | [**GuidModel**](GuidModel.md) | GuidModel model | [optional] 
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
$ApplyCommunityProfilesModel = New-Cloud.Governance.ClientApplyCommunityProfilesModel  -VarFilter null `
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
$ApplyCommunityProfilesModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

