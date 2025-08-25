# ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsChangeMemberShipType** | **Boolean** |  | [optional] [default to $false]
**MembershipType** | [**AddGroupMemberType**](AddGroupMemberType.md) |  | [optional] 
**Users** | [**UserMembershipInfo[]**](UserMembershipInfo.md) |  | [optional] 
**OriginalDynamicMembershipRules** | [**DynamicGroupRule[]**](DynamicGroupRule.md) |  | [optional] 
**DynamicMembershipRules** | [**DynamicGroupRule[]**](DynamicGroupRule.md) |  | [optional] 
**SubRequestIds** | **String[]** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership = New-Cloud.Governance.ClientChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership  -IsChangeMemberShipType null `
 -MembershipType null `
 -Users null `
 -OriginalDynamicMembershipRules null `
 -DynamicMembershipRules null `
 -SubRequestIds null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

