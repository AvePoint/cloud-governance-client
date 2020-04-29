# MembershipRenewalItemModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**RenewalType**](RenewalType.md) |  | [optional] [default to null]
**User** | **String** |  | [optional] [default to null]
**UserDisplayName** | **String** |  | [optional] [default to null]
**GroupUserType** | [**MembershipUserType**](MembershipUserType.md) |  | [optional] [default to null]
**GroupUserTypeDescription** | **String** |  | [optional] [default to null]
**AccessType** | [**UserAccessType**](UserAccessType.md) |  | [optional] [default to null]
**AccessTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Action** | [**RenewalItemAction**](RenewalItemAction.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientMembershipRenewalItemModel  -Type null `
 -User null `
 -UserDisplayName null `
 -GroupUserType null `
 -GroupUserTypeDescription null `
 -AccessType null `
 -AccessTypeDescription null `
 -Id null `
 -ObjectId null `
 -Action null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

