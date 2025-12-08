# ContactElectionMetricsInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectName** | **String** |  | [optional] 
**TriggerTime** | **System.DateTime** |  | [optional] 
**CompletedTime** | **System.DateTime** |  | [optional] 
**IsDeletedByEscalation** | **Boolean** |  | [optional] [default to $false]
**Owners** | **String** |  | [optional] 
**StorageSize** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ContactElectionMetricsInfo = New-Cloud.Governance.ClientContactElectionMetricsInfo  -ObjectId null `
 -ObjectUrl null `
 -ObjectName null `
 -TriggerTime null `
 -CompletedTime null `
 -IsDeletedByEscalation null `
 -Owners null `
 -StorageSize null
```

- Convert the resource to JSON
```powershell
$ContactElectionMetricsInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

