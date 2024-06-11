# InviteGuestAddToGroupsRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Groups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedGroups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestAddToGroupsRequestModel = New-Cloud.Governance.ClientInviteGuestAddToGroupsRequestModel  -Groups null `
 -PredefinedGroups null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteGuestAddToGroupsRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

