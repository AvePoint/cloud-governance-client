# JobMonitorModel
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
**Operator** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$JobMonitorModel = New-Cloud.Governance.ClientJobMonitorModel  -Id null `
 -Title null `
 -Type null `
 -TypeDescription null `
 -Mode null `
 -ModeDescription null `
 -Status null `
 -StatusDescription null `
 -FileName null `
 -ModifiedTime null `
 -Operator null
```

- Convert the resource to JSON
```powershell
$JobMonitorModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

