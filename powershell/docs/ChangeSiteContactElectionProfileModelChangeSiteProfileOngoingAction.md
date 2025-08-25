# ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HandleOngoingType** | [**HandleOngoingType**](HandleOngoingType.md) |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction = New-Cloud.Governance.ClientChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction  -HandleOngoingType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

