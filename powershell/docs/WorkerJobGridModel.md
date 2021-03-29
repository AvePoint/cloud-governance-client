# WorkerJobGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Method** | **String** |  | [optional] 
**UpdateTime** | **System.DateTime** |  | [optional] 
**NextRunTime** | **System.DateTime** |  | [optional] 
**IsTimer** | **Boolean** |  | [optional] [default to $false]
**Status** | [**TaskStatus**](TaskStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Message** | **String** |  | [optional] 
**Priority** | [**TaskPriority**](TaskPriority.md) |  | [optional] 
**PriorityDescription** | **String** |  | [optional] 
**IntervalSeconds** | **Int32** |  | [optional] [default to 0]
**JobType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**JobTypeDescription** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkerJobGridModel = New-Cloud.Governance.ClientWorkerJobGridModel  -Id null `
 -Name null `
 -Type null `
 -Method null `
 -UpdateTime null `
 -NextRunTime null `
 -IsTimer null `
 -Status null `
 -StatusDescription null `
 -Message null `
 -Priority null `
 -PriorityDescription null `
 -IntervalSeconds null `
 -JobType null `
 -JobTypeDescription null
```

- Convert the resource to JSON
```powershell
$WorkerJobGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

