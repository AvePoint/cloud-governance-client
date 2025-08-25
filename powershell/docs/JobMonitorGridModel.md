# JobMonitorGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Type** | [**JobType**](JobType.md) |  | [optional] 
**TypeDescription** | **String** |  | [optional] 
**Mode** | [**JobMode**](JobMode.md) |  | [optional] 
**ModeDescription** | **String** |  | [optional] 
**Status** | [**JobStatus**](JobStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 
**ModifiedTime** | **System.DateTime** |  | [optional] 
**Operator** | **String** |  | [optional] 
**OperatorDisplayName** | **String** |  | [optional] 
**IsAllowDownload** | **Boolean** |  | [optional] [default to $false]
**IsAllowStop** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$JobMonitorGridModel = New-Cloud.Governance.ClientJobMonitorGridModel  -Id null `
 -Title null `
 -Type null `
 -TypeDescription null `
 -Mode null `
 -ModeDescription null `
 -Status null `
 -StatusDescription null `
 -FileName null `
 -ModifiedTime null `
 -Operator null `
 -OperatorDisplayName null `
 -IsAllowDownload null `
 -IsAllowStop null
```

- Convert the resource to JSON
```powershell
$JobMonitorGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

