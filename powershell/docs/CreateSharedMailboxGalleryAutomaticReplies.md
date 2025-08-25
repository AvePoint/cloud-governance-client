# CreateSharedMailboxGalleryAutomaticReplies
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableAutomaticReply** | **Boolean** |  | [optional] [default to $false]
**EnableConfigureTime** | **Boolean** |  | [optional] [default to $false]
**StartDate** | **System.DateTime** |  | [optional] 
**EndDate** | **System.DateTime** |  | [optional] 
**ReplySenderInsider** | **String** |  | [optional] 
**EnableReplySenderOutsider** | **Boolean** |  | [optional] [default to $false]
**ConvertSendReply** | [**ConvertAutomaticReply**](ConvertAutomaticReply.md) |  | [optional] 
**ReplySenderOutsider** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedMailboxGalleryAutomaticReplies = New-Cloud.Governance.ClientCreateSharedMailboxGalleryAutomaticReplies  -EnableAutomaticReply null `
 -EnableConfigureTime null `
 -StartDate null `
 -EndDate null `
 -ReplySenderInsider null `
 -EnableReplySenderOutsider null `
 -ConvertSendReply null `
 -ReplySenderOutsider null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSharedMailboxGalleryAutomaticReplies | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

