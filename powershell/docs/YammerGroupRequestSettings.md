# YammerGroupRequestSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameOrId** | **String** | Yammer community name or ID | [optional] 
**Description** | **String** | Yammer community description | [optional] 
**Type** | [**YammerGroupType**](YammerGroupType.md) | Yammer community privacy type | [optional] 
**JoinType** | [**YammerGroupJoinType**](YammerGroupJoinType.md) | Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content. | [optional] 
**IsListInDirectory** | **Boolean** | Whether the Yammer community is associated with a Microsoft 365 Group. | [optional] [default to $false]
**IsGroupAlreadyExisted** | **Boolean** | Whether the Yammer community already exists. | [optional] [default to $false]

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

