# CreateEquipmentMailboxGalleryBookingOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAllowRepeatedMeetings** | **Boolean** |  | [optional] [default to $false]
**IsAllowScheduOnlyDuringWorkerHours** | **Boolean** |  | [optional] [default to $false]
**AutoReplyMessage** | **String** |  | [optional] 
**IsAutoDecline** | **Boolean** |  | [optional] [default to $false]
**BookingWindowDays** | **String** |  | [optional] 
**MaxDurationHours** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateEquipmentMailboxGalleryBookingOption = New-Cloud.Governance.ClientCreateEquipmentMailboxGalleryBookingOption  -IsAllowRepeatedMeetings null `
 -IsAllowScheduOnlyDuringWorkerHours null `
 -AutoReplyMessage null `
 -IsAutoDecline null `
 -BookingWindowDays null `
 -MaxDurationHours null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateEquipmentMailboxGalleryBookingOption | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

