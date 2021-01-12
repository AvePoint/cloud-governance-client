# YammerGroupServiceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkId** | **String** |  | [optional] 
**AllowCreate** | **Boolean** |  | [optional] 
**AllowReuseExisting** | **Boolean** |  | [optional] 
**Enabled** | **Boolean** |  | [optional] 
**CreateNewGroupAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**NameOrId** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**YammerGroupType**](YammerGroupType.md) |  | [optional] 
**JoinType** | [**YammerGroupJoinType**](YammerGroupJoinType.md) |  | [optional] 
**IsListInDirectory** | **Boolean** |  | [optional] 
**IsGroupAlreadyExisted** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$YammerGroupServiceSettings = New-Cloud.Governance.ClientYammerGroupServiceSettings  -NetworkId null `
 -AllowCreate null `
 -AllowReuseExisting null `
 -Enabled null `
 -CreateNewGroupAssignBy null `
 -NameOrId null `
 -Description null `
 -Type null `
 -JoinType null `
 -IsListInDirectory null `
 -IsGroupAlreadyExisted null
```

- Convert the resource to JSON
```powershell
$YammerGroupServiceSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

