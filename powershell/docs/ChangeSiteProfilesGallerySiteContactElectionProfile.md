# ChangeSiteProfilesGallerySiteContactElectionProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeSiteProfileOngoingAction** | [**ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction**](ChangeSiteContactElectionProfileModelChangeSiteProfileOngoingAction.md) |  | [optional] 
**OriginalProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**DestinationProfile** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteProfilesGallerySiteContactElectionProfile = New-Cloud.Governance.ClientChangeSiteProfilesGallerySiteContactElectionProfile  -ChangeSiteProfileOngoingAction null `
 -OriginalProfile null `
 -DestinationProfile null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfilesGallerySiteContactElectionProfile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

