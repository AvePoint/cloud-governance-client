# GroupJobTriggers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RenewalJob** | [**GroupJobTrigger**](GroupJobTrigger.md) |  | [optional] [default to null]
**StatusScanJob** | [**GroupStatusScanJobTrigger**](GroupStatusScanJobTrigger.md) |  | [optional] [default to null]
**DeleteExpiredGroupJob** | [**GroupJobTrigger**](GroupJobTrigger.md) |  | [optional] [default to null]
**ArchiveExpiredGroupJob** | [**GroupJobTrigger**](GroupJobTrigger.md) |  | [optional] [default to null]
**StorageThresholdJob** | [**GroupJobTrigger**](GroupJobTrigger.md) |  | [optional] [default to null]
**RecertificationJob** | [**GroupRecertificationJobTrigger**](GroupRecertificationJobTrigger.md) |  | [optional] [default to null]
**AutomaticImportJob** | [**AutoImportObjectDemoJob**](AutoImportObjectDemoJob.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupJobTriggers  -RenewalJob null `
 -StatusScanJob null `
 -DeleteExpiredGroupJob null `
 -ArchiveExpiredGroupJob null `
 -StorageThresholdJob null `
 -RecertificationJob null `
 -AutomaticImportJob null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

