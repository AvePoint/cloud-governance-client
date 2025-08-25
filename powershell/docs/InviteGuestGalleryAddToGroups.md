# InviteGuestGalleryAddToGroups
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Groups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedGroups** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestGalleryAddToGroups = New-Cloud.Governance.ClientInviteGuestGalleryAddToGroups  -Groups null `
 -PredefinedGroups null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteGuestGalleryAddToGroups | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

