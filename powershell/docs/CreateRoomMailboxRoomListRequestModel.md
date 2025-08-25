# CreateRoomMailboxRoomListRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomList** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateRoomMailboxRoomListRequestModel = New-Cloud.Governance.ClientCreateRoomMailboxRoomListRequestModel  -RoomList null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateRoomMailboxRoomListRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

