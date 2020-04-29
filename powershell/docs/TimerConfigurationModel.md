# TimerConfigurationModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsRecertificationJobEnabled** | **Boolean** |  | [optional] [default to null]
**SiteStatusScanJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**WebSynchronizationJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**SiteSynchronizationJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**SiteContentArchivalJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**SiteContactStatusScanJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**GroupOrTeamsSynchronizationJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**UserProfileMetadataSynchronizationJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]
**UserProfileRoleMetadataSynchronizationJob** | [**TimerConfigurationItem**](TimerConfigurationItem.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTimerConfigurationModel  -IsRecertificationJobEnabled null `
 -SiteStatusScanJob null `
 -WebSynchronizationJob null `
 -SiteSynchronizationJob null `
 -SiteContentArchivalJob null `
 -SiteContactStatusScanJob null `
 -GroupOrTeamsSynchronizationJob null `
 -UserProfileMetadataSynchronizationJob null `
 -UserProfileRoleMetadataSynchronizationJob null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

