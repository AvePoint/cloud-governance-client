# MembershipRecertificationItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**InstanceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Type** | [**RecertificationActionType**](RecertificationActionType.md) |  | [optional] [default to null]
**TaskId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Action** | [**RenewalItemAction**](RenewalItemAction.md) |  | [optional] [default to null]
**ActionDescription** | **String** |  | [optional] [readonly] [default to null]
**User** | **String** |  | [optional] [default to null]
**UserDisplayName** | **String** |  | [optional] [default to null]
**MembershipType** | [**MembershipType**](MembershipType.md) |  | [optional] [default to null]
**MembershipTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**AccessType** | [**UserAccessType**](UserAccessType.md) |  | [optional] [default to null]
**AccessTypeDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientMembershipRecertificationItem  -Id null `
 -InstanceId null `
 -Type null `
 -TaskId null `
 -Action null `
 -ActionDescription null `
 -User null `
 -UserDisplayName null `
 -MembershipType null `
 -MembershipTypeDescription null `
 -AccessType null `
 -AccessTypeDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

