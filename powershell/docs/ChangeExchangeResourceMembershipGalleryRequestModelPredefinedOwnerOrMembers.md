# ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PredefinedMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers = New-Cloud.Governance.ClientChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers  -PredefinedMembers null `
 -PredefinedOwners null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

