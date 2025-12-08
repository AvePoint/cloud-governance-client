# SyncJobMetricsInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectName** | **String** |  | [optional] 
**TriggerTime** | **System.DateTime** |  | [optional] 
**IsRestoredFromRecycleBin** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SyncJobMetricsInfo = New-Cloud.Governance.ClientSyncJobMetricsInfo  -ObjectId null `
 -ObjectUrl null `
 -ObjectName null `
 -TriggerTime null `
 -IsRestoredFromRecycleBin null
```

- Convert the resource to JSON
```powershell
$SyncJobMetricsInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

