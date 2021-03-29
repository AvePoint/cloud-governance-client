# WorkerJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Method** | **String** |  | [optional] 
**Params** | [**AnyType[]**](AnyType.md) |  | [optional] 
**UpdateTime** | **System.DateTime** |  | [optional] 
**IsTimer** | **Boolean** |  | [optional] [default to $false]
**Status** | [**TaskStatus**](TaskStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Message** | **String** |  | [optional] 
**Priority** | [**TaskPriority**](TaskPriority.md) |  | [optional] 
**PriorityDescription** | **String** |  | [optional] 
**InstanceId** | **String** |  | [optional] 
**IntervalSeconds** | **Int32** |  | [optional] [default to 0]
**NextRunTime** | **System.DateTime** |  | [optional] 
**JobType** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkerJobModel = New-Cloud.Governance.ClientWorkerJobModel  -Id null `
 -TenantId null `
 -Name null `
 -Type null `
 -Method null `
 -Params null `
 -UpdateTime null `
 -IsTimer null `
 -Status null `
 -StatusDescription null `
 -Message null `
 -Priority null `
 -PriorityDescription null `
 -InstanceId null `
 -IntervalSeconds null `
 -NextRunTime null `
 -JobType null `
 -ServiceType null `
 -ServiceTypeDescription null
```

- Convert the resource to JSON
```powershell
$WorkerJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

