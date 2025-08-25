# CreateRoomMailboxGalleryAdditionalInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnableWheel** | **Boolean** |  | [optional] [default to $false]
**Tags** | **String** |  | [optional] 
**AudioDeviceName** | **String** |  | [optional] 
**DisplayDeviceName** | **String** |  | [optional] 
**VideoDeviceName** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateRoomMailboxGalleryAdditionalInformation = New-Cloud.Governance.ClientCreateRoomMailboxGalleryAdditionalInformation  -IsEnableWheel null `
 -Tags null `
 -AudioDeviceName null `
 -DisplayDeviceName null `
 -VideoDeviceName null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateRoomMailboxGalleryAdditionalInformation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

