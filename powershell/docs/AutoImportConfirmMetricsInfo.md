# AutoImportConfirmMetricsInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectName** | **String** |  | [optional] 
**TriggerTime** | **System.DateTime** |  | [optional] 
**CompletedTime** | **System.DateTime** |  | [optional] 
**IsDeletedByOwner** | **Boolean** |  | [optional] [default to $false]
**IsDeletedByEscalation** | **Boolean** |  | [optional] [default to $false]
**DeletedBy** | **String** |  | [optional] 
**Owners** | **String** |  | [optional] 
**StorageSize** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$AutoImportConfirmMetricsInfo = New-Cloud.Governance.ClientAutoImportConfirmMetricsInfo  -ObjectId null `
 -ObjectUrl null `
 -ObjectName null `
 -TriggerTime null `
 -CompletedTime null `
 -IsDeletedByOwner null `
 -IsDeletedByEscalation null `
 -DeletedBy null `
 -Owners null `
 -StorageSize null
```

- Convert the resource to JSON
```powershell
$AutoImportConfirmMetricsInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

