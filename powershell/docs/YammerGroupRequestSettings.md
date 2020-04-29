# YammerGroupRequestSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameOrId** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**YammerGroupType**](YammerGroupType.md) |  | [optional] [default to null]
**JoinType** | [**YammerGroupJoinType**](YammerGroupJoinType.md) |  | [optional] [default to null]
**IsListInDirectory** | **Boolean** |  | [optional] [default to null]
**IsGroupAlreadyExisted** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientYammerGroupRequestSettings  -NameOrId null `
 -Description null `
 -Type null `
 -JoinType null `
 -IsListInDirectory null `
 -IsGroupAlreadyExisted null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

