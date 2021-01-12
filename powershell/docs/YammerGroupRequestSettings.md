# YammerGroupRequestSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameOrId** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**YammerGroupType**](YammerGroupType.md) |  | [optional] 
**JoinType** | [**YammerGroupJoinType**](YammerGroupJoinType.md) |  | [optional] 
**IsListInDirectory** | **Boolean** |  | [optional] 
**IsGroupAlreadyExisted** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$YammerGroupRequestSettings = New-Cloud.Governance.ClientYammerGroupRequestSettings  -NameOrId null `
 -Description null `
 -Type null `
 -JoinType null `
 -IsListInDirectory null `
 -IsGroupAlreadyExisted null
```

- Convert the resource to JSON
```powershell
$YammerGroupRequestSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

