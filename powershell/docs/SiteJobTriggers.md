# SiteJobTriggers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RenewalJob** | [**SiteJobTrigger**](SiteJobTrigger.md) |  | [optional] [default to null]
**ContactElectionJob** | [**SiteJobTrigger**](SiteJobTrigger.md) |  | [optional] [default to null]
**StorageThresholdJob** | [**SiteJobTrigger**](SiteJobTrigger.md) |  | [optional] [default to null]
**StatusScanJob** | [**SiteStatusScanJobTrigger**](SiteStatusScanJobTrigger.md) |  | [optional] [default to null]
**AutoLockJob** | [**SiteAutoLockJobTrigger**](SiteAutoLockJobTrigger.md) |  | [optional] [default to null]
**RecertificationJob** | [**SiteRecertificationJobTrigger**](SiteRecertificationJobTrigger.md) |  | [optional] [default to null]
**AutomaticImportJob** | [**AutoImportObjectDemoJob**](AutoImportObjectDemoJob.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteJobTriggers  -RenewalJob null `
 -ContactElectionJob null `
 -StorageThresholdJob null `
 -StatusScanJob null `
 -AutoLockJob null `
 -RecertificationJob null `
 -AutomaticImportJob null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

