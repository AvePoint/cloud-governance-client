# MessageApproval
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Moderators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedModerators** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**BypassModerationFromSendersOrMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedBypassModerationFromSendersOrMembers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$MessageApproval = New-Cloud.Governance.ClientMessageApproval  -Moderators null `
 -PredefinedModerators null `
 -BypassModerationFromSendersOrMembers null `
 -PredefinedBypassModerationFromSendersOrMembers null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$MessageApproval | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

